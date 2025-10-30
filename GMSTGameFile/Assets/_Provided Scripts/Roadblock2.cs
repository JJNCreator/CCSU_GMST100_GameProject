using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class Roadblock2 : MonoBehaviour
{
    [SerializeField] private GameObject Roadblock_2_Object;
    void Awake()
    {
        Roadblock_2_Object.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int Roadblock2 = ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("Roadblock_2")).value;
        if (Roadblock_2_Object.activeSelf)
        {
            if (Roadblock2 == 1)
            {
                Roadblock_2_Object.SetActive(false);
            }
            else
            {
                Roadblock_2_Object.SetActive(true);
            };
        }
        else if (!Roadblock_2_Object.activeSelf)
        {
            if (Roadblock2 == 0)
            {
                Roadblock_2_Object.SetActive(true);
            }
            else
            {
                Roadblock_2_Object.SetActive(false);
            };
        };
    }
}