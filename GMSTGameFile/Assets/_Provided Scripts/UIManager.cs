using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("UI Bars")]
    [SerializeField] private GameObject healthBarFull;
    [SerializeField] private GameObject healthBarGood;
    [SerializeField] private GameObject healthBarMed;
    [SerializeField] private GameObject healthBarPoor;
    [SerializeField] private GameObject healthBarCrit;
    [SerializeField] private GameObject TPPBarFull;
    [SerializeField] private GameObject TPPBarGood;
    [SerializeField] private GameObject TPPBarMed;
    [SerializeField] private GameObject TPPBarPoor;
    [SerializeField] private GameObject TPPBarCrit;
    [SerializeField] private GameObject waterBarFull;
    [SerializeField] private GameObject waterBarGood;
    [SerializeField] private GameObject waterBarMed;
    [SerializeField] private GameObject waterBarPoor;
    [SerializeField] private GameObject waterBarCrit;
    [SerializeField] private GameObject foodBarFull;
    [SerializeField] private GameObject foodBarGood;
    [SerializeField] private GameObject foodBarMed;
    [SerializeField] private GameObject foodBarPoor;
    [SerializeField] private GameObject foodBarCrit;
    [SerializeField] private TMP_Text akcetext;
    [SerializeField] private TMP_Text hoursremain;
    [SerializeField] private TMP_Text currentloc;  // Reference to TMP_Text for current location
    [SerializeField] private TMP_Text caravanstrengthtext;
    [SerializeField] private GameObject caravanAtt;
    [SerializeField] private GameObject caravanDef;
    [SerializeField] private GameObject hourBarFull;
    [SerializeField] private GameObject hourBar3;
    [SerializeField] private GameObject hourBar2;
    [SerializeField] private GameObject hourBar1;
    [SerializeField] private GameObject hourBar0;

    // Reference to the CurrentLoc script
    private CurrentLoc currentLocScript;

    // Start is called before the first frame update
    private void Awake()
    {
        // Hide all bars initially
        healthBarFull.SetActive(false);
        healthBarGood.SetActive(false);
        healthBarMed.SetActive(false);
        healthBarPoor.SetActive(false);
        healthBarCrit.SetActive(false);

        TPPBarFull.SetActive(false);
        TPPBarGood.SetActive(false);
        TPPBarMed.SetActive(false);
        TPPBarPoor.SetActive(false);
        TPPBarCrit.SetActive(false);

        waterBarFull.SetActive(false);
        waterBarGood.SetActive(false);
        waterBarMed.SetActive(false);
        waterBarPoor.SetActive(false);
        waterBarCrit.SetActive(false);

        foodBarFull.SetActive(false);
        foodBarGood.SetActive(false);
        foodBarMed.SetActive(false);
        foodBarPoor.SetActive(false);
        foodBarCrit.SetActive(false);

        // Caravan Strength - always on
        caravanAtt.SetActive(true);
        caravanDef.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        // Update Akce
        int playerAkce = ((Ink.Runtime.IntValue)DialogueManager
        .GetInstance()
        .GetVariableState("player_Akce")).value;
        akcetext.text = "Current Akçe Amount: " + playerAkce.ToString();

        // Update Current Location - from the Current_Loc script
        if (currentLocScript != null)
        {
            currentloc.text = "Location: " + currentLocScript.GetLocationName();
        }


        // Update Caravan Strength Text
        int playerAttack = ((Ink.Runtime.IntValue)DialogueManager
        .GetInstance()
        .GetVariableState("player_Attack")).value;
        int playerDef = ((Ink.Runtime.IntValue)DialogueManager
        .GetInstance()
        .GetVariableState("player_Defense")).value;
        if (playerAttack <= 9 && playerDef <= 9)
        {
            caravanstrengthtext.text = "Caravan Strength:      00 |       00";
        }
        else
        {
            caravanstrengthtext.text = "Caravan Strength:      " + playerAttack.ToString() + " |       " + playerDef.ToString();
        }


        // Health Bar Updates
        UpdateHealthBar();

        // TPP Bar Updates
        UpdateTPPBar();

        // Water Bar Updates
        UpdateWaterBar();

        // Food Bar Updates
        UpdateFoodBar();

        // Hour Bar Updates
        UpdateHourBar();
    }

    // Method to update health bar based on player's health
    private void UpdateHealthBar()
    {
        int playerHealth = ((Ink.Runtime.IntValue)DialogueManager
        .GetInstance()
        .GetVariableState("player_Health")).value;

        if (playerHealth >= 90)
        {
            healthBarFull.SetActive(true);
            healthBarGood.SetActive(false);
            healthBarMed.SetActive(false);
            healthBarPoor.SetActive(false);
            healthBarCrit.SetActive(false);
        }
        else if (playerHealth >= 70 && playerHealth < 90)
        {
            healthBarFull.SetActive(false);
            healthBarGood.SetActive(true);
            healthBarMed.SetActive(false);
            healthBarPoor.SetActive(false);
            healthBarCrit.SetActive(false);
        }
        else if (playerHealth >= 50 && playerHealth < 70)
        {
            healthBarFull.SetActive(false);
            healthBarGood.SetActive(false);
            healthBarMed.SetActive(true);
            healthBarPoor.SetActive(false);
            healthBarCrit.SetActive(false);
        }
        else if (playerHealth >= 30 && playerHealth < 50)
        {
            healthBarFull.SetActive(false);
            healthBarGood.SetActive(false);
            healthBarMed.SetActive(false);
            healthBarPoor.SetActive(true);
            healthBarCrit.SetActive(false);
        }
        else if (playerHealth >= 1 && playerHealth < 30)
        {
            healthBarFull.SetActive(false);
            healthBarGood.SetActive(false);
            healthBarMed.SetActive(false);
            healthBarPoor.SetActive(false);
            healthBarCrit.SetActive(true);
        }
        else if (playerHealth <= 0)
        {
            healthBarFull.SetActive(false);
            healthBarGood.SetActive(false);
            healthBarMed.SetActive(false);
            healthBarPoor.SetActive(false);
            healthBarCrit.SetActive(false);
        }
    }

    // Method to update TPP bar based on player's TPP
    private void UpdateTPPBar()
    {
        int playerTPP = ((Ink.Runtime.IntValue)DialogueManager
        .GetInstance()
        .GetVariableState("player_TPP")).value;

        if (playerTPP >= 90)
        {
            TPPBarFull.SetActive(true);
            TPPBarGood.SetActive(false);
            TPPBarMed.SetActive(false);
            TPPBarPoor.SetActive(false);
            TPPBarCrit.SetActive(false);
        }
        else if (playerTPP >= 70 && playerTPP < 90)
        {
            TPPBarFull.SetActive(false);
            TPPBarGood.SetActive(true);
            TPPBarMed.SetActive(false);
            TPPBarPoor.SetActive(false);
            TPPBarCrit.SetActive(false);
        }
        else if (playerTPP >= 50 && playerTPP < 70)
        {
            TPPBarFull.SetActive(false);
            TPPBarGood.SetActive(false);
            TPPBarMed.SetActive(true);
            TPPBarPoor.SetActive(false);
            TPPBarCrit.SetActive(false);
        }
        else if (playerTPP >= 30 && playerTPP < 50)
        {
            TPPBarFull.SetActive(false);
            TPPBarGood.SetActive(false);
            TPPBarMed.SetActive(false);
            TPPBarPoor.SetActive(true);
            TPPBarCrit.SetActive(false);
        }
        else if (playerTPP >= 1 && playerTPP < 30)
        {
            TPPBarFull.SetActive(false);
            TPPBarGood.SetActive(false);
            TPPBarMed.SetActive(false);
            TPPBarPoor.SetActive(false);
            TPPBarCrit.SetActive(true);
        }
        else if (playerTPP <= 0)
        {
            TPPBarFull.SetActive(false);
            TPPBarGood.SetActive(false);
            TPPBarMed.SetActive(false);
            TPPBarPoor.SetActive(false);
            TPPBarCrit.SetActive(false);
        }
    }

    // Method to update water bar based on player's water
    private void UpdateWaterBar()
    {
        int playerWater = ((Ink.Runtime.IntValue)DialogueManager
        .GetInstance()
        .GetVariableState("player_Water")).value;

        if (playerWater >= 90)
        {
            waterBarFull.SetActive(true);
            waterBarGood.SetActive(false);
            waterBarMed.SetActive(false);
            waterBarPoor.SetActive(false);
            waterBarCrit.SetActive(false);
        }
        else if (playerWater >= 70 && playerWater < 90)
        {
            waterBarFull.SetActive(false);
            waterBarGood.SetActive(true);
            waterBarMed.SetActive(false);
            waterBarPoor.SetActive(false);
            waterBarCrit.SetActive(false);
        }
        else if (playerWater >= 50 && playerWater < 70)
        {
            waterBarFull.SetActive(false);
            waterBarGood.SetActive(false);
            waterBarMed.SetActive(true);
            waterBarPoor.SetActive(false);
            waterBarCrit.SetActive(false);
        }
        else if (playerWater >= 30 && playerWater < 50)
        {
            waterBarFull.SetActive(false);
            waterBarGood.SetActive(false);
            waterBarMed.SetActive(false);
            waterBarPoor.SetActive(true);
            waterBarCrit.SetActive(false);
        }
        else if (playerWater >= 1 && playerWater < 30)
        {
            waterBarFull.SetActive(false);
            waterBarGood.SetActive(false);
            waterBarMed.SetActive(false);
            waterBarPoor.SetActive(false);
            waterBarCrit.SetActive(true);
        }
        else if (playerWater <= 0)
        {
            waterBarFull.SetActive(false);
            waterBarGood.SetActive(false);
            waterBarMed.SetActive(false);
            waterBarPoor.SetActive(false);
            waterBarCrit.SetActive(false);
        }
    }

    // Method to update food bar based on player's food
    private void UpdateFoodBar()
    {
        int playerFood = ((Ink.Runtime.IntValue)DialogueManager
        .GetInstance()
        .GetVariableState("player_Food")).value;

        if (playerFood >= 90)
        {
            foodBarFull.SetActive(true);
            foodBarGood.SetActive(false);
            foodBarMed.SetActive(false);
            foodBarPoor.SetActive(false);
            foodBarCrit.SetActive(false);
        }
        else if (playerFood >= 70 && playerFood < 90)
        {
            foodBarFull.SetActive(false);
            foodBarGood.SetActive(true);
            foodBarMed.SetActive(false);
            foodBarPoor.SetActive(false);
            foodBarCrit.SetActive(false);
        }
        else if (playerFood >= 50 && playerFood < 70)
        {
            foodBarFull.SetActive(false);
            foodBarGood.SetActive(false);
            foodBarMed.SetActive(true);
            foodBarPoor.SetActive(false);
            foodBarCrit.SetActive(false);
        }
        else if (playerFood >= 30 && playerFood < 50)
        {
            foodBarFull.SetActive(false);
            foodBarGood.SetActive(false);
            foodBarMed.SetActive(false);
            foodBarPoor.SetActive(true);
            foodBarCrit.SetActive(false);
        }
        else if (playerFood >= 1 && playerFood < 30)
        {
            foodBarFull.SetActive(false);
            foodBarGood.SetActive(false);
            foodBarMed.SetActive(false);
            foodBarPoor.SetActive(false);
            foodBarCrit.SetActive(true);
        }
        else if (playerFood <= 0)
        {
            foodBarFull.SetActive(false);
            foodBarGood.SetActive(false);
            foodBarMed.SetActive(false);
            foodBarPoor.SetActive(false);
            foodBarCrit.SetActive(false);
        }
    }

    // Method to update hour bar based on player's actions
    private void UpdateHourBar()
    {
        int playerHours = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("hours")).value;

        if (playerHours >= 4)
        {
            hourBarFull.SetActive(true);
            hourBar3.SetActive(false);
            hourBar2.SetActive(false);
            hourBar1.SetActive(false);
            hourBar0.SetActive(false);
        }
        else if (playerHours == 3)
        {
            hourBarFull.SetActive(false);
            hourBar3.SetActive(true);
            hourBar2.SetActive(false);
            hourBar1.SetActive(false);
            hourBar0.SetActive(false);
        }
        else if (playerHours == 2)
        {
            hourBarFull.SetActive(false);
            hourBar3.SetActive(false);
            hourBar2.SetActive(true);
            hourBar1.SetActive(false);
            hourBar0.SetActive(false);
        }
        else if (playerHours == 1)
        {
            hourBarFull.SetActive(false);
            hourBar3.SetActive(false);
            hourBar2.SetActive(false);
            hourBar1.SetActive(true);
            hourBar0.SetActive(false);
        }
        else if (playerHours == 0)
        {
            hourBarFull.SetActive(false);
            hourBar3.SetActive(false);
            hourBar2.SetActive(false);
            hourBar1.SetActive(false);
            hourBar0.SetActive(true);
        }
        // Update Hours Remaining
        hoursremain.text = "Hours (Actions) Remaining: " + playerHours.ToString();
    }
}
