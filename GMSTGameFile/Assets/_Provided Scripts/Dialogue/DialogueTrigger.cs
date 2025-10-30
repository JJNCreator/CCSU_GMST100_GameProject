using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using Ink.Runtime;
using Unity.VisualScripting.Antlr3.Runtime;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;
    [Header("Visual Cue Alt")]
    [SerializeField] private GameObject visualCueAlt;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;



    private PlayerControls playerControls;
    private bool playerInRange;


    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
        visualCueAlt.SetActive(false);
        playerControls = new PlayerControls();

    }
 

    private void OnEnable()
    {
        playerControls.Enable();

    }

    private void Update()
    {
        int See_Alt = ((Ink.Runtime.IntValue)DialogueManager
.GetInstance()
.GetVariableState("combat_vision")).value;
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            if (See_Alt == 0)
            {
                visualCue.SetActive(true);
                visualCueAlt.SetActive(false);
                if (playerControls.Travel.Interact1.triggered && !PauseManager.paused)
                {
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                }
            }
            else if (See_Alt == 1)
            {
                visualCue.SetActive(false);
                visualCueAlt.SetActive(true);
                if (playerControls.Travel.Interact1.triggered && !PauseManager.paused)
                {
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                }
            }
        }
        else
        {
            visualCue.SetActive(false);
            visualCueAlt.SetActive(false);
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