using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class Roadblock4 : MonoBehaviour
{
    [SerializeField] private GameObject Roadblock_4_Object;
    void Awake()
    {
        Roadblock_4_Object.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int Roadblock4 = ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("Roadblock_4")).value;
        if (Roadblock_4_Object.activeSelf)
        {
            if (Roadblock4 == 1)
            {
                Roadblock_4_Object.SetActive(false);
            }
            else
            {
                Roadblock_4_Object.SetActive(true);
            };
        }
        else if (!Roadblock_4_Object.activeSelf)
        {
            if (Roadblock4 == 0)
            {
                Roadblock_4_Object.SetActive(true);
            }
            else
            {
                Roadblock_4_Object.SetActive(false);
            };
        };
    }
}