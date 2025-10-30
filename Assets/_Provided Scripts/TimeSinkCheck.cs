using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

public class TimeSinkCheck : MonoBehaviour
{
    [SerializeField] private GameObject checkmark;
    [SerializeField] private string inkVariableName = "passage_1"; // Set Ink variable in Inspector

    void Awake()
    {
        checkmark.SetActive(false); // Ensure it's off by default
    }

    void Update()
    {
        // Get the variable from Ink story
        object inkVariable = DialogueManager.GetInstance().GetVariableState(inkVariableName);

        // Ensure the variable exists and is of correct type
        if (inkVariable is IntValue intValue)
        {
            checkmark.SetActive(intValue.value == 1);
        }
        else
        {
            Debug.LogWarning($"Ink variable '{inkVariableName}' not found or not an IntValue!");
            checkmark.SetActive(false); // Failsafe: Turn it off if the variable isn't valid
        }
    }
}
