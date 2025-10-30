using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class Roadblock3 : MonoBehaviour
{
    [SerializeField] private GameObject Roadblock_3_Object;
    [SerializeField] private GameObject Roadblock_3_2nd_Object;
    void Awake()
    {
        Roadblock_3_Object.SetActive(false);
        Roadblock_3_2nd_Object.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int Roadblock3 = ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("Roadblock_3")).value;
        if (Roadblock_3_Object.activeSelf)
        {
            if (Roadblock3 == 1)
            {
                Roadblock_3_Object.SetActive(false);
                Roadblock_3_2nd_Object.SetActive(false);
            }
            else
            {
                Roadblock_3_Object.SetActive(true);
                Roadblock_3_2nd_Object.SetActive(true);
            };
        }
        else if (!Roadblock_3_Object.activeSelf)
        {
            if (Roadblock3 == 0)
            {
                Roadblock_3_Object.SetActive(true);
                Roadblock_3_2nd_Object.SetActive(true);
            }
            else
            {
                Roadblock_3_Object.SetActive(false);
                Roadblock_3_2nd_Object.SetActive(false);
            };
        };
    }
}