using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class RoadblockStartScene : MonoBehaviour
{
    [SerializeField] private GameObject Roadblock_Start_Object;
    void Awake()
    {
        Roadblock_Start_Object.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int RoadblockStart = ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("passage_dreamstart")).value;
        if (Roadblock_Start_Object.activeSelf)
        {
            if (RoadblockStart == 1)
            {
                Roadblock_Start_Object.SetActive(false);
            }
            else
            {
                Roadblock_Start_Object.SetActive(true);
            };
        }
        else if (!Roadblock_Start_Object.activeSelf)
        {
            if (RoadblockStart == 0)
            {
                Roadblock_Start_Object.SetActive(true);
            }
            else
            {
                Roadblock_Start_Object.SetActive(false);
            };
        };
    }
}