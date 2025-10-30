using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class DreamSceneManager : MonoBehaviour
{
    [Header("Scene ID")]
    [SerializeField] private int sceneID;

    private PlayerControls playerControls;
    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            // Increment fall count using FallCountManager
            FallCountManager.Instance.IncrementFallCount();
            Debug.Log("Fall Count Added with Fall: " + FallCountManager.Instance.fallCount);

            // Load the next scene
            SceneManager.LoadScene(sceneID);
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
