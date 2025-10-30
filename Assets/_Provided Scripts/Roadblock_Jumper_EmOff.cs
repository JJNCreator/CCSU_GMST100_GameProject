using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using Ink.Runtime;

public class Roadblock_Jumper_EmOff : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject Roadblock_J_Object;
    private bool playerInRange;
    void Awake()
    {
        Roadblock_J_Object.SetActive(false);
        playerInRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            if (Roadblock_J_Object.activeSelf)
            {
                Roadblock_J_Object.SetActive(false); //you enter box - Turn off - due to save reload
            }
            else if (!Roadblock_J_Object.activeSelf)
            {
                Roadblock_J_Object.SetActive(false); //if you enter box and it is not active, keep it off
            };
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