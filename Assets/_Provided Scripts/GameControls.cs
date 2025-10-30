using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControls : MonoBehaviour
{
    [SerializeField] private GameObject gameControlsImage;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private GameObject mapMenu;
    [SerializeField] private GameObject storageMenu;

    // References to MapManager and StorageManager
    [SerializeField] private MapManager mapManager;
    [SerializeField] private StorageManager storageManager;

    private void Awake()
    {
        gameControlsImage.SetActive(false);
    }

    void Update()
    {
        // Dialogue overlap fix
        if (dialoguePanel.activeSelf && gameControlsImage.activeSelf)
        {
            CloseControls();
        }
    }

    public void ToggleControls()
    {
        if (gameControlsImage.activeSelf)
        {
            CloseControls();
        }
        else
        {
            OpenControls();

            // Close map or storage if open
            if (mapMenu.activeSelf)
            {
                DeactivateMap();
            }

            if (storageMenu.activeSelf)
            {
                DeactivateStorage();
            }
        }
    }

    private void OpenControls()
    {
        gameControlsImage.SetActive(true);
    }

    public void CloseControls()
    {
        gameControlsImage.SetActive(false);
    }

    public bool IsControlsActive()
    {
        return gameControlsImage.activeSelf;
    }

    // Call DeactivateMap from MapManager
    private void DeactivateMap()
    {
        if (mapManager != null)
        {
            mapManager.DeactivateMap();
        }
    }

    // Call DeactivateStorage from StorageManager
    private void DeactivateStorage()
    {
        if (storageManager != null)
        {
            storageManager.DeactivateStorage();
        }
    }
}
