using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CurrentLoc : MonoBehaviour
{
    [Header("Location Name")]
    [SerializeField] private TMP_Text loc_name;  // Reference to the TMP_Text field for location display
    [SerializeField] private string customLocationName = "Unknown Location";  // Default location text, editable in Inspector

    // Method to update the location name displayed on the UI
    private void UpdateLocationName(string newLocation)
    {
        if (loc_name != null)
        {
            loc_name.text = "Location: " + newLocation;
        }
    }

    // When the player enters the trigger area
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            // Update the location name to the value set in the Inspector
            UpdateLocationName(customLocationName);  // Use the custom location text from the Inspector
        }
    }

    // When the player exits the trigger area
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            // Get the current scene's build index
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            // Set the default location name based on the current scene index
            string defaultLocation = GetDefaultLocationByScene(sceneIndex);

            // Update the location name with the default location value
            UpdateLocationName(defaultLocation);
        }
    }

    // Returns a default location name based on the scene index
    private string GetDefaultLocationByScene(int sceneIndex)
    {
        switch (sceneIndex)
        {
            case 0:
                return "";  // Default empty location
            case 1:
                return "Road of Mostar";
            case 2:
                return "Road to Mostar";
            case 3:
                return "Town of Mostar";
            case 4:
                return "Dream"; //4 is death//
            case 5:
                return "Dream";
            case 6:
                return "Road to Sarajevo"; //5 is death//
            case 7:
                return "Town of Sarajevo"; //5 is death//
            default:
                return "Unknown Location";  // Default for unknown scenes
        }
    }

    // Ensure the location text is correctly initialized when the script is enabled
    private void OnEnable()
    {
        UpdateLocationName("Unknown Location");  // Initialize with a default location
    }

    // Getter for location name, returns the current location text
    public string GetLocationName()
    {
        return loc_name.text;  // Return the current location text
    }
}
