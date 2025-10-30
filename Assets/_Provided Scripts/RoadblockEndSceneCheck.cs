using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class RoadblockEndSceneCheck : MonoBehaviour
{
    [SerializeField] private GameObject EndSceneCheck_Object;
    [SerializeField] private GameObject EndSceneCheckReturnStop_Object;
    void Awake()
    {
        EndSceneCheck_Object.SetActive(false);
        EndSceneCheckReturnStop_Object.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int RoadblockEndScene = ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("Roadblock_EndScene")).value;
        if (EndSceneCheck_Object.activeSelf)
        {
            if (RoadblockEndScene == 1)
            {
                EndSceneCheck_Object.SetActive(false);
                EndSceneCheckReturnStop_Object.SetActive(true);
            }
            else if (RoadblockEndScene == 0)
            {
                EndSceneCheck_Object.SetActive(true);
                EndSceneCheckReturnStop_Object.SetActive(false);
            };
        }
        else if (!EndSceneCheck_Object.activeSelf)
        {
            if (RoadblockEndScene == 0)
            {
                EndSceneCheck_Object.SetActive(true);
                EndSceneCheckReturnStop_Object.SetActive(false);
            }
            else if (RoadblockEndScene == 1)
            {
                EndSceneCheck_Object.SetActive(false);
                EndSceneCheckReturnStop_Object.SetActive(true);
            };
        };
    }
}