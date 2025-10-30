using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class TeleportStart : MonoBehaviour
{
    [SerializeField] private GameObject Teleport_Object;
    void Awake()
    {
        Teleport_Object.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int Teleport1 = ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("Teleport1")).value;
        if (Teleport_Object.activeSelf)
        {
            if (Teleport1 == 1)
            {
                Teleport_Object.SetActive(true);
            }
            else
            {
                Teleport_Object.SetActive(false);
            };
        }
        else if (!Teleport_Object.activeSelf)
        {
            if (Teleport1 == 0)
            {
                Teleport_Object.SetActive(false);
            }
            else
            {
                Teleport_Object.SetActive(true);
            };
        };
    }
}