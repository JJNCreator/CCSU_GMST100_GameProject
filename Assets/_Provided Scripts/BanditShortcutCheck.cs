using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class BanditShortcutCheck : MonoBehaviour
{
    [SerializeField] private GameObject Roadblock_3_Object; //shortcut
    [SerializeField] private GameObject Roadblock_3_2nd_Object; //interactive
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
 .GetVariableState("adem_quest")).value;
            if (Roadblock3 == 5)
            {
                Roadblock_3_Object.SetActive(true);
                Roadblock_3_2nd_Object.SetActive(false);
            }
            else if (Roadblock3 == 6)
            {
                Roadblock_3_Object.SetActive(true);
                Roadblock_3_2nd_Object.SetActive(true);
            }
            else
            {
                Roadblock_3_Object.SetActive(false);
                Roadblock_3_2nd_Object.SetActive(false);
            };
    }
}