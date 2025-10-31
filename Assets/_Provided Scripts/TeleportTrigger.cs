using Cysharp.Threading.Tasks;
using System.Collections;
using UnityEngine;

public class TeleportTrigger : MonoBehaviour
{
    [Header("Teleport Settings")]
    [Tooltip("The position to teleport the player to.")]
    [SerializeField] private Vector2 teleportPosition; // The position to teleport the player to
    [SerializeField] private GameObject visualCue;
    [SerializeField] private ScreenFader screenFader; // Reference to the ScreenFader script
    [SerializeField] private float waitTime = 1f; // Time to wait before teleporting the player after fade-out

    private PlayerControls playerControls;
    private bool playerInRange;
    private AudioSource audioSource; // Reference to the AudioSource component
    private bool isTeleporting = false; // Flag to prevent teleporting multiple times in the same trigger

    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        playerControls = new PlayerControls();

        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource component found on this GameObject.");
        }
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            visualCue.SetActive(true);
        }
        else
        {
            visualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // Check if the collider is the player
        if (other.CompareTag("Player"))
        {
            // Get the PlayerController component from the player
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null && !isTeleporting) // Prevent teleportation if already in process
            {
                // Check if Interact1 is triggered
                if (player.IsInteract1Triggered())
                {
                    // Start the teleport coroutine
                    //StartCoroutine(TeleportWithFade(other));
                    TeleportWithFade(other).Forget();
                }
            }
        }
    }

    /*private IEnumerator TeleportWithFade(Collider2D playerCollider)
    {
        isTeleporting = true; // Set the flag to true to prevent multiple triggers

        // Play the AudioSource if it exists (at the start of the fade)
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // Fade to black
        if (screenFader != null)
        {
            yield return screenFader.FadeOut();
        }

        // Wait for the specified time before moving the player (to give fade-out enough time)
        yield return new WaitForSeconds(waitTime);

        // Now that the fade-out time has passed, teleport the player
        playerCollider.transform.position = teleportPosition;
        Debug.Log("Player teleported to: " + teleportPosition);

        // Fade back in
        if (screenFader != null)
        {
            yield return screenFader.FadeIn();
        }

        isTeleporting = false; // Reset the flag after teleportation is complete
    }*/
    private async UniTask TeleportWithFade(Collider2D playerCollider)
    {
        isTeleporting = true; // Set the flag to true to prevent multiple triggers

        // Play the AudioSource if it exists (at the start of the fade)
        if (audioSource != null)
        {
            audioSource.Play();
        }

        // Fade to black
        if (screenFader != null)
        {
            await screenFader.FadeOut();
        }

        // Wait for the specified time before moving the player (to give fade-out enough time)
        await UniTask.WaitForSeconds(waitTime);

        // Now that the fade-out time has passed, teleport the player
        playerCollider.transform.position = teleportPosition;
        Debug.Log("Player teleported to: " + teleportPosition);

        // Fade back in
        if (screenFader != null)
        {
            await screenFader.FadeIn();
        }

        isTeleporting = false; // Reset the flag after teleportation is complete
    }
}
