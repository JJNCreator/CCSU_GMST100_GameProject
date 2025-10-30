using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.InputSystem;

public class Collect9 : MonoBehaviour
{
    [SerializeField] private GameObject Collect_1;
    //general not changed - only need to change the script name + variable it changes///
    [SerializeField] private GameObject Audio_Collect;

    private PlayerControls playerControls;
    private bool playerInRange;
    void Awake()
    {
        Collect_1.SetActive(false);
        Audio_Collect.SetActive(false);
        playerInRange = false;
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();

    }
    // Update is called once per frame
    void Update()
    {
        if (playerInRange && playerControls.Travel.Interact1.triggered)
        {
            ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("collect_9")).value = 1;
            Audio_Collect.SetActive(true);
        };
        if (!playerInRange)
        {
            Audio_Collect.SetActive(false);
        };
        int Collect1 = ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("collect_9")).value;
        if (Collect_1.activeSelf)
        {
            if (Collect1 == 1)
            {
                Collect_1.SetActive(false);
            }
            else
            {
                Collect_1.SetActive(true);
            };
        }
        else if (!Collect_1.activeSelf)
        {
            if (Collect1 == 0)
            {
                Collect_1.SetActive(true);
            }
            else
            {
                Collect_1.SetActive(false);
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