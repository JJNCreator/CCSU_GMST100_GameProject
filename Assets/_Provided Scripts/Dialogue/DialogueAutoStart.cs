using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using Ink.Runtime;
using Unity.VisualScripting.Antlr3.Runtime;
using Cysharp.Threading.Tasks;

public class DialogueAutoStart : MonoBehaviour
{
    [SerializeField] private TextAsset inkJSON; // Assign this in the Inspector

    private void Start()
    {
        //StartCoroutine(StartDialogueAfterFrames(2));
        StartDialogueAfterFrames(2).Forget();
    }

    /*private IEnumerator StartDialogueAfterFrames(int frames)
    {
        for (int i = 0; i < frames; i++)
        {
            yield return new WaitForEndOfFrame(); // Waits until the end of the frame
        }

        if (!DialogueManager.GetInstance().dialogueIsPlaying)
        {
            DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
        }
    }*/
    private async UniTask StartDialogueAfterFrames(int frames)
    {
        for (int i = 0; i < frames; i++)
        {
            await UniTask.WaitForEndOfFrame(); // Waits until the end of the frame
        }

        if (!DialogueManager.GetInstance().dialogueIsPlaying)
        {
            DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
        }
    }
}
