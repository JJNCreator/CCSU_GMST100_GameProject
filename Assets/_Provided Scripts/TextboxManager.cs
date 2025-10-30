using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TextboxManager : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;
    [SerializeField] private GameObject dialogue_Panel;
    [SerializeField] private GameObject controlsMenu;
    [SerializeField] private GameObject Map;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject storagePanel;



    private PlayerControls playerControls;
    private bool playerInRange;



    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        playerControls = new PlayerControls();

    }


    private void OnEnable()
    {
        playerControls.Enable();

    }

    private void Update()
    {
        if (playerInRange && !dialogue_Panel.activeSelf && !controlsMenu.activeSelf && !Map.activeSelf && !pauseMenu.activeSelf && !storagePanel.activeSelf)
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
}