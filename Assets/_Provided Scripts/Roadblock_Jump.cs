using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using Ink.Runtime;

public class Roadblock_Jump : MonoBehaviour
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
        int Roadblock_Jumper = ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("Roadblock_Jump")).value;
        if (playerInRange)
        {
            if (Roadblock_J_Object.activeSelf)
            {
                if (Roadblock_Jumper == 1)
                {
                    Roadblock_J_Object.SetActive(false); //you enter box but have defeated jumper and turns it off
                }
                else if (Roadblock_Jumper == 0)
                {
                    Roadblock_J_Object.SetActive(true); //you enter box and it keeps the jumper on because you have not defeated it
                };
            }
            else if (!Roadblock_J_Object.activeSelf)
            {
                if (Roadblock_Jumper == 0)
                {
                    Roadblock_J_Object.SetActive(true); //you enter box and have not defeated jumper, it appears
                }
                else if (Roadblock_Jumper == 1)
                {
                    Roadblock_J_Object.SetActive(false); //you enter box and it is not on and you have already defeated it
                };
            };
        }
        else if (!playerInRange)
        {
            if (Roadblock_J_Object.activeSelf)
            {
                if (Roadblock_Jumper == 1)
                {
                    Roadblock_J_Object.SetActive(false); //defeated the jumper//
                }
                else if (Roadblock_Jumper == 0)
                {
                    Roadblock_J_Object.SetActive(true); //jumper box initiated but you run back before defeat
                };
            }
            else if (!Roadblock_J_Object.activeSelf)
            {
                if (Roadblock_Jumper == 0)
                {
                    Roadblock_J_Object.SetActive(false); //jumper never active out of box - should be start of game state for object
                }
                else if (Roadblock_Jumper == 1)
                {
                    Roadblock_J_Object.SetActive(false); // jumper defeated out of box
                };
            };
        };
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