using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class MapMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject mapMenu;
    [SerializeField] private GameObject mapMenuImage;
    [SerializeField] private GameObject pauseMenuButtons;
    [SerializeField] private GameObject MapMenuButtons;
    [SerializeField] private GameObject StartImage;
    [SerializeField] private GameObject dialoguePanel; // Dialogue panel reference
    [SerializeField] private Button backButton; // Button to return to pause menu
    [SerializeField] private List<GameObject> mapImages; // List of all possible map images
    [SerializeField] private List<Button> mapButtons; // Buttons to toggle images

    private GameObject currentlyActiveImage; // Tracks the currently active image
    private EventSystem eventSystem;
    private GameObject previousSelected;

    public bool IsMapMenuActive()
    {
        return mapMenu.activeSelf;
    }
    private void Awake()
    {
        eventSystem = EventSystem.current;
        mapMenu.SetActive(false); // Ensure map menu starts inactive
        MapMenuButtons.SetActive(false);
        mapMenuImage.SetActive(false);

        // Ensure all map images are initially inactive
        foreach (GameObject image in mapImages)
        {
            image.SetActive(false);
        }

        backButton.onClick.AddListener(CloseMapMenu);
    }

    void Update()
    {
        // Dialogue overlap fix
        if (dialoguePanel.activeSelf && mapMenu.activeSelf)
        {
            CloseMapMenu();
        }
    }

    public void OpenMapMenu()
    {
        mapMenu.SetActive(true);
        pauseMenuButtons.SetActive(false); // Disable pause menu buttons
        MapMenuButtons.SetActive(true); // Enable Map Menu Buttons
        mapMenuImage.SetActive(true);

        // Ensure only the currently active image is visible
        foreach (GameObject image in mapImages)
        {
            image.SetActive(image == currentlyActiveImage);
        }

        previousSelected = eventSystem.currentSelectedGameObject;
        eventSystem.SetSelectedGameObject(mapButtons[0].gameObject); // Set first map button as selected
    }

    public void CloseMapMenu()
    {
        mapMenu.SetActive(false);
        mapMenuImage.SetActive(false);
        pauseMenuButtons.SetActive(true); // Re-enable pause menu buttons
        MapMenuButtons.SetActive(false); // Disable Map Menu Buttons

        if (currentlyActiveImage != null)
        {
            currentlyActiveImage.SetActive(false); // Hide currently active image
            currentlyActiveImage = null;
        }

        if (previousSelected != null)
        {
            eventSystem.SetSelectedGameObject(previousSelected); // Restore previous selection
        }
    }

    // Function to be assigned to the buttons in the Inspector
    public void ShowImage(GameObject newImage)
    {
        Debug.Log("ShowImage function called for: " + newImage.name);

        // Deactivate all images before activating the new one
        foreach (GameObject image in mapImages)
        {
            image.SetActive(false);
        }

        // Activate the new image
        if (newImage != null)
        {
            newImage.SetActive(true);
            currentlyActiveImage = newImage;
        }
        else
        {
            Debug.LogError("Assigned GameObject is null!");
        }
    }
}
