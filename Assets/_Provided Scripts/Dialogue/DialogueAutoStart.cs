using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using Ink.Runtime;
using Unity.VisualScripting.Antlr3.Runtime;

public class DialogueAutoStart : MonoBehaviour
{
    [SerializeField] private TextAsset inkJSON; // Assign this in the Inspector

    private void Start()
    {
        StartCoroutine(StartDialogueAfterFrames(2));
    }

    private IEnumerator StartDialogueAfterFrames(int frames)
    {
        for (int i = 0; i < frames; i++)
        {
            yield return new WaitForEndOfFrame(); // Waits until the end of the frame
        }

        if (!DialogueManager.GetInstance().dialogueIsPlaying)
        {
            DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
        }
    }
}
