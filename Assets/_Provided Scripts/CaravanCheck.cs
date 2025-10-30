using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class CaravanCheck : MonoBehaviour
{
    [SerializeField] private GameObject ContinueCaravan;
    void Awake()
    {
        ContinueCaravan.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int CaravanCheck1 = ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("passage_2")).value;
        if (ContinueCaravan.activeSelf)
        {
            if (CaravanCheck1 == 0)
            {
                ContinueCaravan.SetActive(false);
            }
            else
            {
                ContinueCaravan.SetActive(true);
            };
        };
    }
}