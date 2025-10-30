using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class GroundManager : MonoBehaviour
{
    [SerializeField] private GameObject GroundMain;
    [SerializeField] private GameObject GroundLower;
    void Awake()
    {
        GroundMain.SetActive(true);
        GroundLower.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int GroundCheck = ((Ink.Runtime.IntValue)DialogueManager
 .GetInstance()
 .GetVariableState("Ground_Check")).value;
        if (GroundMain.activeSelf)
        {
            if (GroundCheck == 0)
            {
                GroundMain.SetActive(true);
                GroundLower.SetActive(false);
            }
            else
            {
                GroundMain.SetActive(false);
                GroundLower.SetActive(true);
            };
        }
        else if (!GroundMain.activeSelf)
        {
            if (GroundCheck == 0)
            {
                GroundMain.SetActive(true);
                GroundLower.SetActive(false);
            }
            else
            {
                GroundMain.SetActive(false);
                GroundLower.SetActive(true);
            };
        };
    }
}