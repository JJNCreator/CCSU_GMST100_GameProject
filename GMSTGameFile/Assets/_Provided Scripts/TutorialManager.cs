using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TutorialManager : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject tutorialbox;
    [SerializeField] private GameObject visualcue;
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
        tutorialbox.SetActive(false);
        visualcue.SetActive(false);
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
            visualcue.SetActive(true);
        }
        else
        {
            tutorialbox.SetActive(false);
            visualcue.SetActive(false);
        }
        if (playerControls.Travel.Interact1.triggered && playerInRange && !tutorialbox.activeSelf)
        {

            tutorialbox.SetActive(true);
        }
        else if (playerControls.Travel.Interact1.triggered && playerInRange && tutorialbox.activeSelf)
        {
            tutorialbox.SetActive(false);
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