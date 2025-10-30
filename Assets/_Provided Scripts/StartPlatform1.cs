using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using Ink.Runtime;

public class StartPlatform1 : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject Platform;
    private bool playerInRange;
    void Awake()
    {
        Platform.SetActive(false);
        playerInRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
                Platform.SetActive(true);
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