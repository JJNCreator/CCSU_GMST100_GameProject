using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class Dialogue1Check : MonoBehaviour
{
    [SerializeField] private GameObject Dialogue1;
    void Awake()
    {
        Dialogue1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int passage_1 = ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("passage_1")).value;
        if (Dialogue1.activeSelf)
        {
            if (passage_1 == 1)
            {
                Dialogue1.SetActive(false);
            }
            else
            {
                Dialogue1.SetActive(true);
            };
        }
        else if (!Dialogue1.activeSelf)
        {
            if (passage_1 == 0)
            {
                Dialogue1.SetActive(true);
                Debug.Log("Turned ON");
            }
            else
            {
                Dialogue1.SetActive(false);
            };
        };
    }
}