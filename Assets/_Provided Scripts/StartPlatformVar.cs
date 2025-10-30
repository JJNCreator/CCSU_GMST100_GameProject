using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class StartPlatformVar : MonoBehaviour
{
    [SerializeField] private GameObject Platform;
    void Awake()
    {
        Platform.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int Roadblock1 = ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("Roadblock_1")).value;
        if (Platform.activeSelf)
        {
            if (Roadblock1 == 1)
            {
                Platform.SetActive(true);
            }
            else
            {
                Platform.SetActive(false);
            };
        }
        else if (!Platform.activeSelf)
        {
            if (Roadblock1 == 0)
            {
                Platform.SetActive(false);
            }
            else
            {
                Platform.SetActive(true);
            };
        };
    }
}