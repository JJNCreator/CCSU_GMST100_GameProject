using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using Ink.Runtime;

public class BanditOff : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject Roadblock_Object_Bandit;
    [SerializeField] private GameObject Roadblock_Object_BanditJ;
    private bool playerInRange;
    void Awake()
    {
        Roadblock_Object_Bandit.SetActive(true);
        Roadblock_Object_BanditJ.SetActive(false);
        playerInRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            if (Roadblock_Object_Bandit.activeSelf)
            {
                Roadblock_Object_Bandit.SetActive(false); //you enter box - Turn off - due to save reload
            }
            else if (!Roadblock_Object_Bandit.activeSelf)
            {
                Roadblock_Object_Bandit.SetActive(false); //if you enter box and it is not active, keep it off
            };
            if (Roadblock_Object_BanditJ.activeSelf)
            {
                Roadblock_Object_BanditJ.SetActive(false); //you enter box - Turn off - due to save reload
            }
            else if (!Roadblock_Object_BanditJ.activeSelf)
            {
                Roadblock_Object_BanditJ.SetActive(false); //if you enter box and it is not active, keep it off
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