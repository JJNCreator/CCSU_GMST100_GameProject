using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class Roadblock1 : MonoBehaviour
{
    [SerializeField] private GameObject Roadblock_1_Object;
    void Awake()
    {
        Roadblock_1_Object.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int Roadblock1 = ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("Roadblock_1")).value;
        if (Roadblock_1_Object.activeSelf)
        {
            if (Roadblock1 == 1)
            {
                Roadblock_1_Object.SetActive(false);
            }
            else
            {
                Roadblock_1_Object.SetActive(true);
            };
        }
        else if (!Roadblock_1_Object.activeSelf)
        {
            if (Roadblock1 == 0)
            {
                Roadblock_1_Object.SetActive(true);
            }
            else
            {
                Roadblock_1_Object.SetActive(false);
            };
        };
    }
}