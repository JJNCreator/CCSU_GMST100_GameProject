using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [SerializeField] private GameObject map; // The main map GameObject
    [SerializeField] private GameObject dialoguePanel; // Dialogue panel reference
    [SerializeField] private GameObject controlsMenu; // Controls menu reference
    [SerializeField] private GameObject storageMenu; // Storage menu reference
    [SerializeField] private GameObject[] localMaps; // Array to store local maps

    // References to StorageManager and GameControls
    [SerializeField] private StorageManager storageManager;
    [SerializeField] private GameControls gameControlsManager;

    private void Awake()
    {
        map.SetActive(false); // Ensure the map is hidden at the start
    }

    void Update()
    {
        // Dialogue overlap fix
        if (dialoguePanel.activeSelf && map.activeSelf)
        {
            DeactivateMap();
        }
    }

    // Public method to toggle the map
    public void ToggleMap()
    {
        if (map.activeSelf)
        {
            DeactivateMap();
        }
        else
        {
            // Close storage and controls if open
            if (storageMenu.activeSelf)
            {
                DeactivateStorage();
            }

            if (controlsMenu.activeSelf)
            {
                DeactivateControls();
            }

            ActivateMap();
        }
    }

    // Activate the map and show the correct local map
    private void ActivateMap()
    {
        map.SetActive(true);
        int mapLocNum = MapLocVariable.mapLocNum;

        // First, disable all maps
        for (int i = 0; i < localMaps.Length; i++)
        {
            localMaps[i].SetActive(false);
        }

        // Ensure localMaps[0] is always active when the map is open
        if (localMaps.Length > 0)
        {
            localMaps[0].SetActive(true);
        }

        // Activate the correct local map based on mapLocNum
        if (mapLocNum > 0 && mapLocNum < localMaps.Length)
        {
            localMaps[mapLocNum].SetActive(true);
        }
    }

    // Deactivate the map and all local maps
    public void DeactivateMap()
    {
        map.SetActive(false);
        foreach (var localMap in localMaps)
        {
            localMap.SetActive(false);
        }
    }

    public bool IsMapActive()
    {
        return map.activeSelf;
    }

    // Call DeactivateStorage from StorageManager
    private void DeactivateStorage()
    {
        if (storageManager != null)
        {
            storageManager.DeactivateStorage();
        }
    }

    // Call CloseControls from GameControlsManager
    private void DeactivateControls()
    {
        if (gameControlsManager != null)
        {
            gameControlsManager.CloseControls();
        }
    }
}
