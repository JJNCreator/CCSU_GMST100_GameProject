using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using Ink.Runtime;
using TMPro;
using UnityEngine.UI;
using Cysharp.Threading.Tasks;

public class Death : MonoBehaviour
{
    [SerializeField] private GameObject deathPopup; // Assign this in the inspector
    public TextMeshProUGUI deathCircumstance; // Assign this in the inspector
    [SerializeField] private Button yesButton; // Yes button restart from checkpoint
    [SerializeField] private Button noButton;  // No button to end game

    [SerializeField] private GameObject dialoguePanel; // Reference to the DialoguePanel
    private bool deathPopupShown = false; // Add this flag
    private GameObject currentFirstSelected;
    private EventSystem eventSystem;
    private PlayerControls playerControls;

    private bool isPaused = false;

    private void Awake()
    {
        deathPopup.SetActive(false);
        eventSystem = EventSystem.current;
        playerControls = new PlayerControls();
    }

    private void Start()
    {
        deathPopup.SetActive(false);
        yesButton.onClick.AddListener(OnYesButtonClicked);
        noButton.onClick.AddListener(OnNoButtonClicked);
    }


    private void Update()
    {
        if (deathPopupShown) return; // Prevent repeated calls

        int PlayerHealth = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("player_Health")).value;
        int PlayerTPP = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("player_TPP")).value;
        int PlayerFood = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("player_Food")).value;
        int PlayerWater = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("player_Water")).value;

        if (PlayerHealth <= 0 || PlayerTPP <= 0 || PlayerFood <= 0 || PlayerWater <= 0)
        {
            deathPopupShown = true; // Set the flag to true
            ShowDeathPopup();
        }
    }
    private void ShowDeathPopup()
    {
        if (isPaused) return; // Prevent repeated calls

        PauseGame(); // Pause the game when the death popup is shown

        // Ensure the DialogueManager fully exits dialogue mode
        DialogueManager dialogueManager = DialogueManager.GetInstance();
        if (dialogueManager != null && dialogueManager.dialogueIsPlaying)
        {
            //dialogueManager.StartCoroutine(dialogueManager.ExitDialogueMode());
            dialogueManager.ExitDialogueMode().Forget();
        }

        deathPopup.SetActive(true);

        // Set the death circumstance text based on which value caused the death
        int PlayerHealth = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("player_Health")).value;
        int PlayerTPP = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("player_TPP")).value;
        int PlayerFood = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("player_Food")).value;
        int PlayerWater = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("player_Water")).value;

        if (PlayerHealth <= 0)
        {
            deathCircumstance.text = "Your journey has ended as you are no longer healthy enough to travel!";
        }
        else if (PlayerTPP <= 0)
        {
            deathCircumstance.text = "Your journey has ended as you have strayed too far from the Pilgrim's Path!";
        }
        else if (PlayerFood <= 0)
        {
            deathCircumstance.text = "Your journey has ended as you have no more food to travel onwards!";
        }
        else if (PlayerWater <= 0)
        {
            deathCircumstance.text = "Your journey has ended as you have no more water to travel onwards!";
        }
        else
        {
            deathCircumstance.text = "Your journey has ended!";
        }

        // Force the EventSystem to refresh
        eventSystem.SetSelectedGameObject(null); // Clear the current selection
        eventSystem.SetSelectedGameObject(noButton.gameObject); // Set "No" as the first selected button

        // Debug the selected button
        Debug.Log("Selected Button: " + eventSystem.currentSelectedGameObject?.name);

        // Activate buttons (important for navigation)
        yesButton.interactable = true;
        noButton.interactable = true;
    }
    public void OnContinueFromCheckpoint()
    {
        // Load the checkpoint data
        CheckpointManager.Instance.LoadCheckpoint();

        // Overwrite the current save file with the checkpoint data
        CheckpointManager.Instance.OverwriteCurrentSaveWithCheckpoint();

        // Deactivate the death popup
        deathPopup.SetActive(false);

        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void OnYesButtonClicked()
    {
        Debug.Log("Restart from Checkpoint Clicked");
        deathPopup.SetActive(false);
        ResumeGame(); // Close the popup
        OnContinueFromCheckpoint();
    }

    public void OnNoButtonClicked()
    {
        Debug.Log("To Death Scene");
        deathPopup.SetActive(false);
        ResumeGame(); // Close the popup
        OnContinueToDeathScene();
    }

    public void OnContinueToDeathScene()
    {
        SceneManager.LoadScene("Death"); // Load the death scene by name
    }

    // Pause the game by setting time scale to 0 and disabling player input
    private void PauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0;
            isPaused = true;

            // Disable player input or any other game actions you want to stop
            // You can disable movement, combat, or other game mechanics here.

            // Set the "No" button as the selected object when the game is paused
            eventSystem.SetSelectedGameObject(noButton.gameObject);
        }
    }

    // Resume the game by setting time scale to 1 and enabling player input
    private void ResumeGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;

            // Re-enable player input or any other game actions you want to resume
            // Enable movement, combat, or other game mechanics here.

            // Restore the previous selected button (if any) when the game resumes
            if (currentFirstSelected != null)
            {
                eventSystem.SetSelectedGameObject(currentFirstSelected);
            }

            // Re-enable the DialoguePanel
            if (dialoguePanel != null)
            {
                dialoguePanel.SetActive(false);
            }
        }
    }
}
