using System.Collections;
using UnityEngine;

public class JumpSoundsManager : MonoBehaviour
{
    [SerializeField] private GameObject jumpsound;
    [SerializeField] private GameObject ledgefailsound;
    [SerializeField] private GameObject ledgesound;
    [SerializeField] private PlayerController playerController; // Reference to PlayerController
    [SerializeField] private GameObject ledgelight;

    private PlayerControls playerControls;

    private AudioSource jumpAudioSource;
    private AudioSource ledgeFailAudioSource;
    private AudioSource ledgeAudioSource;

    private Coroutine jumpSoundCoroutine; // To track the jumpsound coroutine
    private float ledgeFailCooldownTimer = 0f; // Cooldown timer for ledgefail sound
    private const float LedgeFailCooldown = .25f; // Cooldown duration in seconds

    private void Awake()
    {
        playerControls = new PlayerControls();

        // Get the AudioSource components
        jumpAudioSource = jumpsound.GetComponent<AudioSource>();
        ledgeFailAudioSource = ledgefailsound.GetComponent<AudioSource>();
        ledgeAudioSource = ledgesound.GetComponent<AudioSource>();

        // Initially deactivate the sound objects
        jumpsound.SetActive(false);
        ledgefailsound.SetActive(false);
        ledgesound.SetActive(false);
        ledgelight.SetActive(false);
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void Update()
    {
        // Update the cooldown timer
        if (ledgeFailCooldownTimer > 0)
        {
            ledgeFailCooldownTimer -= Time.deltaTime;
        }

        if (playerControls.Travel.Jump.triggered)
        {
            // Stop any existing jumpsound coroutine
            if (jumpSoundCoroutine != null)
            {
                StopCoroutine(jumpSoundCoroutine);
                jumpsound.SetActive(false); // Deactivate the jumpsound
            }

            // Start the jumpsound coroutine
            jumpSoundCoroutine = StartCoroutine(PlaySound(jumpsound, jumpAudioSource));
        }
        if (playerController.ledgeDetected) //turns off the light to indicate the ledge is active to climb
            {
            ledgelight.SetActive(true);
            }
        else 
            {
            ledgelight.SetActive(false);
            }
        if (playerControls.Travel.Interact2.triggered)
        {
            // Stop the jumpsound if it's playing
            if (jumpSoundCoroutine != null)
            {
                StopCoroutine(jumpSoundCoroutine);
                jumpsound.SetActive(false); // Deactivate the jumpsound
            }

            // Debug log to check ledgeDetected value
            Debug.Log("Ledge Detected: " + playerController.ledgeDetected);

            // Play the corresponding sound based on ledge detection and grounded state
            if (!playerController.ledgeDetected && !playerController.IsGrounded()) // Check if player is not grounded
            {
                if (ledgeFailCooldownTimer <= 0) // Check if cooldown has expired
                {
                    StartCoroutine(PlaySound(ledgefailsound, ledgeFailAudioSource));
                    ledgeFailCooldownTimer = LedgeFailCooldown; // Reset the cooldown timer
                }
            }
            else if (playerController.ledgeDetected)
            {
                Debug.Log("Playing Ledge Sound"); // Debug log to confirm ledge sound is triggered
                StartCoroutine(PlaySound(ledgesound, ledgeAudioSource));
            }
        }
    }

    private IEnumerator PlaySound(GameObject soundObject, AudioSource audioSource)
    {
        soundObject.SetActive(true);
        audioSource.Play();

        // Debug log to confirm sound is playing
        Debug.Log("Playing Sound: " + soundObject.name);

        // Wait for the length of the audio clip
        yield return new WaitForSeconds(audioSource.clip.length);

        soundObject.SetActive(false);
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
}