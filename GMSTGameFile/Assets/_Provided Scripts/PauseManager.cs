using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseManager : MonoBehaviour
{
    public static bool paused = false;
    public GameObject menu;
    [SerializeField] private GameObject pausedText;

    [SerializeField] private Button mapButton;
    [SerializeField] private Button controlsButton;
    [SerializeField] private Button storageButton;
    [SerializeField] private Button returnToMainMenuButton;
    [SerializeField] private Button resumeButton;

    [SerializeField] private MapManager mapManager;
    [SerializeField] private StorageManager storageManager;
    [SerializeField] private GameControls gameControlsManager;

    private EventSystem eventSystem;
    private GameObject currentFirstSelected;

    private PauseAction action;

    // Confirmation Popup UI
    [SerializeField] private GameObject confirmationPopup;  // The confirmation popup panel
    [SerializeField] private Button yesButton;              // Yes button to confirm
    [SerializeField] private Button noButton;               // No button to cancel

    private void Awake()
    {
        action = new PauseAction();
        menu.SetActive(false);
        confirmationPopup.SetActive(false);
        eventSystem = EventSystem.current;
        ResumeGame(); // Make sure game is unpaused on start
    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    private void Start()
    {
        action.Pause.PauseGame.performed += _ => DeterminePause();

        mapButton.onClick.AddListener(OnMapButtonClicked);
        controlsButton.onClick.AddListener(OnControlsButtonClicked);
        storageButton.onClick.AddListener(OnStorageButtonClicked);
        returnToMainMenuButton.onClick.AddListener(OnReturnToMainMenuButtonClicked);
        resumeButton.onClick.AddListener(OnResumeButtonClicked);

        // Initialize confirmation popup buttons
        yesButton.onClick.AddListener(OnYesButtonClicked);
        noButton.onClick.AddListener(OnNoButtonClicked);

        // Hide the confirmation popup initially
        confirmationPopup.SetActive(false);
    }

    void Update()
    {
        UpdatePausedTextVisibility();
    }

    private void DeterminePause()
    {
        MapMenuManager mapMenuManager = FindObjectOfType<MapMenuManager>();

        // If the map menu is open, close it instead of pausing/unpausing
        if (mapMenuManager != null && mapMenuManager.IsMapMenuActive())
        {
            mapMenuManager.CloseMapMenu();
            return;
        }

        // Normal pause behavior
        if (paused)
            ResumeGame();
        else
            PauseGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        paused = true;
        menu.SetActive(true);
        EnableMainMenuButtons();
        UpdatePausedTextVisibility();

        // Save the current selected button and set the Resume button as the first selected button
        currentFirstSelected = eventSystem.currentSelectedGameObject;
        eventSystem.SetSelectedGameObject(resumeButton.gameObject);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        paused = false;
        menu.SetActive(false);

        if (mapManager != null)
            mapManager.DeactivateMap();

        if (storageManager != null)
            storageManager.DeactivateStorage();

        if (gameControlsManager != null)
            gameControlsManager.CloseControls();

        UpdatePausedTextVisibility();

        if (currentFirstSelected != null)
        {
            eventSystem.SetSelectedGameObject(currentFirstSelected);
        }
    }

    private void OnMapButtonClicked()
    {
        Debug.Log("Map button clicked");
        mapManager.ToggleMap();
        FindObjectOfType<MapMenuManager>().OpenMapMenu();
        UpdatePausedTextVisibility();
    }

    private void OnControlsButtonClicked()
    {
        Debug.Log("Controls button clicked");
        gameControlsManager.ToggleControls();
        UpdatePausedTextVisibility();
    }

    private void OnStorageButtonClicked()
    {
        Debug.Log("Storage button clicked");
        storageManager.ToggleStorage();
        UpdatePausedTextVisibility();
    }

    private void OnReturnToMainMenuButtonClicked()
    {
        // Disable main menu buttons to prevent interaction when the confirmation popup is active
        DisableMainMenuButtons();

        // Show the confirmation popup instead of immediately loading the scene
        confirmationPopup.SetActive(true);

        // Make the "No" button the first selected button
        eventSystem.SetSelectedGameObject(noButton.gameObject);
    }

    // Called when "Yes" is clicked on the confirmation popup
    public void OnYesButtonClicked()
    {
        Debug.Log("Confirmed: Returning to Main Menu.");
        SceneManager.LoadScene(0); // Load Main Menu
    }

    // Called when "No" is clicked on the confirmation popup
    public void OnNoButtonClicked()
    {
        Debug.Log("Cancelled: Returning to Main Menu.");
        confirmationPopup.SetActive(false); // Close the confirmation popup

        //Resume game
        ResumeGame();
    }

    private void OnResumeButtonClicked()
    {
        Debug.Log("Resume button clicked");
        ResumeGame();
    }

    private void UpdatePausedTextVisibility()
    {
        if (pausedText != null)
        {
            bool anySubMenuActive = (mapManager != null && mapManager.IsMapActive()) ||
                                    (storageManager != null && storageManager.IsStorageActive()) ||
                                    (gameControlsManager != null && gameControlsManager.IsControlsActive());

            pausedText.SetActive(menu.activeSelf && !anySubMenuActive);
        }
    }

    // Ensure time is reset when a new scene is loaded after returning from a paused state
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        ResumeGame();
    }

    // Disable interaction with main menu buttons when the confirmation popup is active
    private void DisableMainMenuButtons()
    {
        mapButton.interactable = false;
        controlsButton.interactable = false;
        storageButton.interactable = false;
        returnToMainMenuButton.interactable = false;
        resumeButton.interactable = false;
    }

    // Re-enable interaction with main menu buttons after the confirmation popup is closed
    private void EnableMainMenuButtons()
    {
        mapButton.interactable = true;
        controlsButton.interactable = true;
        storageButton.interactable = true;
        returnToMainMenuButton.interactable = true;
        resumeButton.interactable = true;
    }
}
