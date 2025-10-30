using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class DreamSkip : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;
    [Header("Scene ID")]
    [SerializeField] private int sceneID;

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
        if (playerInRange)
        {
            int currentFallCount = FallCountManager.Instance.fallCount;
            Debug.Log("Current Fall Count: " + currentFallCount);

            if (currentFallCount >= 1)
            {
                visualCue.SetActive(true);
                if (playerControls.Travel.Interact1.triggered)
                {
                    SceneManager.LoadScene(sceneID);
                }
            }
            else
            {
                visualCue.SetActive(false);
            }
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
