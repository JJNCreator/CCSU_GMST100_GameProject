using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;


public class CaravanManager : MonoBehaviour
{
   

    private PlayerControls playerControls;
    [SerializeField] private GameObject dialoguePanel;
    [Header("CaravanFrame")]
    [SerializeField] private GameObject caravanFrame;
    [Header("CaravanA Name")]
    [SerializeField] private TMP_Text caravanAname;
    [Header("CaravanA Bonus")]
    [SerializeField] private TMP_Text caravanAbonus;
    [Header("Caravan A Images")]
    [SerializeField] private GameObject caravanAImage1;
    [SerializeField] private GameObject caravanAImage2;
    [SerializeField] private GameObject caravanAImage3;
    [SerializeField] private GameObject caravanAImage4;
    [SerializeField] private GameObject caravanAImage5;
    [SerializeField] private GameObject caravanAImage6;
    [SerializeField] private GameObject caravanAImage7;
    [SerializeField] private GameObject caravanAImage8;
    [SerializeField] private GameObject caravanAImage9;
    [SerializeField] private GameObject caravanAImage10;
    [SerializeField] private GameObject caravanAImage11;
    [Header("Top Right Health")]
    [SerializeField] private GameObject healthBarAFull;
    [SerializeField] private GameObject healthBarAGood;
    [SerializeField] private GameObject healthBarAMed;
    [SerializeField] private GameObject healthBarAPoor;
    [SerializeField] private GameObject healthBarACrit;
    [Header("CaravanB Name")]
    [SerializeField] private TMP_Text caravanBname;
    [Header("CaravanB Bonus")]
    [SerializeField] private TMP_Text caravanBbonus;
    [Header("Caravan B Images")]
    [SerializeField] private GameObject caravanBImage1;
    [SerializeField] private GameObject caravanBImage2;
    [SerializeField] private GameObject caravanBImage3;
    [SerializeField] private GameObject caravanBImage4;
    [SerializeField] private GameObject caravanBImage5;
    [SerializeField] private GameObject caravanBImage6;
    [SerializeField] private GameObject caravanBImage7;
    [SerializeField] private GameObject caravanBImage8;
    [SerializeField] private GameObject caravanBImage9;
    [SerializeField] private GameObject caravanBImage10;
    [SerializeField] private GameObject caravanBImage11;
    [Header("Lower Right Health")]
    [SerializeField] private GameObject healthBarBFull;
    [SerializeField] private GameObject healthBarBGood;
    [SerializeField] private GameObject healthBarBMed;
    [SerializeField] private GameObject healthBarBPoor;
    [SerializeField] private GameObject healthBarBCrit;
    [Header("CaravanC Name")]
    [SerializeField] private TMP_Text caravanCname;
    [Header("CaravanC Bonus")]
    [SerializeField] private TMP_Text caravanCbonus;
    [Header("Caravan C Images")]
    [SerializeField] private GameObject caravanCImage1;
    [SerializeField] private GameObject caravanCImage2;
    [SerializeField] private GameObject caravanCImage3;
    [SerializeField] private GameObject caravanCImage4;
    [SerializeField] private GameObject caravanCImage5;
    [SerializeField] private GameObject caravanCImage6;
    [SerializeField] private GameObject caravanCImage7;
    [SerializeField] private GameObject caravanCImage8;
    [SerializeField] private GameObject caravanCImage9;
    [SerializeField] private GameObject caravanCImage10;
    [SerializeField] private GameObject caravanCImage11;
    [Header("Top Left Health")]
    [SerializeField] private GameObject healthBarCFull;
    [SerializeField] private GameObject healthBarCGood;
    [SerializeField] private GameObject healthBarCMed;
    [SerializeField] private GameObject healthBarCPoor;
    [SerializeField] private GameObject healthBarCCrit;
    [Header("CaravanD Name")]
    [SerializeField] private TMP_Text caravanDname;
    [Header("CaravanD Bonus")]
    [SerializeField] private TMP_Text caravanDbonus;
    [Header("Caravan D Images")]
    [SerializeField] private GameObject caravanDImage1;
    [SerializeField] private GameObject caravanDImage2;
    [SerializeField] private GameObject caravanDImage3;
    [SerializeField] private GameObject caravanDImage4;
    [SerializeField] private GameObject caravanDImage5;
    [SerializeField] private GameObject caravanDImage6;
    [SerializeField] private GameObject caravanDImage7;
    [SerializeField] private GameObject caravanDImage8;
    [SerializeField] private GameObject caravanDImage9;
    [SerializeField] private GameObject caravanDImage10;
    [SerializeField] private GameObject caravanDImage11;
    [Header("Lower Left Health")]
    [SerializeField] private GameObject healthBarDFull;
    [SerializeField] private GameObject healthBarDGood;
    [SerializeField] private GameObject healthBarDMed;
    [SerializeField] private GameObject healthBarDPoor;
    [SerializeField] private GameObject healthBarDCrit;
    [Header("Text Overlap Storage")]
    [SerializeField] private TMP_Text plyname;
    [SerializeField] private TMP_Text plyhome;
    [SerializeField] private TMP_Text plybackgr;
    [SerializeField] private TMP_Text plymission;
    [SerializeField] private TMP_Text plylang;
    [SerializeField] private TMP_Text plynick;


    private void Awake()
    {
        playerControls = new PlayerControls();
        caravanFrame.SetActive(false);
        //Images A//
        caravanAImage1.SetActive(false);
        caravanAImage2.SetActive(false);
        caravanAImage3.SetActive(false);
        caravanAImage4.SetActive(false);
        caravanAImage5.SetActive(false);
        caravanAImage6.SetActive(false);
        caravanAImage7.SetActive(false);
        caravanAImage8.SetActive(false);
        caravanAImage9.SetActive(false);
        caravanAImage10.SetActive(false);
        caravanAImage11.SetActive(false);
        //Images B//
        caravanBImage1.SetActive(false);
        caravanBImage2.SetActive(false);
        caravanBImage3.SetActive(false);
        caravanBImage4.SetActive(false);
        caravanBImage5.SetActive(false);
        caravanBImage6.SetActive(false);
        caravanBImage7.SetActive(false);
        caravanBImage8.SetActive(false);
        caravanBImage9.SetActive(false);
        caravanBImage10.SetActive(false);
        caravanBImage11.SetActive(false);
        //Images C//
        caravanCImage1.SetActive(false);
        caravanCImage2.SetActive(false);
        caravanCImage3.SetActive(false);
        caravanCImage4.SetActive(false);
        caravanCImage5.SetActive(false);
        caravanCImage6.SetActive(false);
        caravanCImage7.SetActive(false);
        caravanCImage8.SetActive(false);
        caravanCImage9.SetActive(false);
        caravanCImage10.SetActive(false);
        caravanCImage11.SetActive(false);
        //Images D//
        caravanDImage1.SetActive(false);
        caravanDImage2.SetActive(false);
        caravanDImage3.SetActive(false);
        caravanDImage4.SetActive(false);
        caravanDImage5.SetActive(false);
        caravanDImage6.SetActive(false);
        caravanDImage7.SetActive(false);
        caravanDImage8.SetActive(false);
        caravanDImage9.SetActive(false);
        caravanDImage10.SetActive(false);
        caravanDImage11.SetActive(false);
        //Health Caravan//
        healthBarAFull.SetActive(false);
        healthBarAGood.SetActive(false);
        healthBarAMed.SetActive(false);
        healthBarAPoor.SetActive(false);
        healthBarACrit.SetActive(false);
        healthBarBFull.SetActive(false);
        healthBarBGood.SetActive(false);
        healthBarBMed.SetActive(false);
        healthBarBPoor.SetActive(false);
        healthBarBCrit.SetActive(false);
        healthBarCFull.SetActive(false);
        healthBarCGood.SetActive(false);
        healthBarCMed.SetActive(false);
        healthBarCPoor.SetActive(false);
        healthBarCCrit.SetActive(false);
        healthBarDFull.SetActive(false);
        healthBarDGood.SetActive(false);
        healthBarDMed.SetActive(false);
        healthBarDPoor.SetActive(false);
        healthBarDCrit.SetActive(false);
    }

    private void OnEnable()
    {
        playerControls.Enable();

    }
    void Update()
    {
        //Dialogue Overlap Fix//
        if (dialoguePanel.activeSelf && !caravanFrame.activeSelf)
        {
            return;
        }
        if (dialoguePanel.activeSelf && caravanFrame.activeSelf)
        {
            caravanFrame.SetActive(false);
            string caravanAnameplace = ((Ink.Runtime.StringValue)DialogueManager
 .GetInstance()
 .GetVariableState("caravanA_Name")).value;
            string caravanBnameplace = ((Ink.Runtime.StringValue)DialogueManager
.GetInstance()
.GetVariableState("caravanB_Name")).value;
            string caravanCnameplace = ((Ink.Runtime.StringValue)DialogueManager
 .GetInstance()
 .GetVariableState("caravanC_Name")).value;
            string caravanDnameplace = ((Ink.Runtime.StringValue)DialogueManager
 .GetInstance()
 .GetVariableState("caravanD_Name")).value;
            string caravanAbonusplace = ((Ink.Runtime.StringValue)DialogueManager
 .GetInstance()
 .GetVariableState("caravanA_Bonus")).value;
            string caravanBbonusplace = ((Ink.Runtime.StringValue)DialogueManager
 .GetInstance()
 .GetVariableState("caravanB_Bonus")).value;
            string caravanCbonusplace = ((Ink.Runtime.StringValue)DialogueManager
 .GetInstance()
 .GetVariableState("caravanC_Bonus")).value;
            string caravanDbonusplace = ((Ink.Runtime.StringValue)DialogueManager
 .GetInstance()
 .GetVariableState("caravanD_Bonus")).value;
            caravanAname.text = "";
            caravanBname.text = "";
            caravanCname.text = "";
            caravanDname.text = "";
            caravanAbonus.text = "";
            caravanBbonus.text = "";
            caravanCbonus.text = "";
            caravanDbonus.text = "";
            //Images A Off//
            caravanAImage1.SetActive(false);
            caravanAImage2.SetActive(false);
            caravanAImage3.SetActive(false);
            caravanAImage4.SetActive(false);
            caravanAImage5.SetActive(false);
            caravanAImage6.SetActive(false);
            caravanAImage7.SetActive(false);
            caravanAImage8.SetActive(false);
            caravanAImage9.SetActive(false);
            caravanAImage10.SetActive(false);
            caravanAImage11.SetActive(false);
            //Images B Off//
            caravanBImage1.SetActive(false);
            caravanBImage2.SetActive(false);
            caravanBImage3.SetActive(false);
            caravanBImage4.SetActive(false);
            caravanBImage5.SetActive(false);
            caravanBImage6.SetActive(false);
            caravanBImage7.SetActive(false);
            caravanBImage8.SetActive(false);
            caravanBImage9.SetActive(false);
            caravanBImage10.SetActive(false);
            caravanBImage11.SetActive(false);
            //Images C Off//
            caravanCImage1.SetActive(false);
            caravanCImage2.SetActive(false);
            caravanCImage3.SetActive(false);
            caravanCImage4.SetActive(false);
            caravanCImage5.SetActive(false);
            caravanCImage6.SetActive(false);
            caravanCImage7.SetActive(false);
            caravanCImage8.SetActive(false);
            caravanCImage9.SetActive(false);
            caravanCImage10.SetActive(false);
            caravanCImage11.SetActive(false);
            //Images D Off//
            caravanDImage1.SetActive(false);
            caravanDImage2.SetActive(false);
            caravanDImage3.SetActive(false);
            caravanDImage4.SetActive(false);
            caravanDImage5.SetActive(false);
            caravanDImage6.SetActive(false);
            caravanDImage7.SetActive(false);
            caravanDImage8.SetActive(false);
            caravanDImage9.SetActive(false);
            caravanDImage10.SetActive(false);
            caravanDImage11.SetActive(false);

            //Health Caravan Off//
            healthBarAFull.SetActive(false);
            healthBarAGood.SetActive(false);
            healthBarAMed.SetActive(false);
            healthBarAPoor.SetActive(false);
            healthBarACrit.SetActive(false);
            healthBarBFull.SetActive(false);
            healthBarBGood.SetActive(false);
            healthBarBMed.SetActive(false);
            healthBarBPoor.SetActive(false);
            healthBarBCrit.SetActive(false);
            healthBarCFull.SetActive(false);
            healthBarCGood.SetActive(false);
            healthBarCMed.SetActive(false);
            healthBarCPoor.SetActive(false);
            healthBarCCrit.SetActive(false);
            healthBarDFull.SetActive(false);
            healthBarDGood.SetActive(false);
            healthBarDMed.SetActive(false);
            healthBarDPoor.SetActive(false);
            healthBarDCrit.SetActive(false);

        }
        //Interact//
        if (playerControls.Travel.Interact3.triggered)
        {
            if (caravanFrame.activeSelf)
            {
                caravanFrame.SetActive(false);
                string caravanAnameplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanA_Name")).value;
                string caravanBnameplace = ((Ink.Runtime.StringValue)DialogueManager
  .GetInstance()
  .GetVariableState("caravanB_Name")).value;
                string caravanCnameplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanC_Name")).value;
                string caravanDnameplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanD_Name")).value;
                string caravanAbonusplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanA_Bonus")).value;
                string caravanBbonusplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanB_Bonus")).value;
                string caravanCbonusplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanC_Bonus")).value;
                string caravanDbonusplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanD_Bonus")).value;
                caravanAname.text = "";
                caravanBname.text = "";
                caravanCname.text = "";
                caravanDname.text = "";
                caravanAbonus.text = "";
                caravanBbonus.text = "";
                caravanCbonus.text = "";
                caravanDbonus.text = "";
                //Images A Off//
                caravanAImage1.SetActive(false);
                caravanAImage2.SetActive(false);
                caravanAImage3.SetActive(false);
                caravanAImage4.SetActive(false);
                caravanAImage5.SetActive(false);
                caravanAImage6.SetActive(false);
                caravanAImage7.SetActive(false);
                caravanAImage8.SetActive(false);
                caravanAImage9.SetActive(false);
                caravanAImage10.SetActive(false);
                caravanAImage11.SetActive(false);
                //Images B Off//
                caravanBImage1.SetActive(false);
                caravanBImage2.SetActive(false);
                caravanBImage3.SetActive(false);
                caravanBImage4.SetActive(false);
                caravanBImage5.SetActive(false);
                caravanBImage6.SetActive(false);
                caravanBImage7.SetActive(false);
                caravanBImage8.SetActive(false);
                caravanBImage9.SetActive(false);
                caravanBImage10.SetActive(false);
                caravanBImage11.SetActive(false);
                //Images C Off//
                caravanCImage1.SetActive(false);
                caravanCImage2.SetActive(false);
                caravanCImage3.SetActive(false);
                caravanCImage4.SetActive(false);
                caravanCImage5.SetActive(false);
                caravanCImage6.SetActive(false);
                caravanCImage7.SetActive(false);
                caravanCImage8.SetActive(false);
                caravanCImage9.SetActive(false);
                caravanCImage10.SetActive(false);
                caravanCImage11.SetActive(false);
                //Images D Off//
                caravanDImage1.SetActive(false);
                caravanDImage2.SetActive(false);
                caravanDImage3.SetActive(false);
                caravanDImage4.SetActive(false);
                caravanDImage5.SetActive(false);
                caravanDImage6.SetActive(false);
                caravanDImage7.SetActive(false);
                caravanDImage8.SetActive(false);
                caravanDImage9.SetActive(false);
                caravanDImage10.SetActive(false);
                caravanDImage11.SetActive(false);

                //Health Caravan Off//
                healthBarAFull.SetActive(false);
                healthBarAGood.SetActive(false);
                healthBarAMed.SetActive(false);
                healthBarAPoor.SetActive(false);
                healthBarACrit.SetActive(false);
                healthBarBFull.SetActive(false);
                healthBarBGood.SetActive(false);
                healthBarBMed.SetActive(false);
                healthBarBPoor.SetActive(false);
                healthBarBCrit.SetActive(false);
                healthBarCFull.SetActive(false);
                healthBarCGood.SetActive(false);
                healthBarCMed.SetActive(false);
                healthBarCPoor.SetActive(false);
                healthBarCCrit.SetActive(false);
                healthBarDFull.SetActive(false);
                healthBarDGood.SetActive(false);
                healthBarDMed.SetActive(false);
                healthBarDPoor.SetActive(false);
                healthBarDCrit.SetActive(false);

            }//end of off

            else
            {
                caravanFrame.SetActive(true);

                string caravanAnameplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanA_Name")).value;
                string caravanBnameplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanB_Name")).value;
                string caravanCnameplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanC_Name")).value;
                string caravanDnameplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanD_Name")).value;
                string caravanAbonusplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanA_Bonus")).value;
                string caravanBbonusplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanB_Bonus")).value;
                string caravanCbonusplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanC_Bonus")).value;
                string caravanDbonusplace = ((Ink.Runtime.StringValue)DialogueManager
     .GetInstance()
     .GetVariableState("caravanD_Bonus")).value;
                caravanAname.text = "Friend: " + caravanAnameplace.ToString();
                caravanBname.text = "Protector: " + caravanBnameplace.ToString();
                caravanCname.text = "Guide: " + caravanCnameplace.ToString();
                caravanDname.text = "Animal: " + caravanDnameplace.ToString();
                caravanAbonus.text = caravanAbonusplace.ToString();
                caravanBbonus.text = caravanBbonusplace.ToString();
                caravanCbonus.text = caravanCbonusplace.ToString();
                caravanDbonus.text = caravanDbonusplace.ToString();

                //Set Caravan Image A//
                int Caravan_A = ((Ink.Runtime.IntValue)DialogueManager
    .GetInstance()
    .GetVariableState("caravanA_Image")).value;
                if (Caravan_A == 0)
                {
                    caravanAImage1.SetActive(false);
                    caravanAImage2.SetActive(false);
                    caravanAImage3.SetActive(false);
                    caravanAImage4.SetActive(false);
                    caravanAImage5.SetActive(false);
                    caravanAImage6.SetActive(false);
                    caravanAImage7.SetActive(false);
                    caravanAImage8.SetActive(false);
                    caravanAImage9.SetActive(false);
                    caravanAImage10.SetActive(false);
                    caravanAImage11.SetActive(false);
                }
                else if (Caravan_A == 1)
                {
                    caravanAImage1.SetActive(true);
                    caravanAImage2.SetActive(false);
                    caravanAImage3.SetActive(false);
                    caravanAImage4.SetActive(false);
                    caravanAImage5.SetActive(false);
                    caravanAImage6.SetActive(false);
                    caravanAImage7.SetActive(false);
                    caravanAImage8.SetActive(false);
                    caravanAImage9.SetActive(false);
                    caravanAImage10.SetActive(false);
                    caravanAImage11.SetActive(false);
                }
                else if (Caravan_A == 2)
                {
                    caravanAImage1.SetActive(false);
                    caravanAImage2.SetActive(true);
                    caravanAImage3.SetActive(false);
                    caravanAImage4.SetActive(false);
                    caravanAImage5.SetActive(false);
                    caravanAImage6.SetActive(false);
                    caravanAImage7.SetActive(false);
                    caravanAImage8.SetActive(false);
                    caravanAImage9.SetActive(false);
                    caravanAImage10.SetActive(false);
                    caravanAImage11.SetActive(false);
                }
                else if (Caravan_A == 3)
                {
                    caravanAImage1.SetActive(false);
                    caravanAImage2.SetActive(false);
                    caravanAImage3.SetActive(true);
                    caravanAImage4.SetActive(false);
                    caravanAImage5.SetActive(false);
                    caravanAImage6.SetActive(false);
                    caravanAImage7.SetActive(false);
                    caravanAImage8.SetActive(false);
                    caravanAImage9.SetActive(false);
                    caravanAImage10.SetActive(false);
                    caravanAImage11.SetActive(false);
                }
                else if (Caravan_A == 4)
                {
                    caravanAImage1.SetActive(false);
                    caravanAImage2.SetActive(false);
                    caravanAImage3.SetActive(false);
                    caravanAImage4.SetActive(true);
                    caravanAImage5.SetActive(false);
                    caravanAImage6.SetActive(false);
                    caravanAImage7.SetActive(false);
                    caravanAImage8.SetActive(false);
                    caravanAImage9.SetActive(false);
                    caravanAImage10.SetActive(false);
                    caravanAImage11.SetActive(false);
                }
                else if (Caravan_A == 5)
                {
                    caravanAImage1.SetActive(false);
                    caravanAImage2.SetActive(false);
                    caravanAImage3.SetActive(false);
                    caravanAImage4.SetActive(false);
                    caravanAImage5.SetActive(true);
                    caravanAImage6.SetActive(false);
                    caravanAImage7.SetActive(false);
                    caravanAImage8.SetActive(false);
                    caravanAImage9.SetActive(false);
                    caravanAImage10.SetActive(false);
                    caravanAImage11.SetActive(false);
                }
                else if (Caravan_A == 6)
                {
                    caravanAImage1.SetActive(false);
                    caravanAImage2.SetActive(false);
                    caravanAImage3.SetActive(false);
                    caravanAImage4.SetActive(false);
                    caravanAImage5.SetActive(false);
                    caravanAImage6.SetActive(true);
                    caravanAImage7.SetActive(false);
                    caravanAImage8.SetActive(false);
                    caravanAImage9.SetActive(false);
                    caravanAImage10.SetActive(false);
                    caravanAImage11.SetActive(false);
                }
                else if (Caravan_A == 7)
                {
                    caravanAImage1.SetActive(false);
                    caravanAImage2.SetActive(false);
                    caravanAImage3.SetActive(false);
                    caravanAImage4.SetActive(false);
                    caravanAImage5.SetActive(false);
                    caravanAImage6.SetActive(false);
                    caravanAImage7.SetActive(true);
                    caravanAImage8.SetActive(false);
                    caravanAImage9.SetActive(false);
                    caravanAImage10.SetActive(false);
                    caravanAImage11.SetActive(false);
                }
                else if (Caravan_A == 8)
                {
                    caravanAImage1.SetActive(false);
                    caravanAImage2.SetActive(false);
                    caravanAImage3.SetActive(false);
                    caravanAImage4.SetActive(false);
                    caravanAImage5.SetActive(false);
                    caravanAImage6.SetActive(false);
                    caravanAImage7.SetActive(false);
                    caravanAImage8.SetActive(true);
                    caravanAImage9.SetActive(false);
                    caravanAImage10.SetActive(false);
                    caravanAImage11.SetActive(false);
                }
                else if (Caravan_A == 9)
                {
                    caravanAImage1.SetActive(false);
                    caravanAImage2.SetActive(false);
                    caravanAImage3.SetActive(false);
                    caravanAImage4.SetActive(false);
                    caravanAImage5.SetActive(false);
                    caravanAImage6.SetActive(false);
                    caravanAImage7.SetActive(false);
                    caravanAImage8.SetActive(false);
                    caravanAImage9.SetActive(true);
                    caravanAImage10.SetActive(false);
                    caravanAImage11.SetActive(false);
                }
                else if (Caravan_A == 10)
                {
                    caravanAImage1.SetActive(false);
                    caravanAImage2.SetActive(false);
                    caravanAImage3.SetActive(false);
                    caravanAImage4.SetActive(false);
                    caravanAImage5.SetActive(false);
                    caravanAImage6.SetActive(false);
                    caravanAImage7.SetActive(false);
                    caravanAImage8.SetActive(false);
                    caravanAImage9.SetActive(false);
                    caravanAImage10.SetActive(true);
                    caravanAImage11.SetActive(false);
                }
                else if (Caravan_A == 11)
                {
                    caravanAImage1.SetActive(false);
                    caravanAImage2.SetActive(false);
                    caravanAImage3.SetActive(false);
                    caravanAImage4.SetActive(false);
                    caravanAImage5.SetActive(false);
                    caravanAImage6.SetActive(false);
                    caravanAImage7.SetActive(false);
                    caravanAImage8.SetActive(false);
                    caravanAImage9.SetActive(false);
                    caravanAImage10.SetActive(false);
                    caravanAImage11.SetActive(true);
                };
                //Set Caravan Image B//
                int Caravan_B = ((Ink.Runtime.IntValue)DialogueManager
    .GetInstance()
    .GetVariableState("caravanB_Image")).value;
                if (Caravan_B == 0)
                {
                    caravanBImage1.SetActive(false);
                    caravanBImage2.SetActive(false);
                    caravanBImage3.SetActive(false);
                    caravanBImage4.SetActive(false);
                    caravanBImage5.SetActive(false);
                    caravanBImage6.SetActive(false);
                    caravanBImage7.SetActive(false);
                    caravanBImage8.SetActive(false);
                    caravanBImage9.SetActive(false);
                    caravanBImage10.SetActive(false);
                    caravanBImage11.SetActive(false);
                }
                else if (Caravan_B == 1)
                {
                    caravanBImage1.SetActive(true);
                    caravanBImage2.SetActive(false);
                    caravanBImage3.SetActive(false);
                    caravanBImage4.SetActive(false);
                    caravanBImage5.SetActive(false);
                    caravanBImage6.SetActive(false);
                    caravanBImage7.SetActive(false);
                    caravanBImage8.SetActive(false);
                    caravanBImage9.SetActive(false);
                    caravanBImage10.SetActive(false);
                    caravanBImage11.SetActive(false);
                }
                else if (Caravan_B == 2)
                {
                    caravanBImage1.SetActive(false);
                    caravanBImage2.SetActive(true);
                    caravanBImage3.SetActive(false);
                    caravanBImage4.SetActive(false);
                    caravanBImage5.SetActive(false);
                    caravanBImage6.SetActive(false);
                    caravanBImage7.SetActive(false);
                    caravanBImage8.SetActive(false);
                    caravanBImage9.SetActive(false);
                    caravanBImage10.SetActive(false);
                    caravanBImage11.SetActive(false);
                }
                else if (Caravan_B == 3)
                {
                    caravanBImage1.SetActive(false);
                    caravanBImage2.SetActive(false);
                    caravanBImage3.SetActive(true);
                    caravanBImage4.SetActive(false);
                    caravanBImage5.SetActive(false);
                    caravanBImage6.SetActive(false);
                    caravanBImage7.SetActive(false);
                    caravanBImage8.SetActive(false);
                    caravanBImage9.SetActive(false);
                    caravanBImage10.SetActive(false);
                    caravanBImage11.SetActive(false);
                }
                else if (Caravan_B == 4)
                {
                    caravanBImage1.SetActive(false);
                    caravanBImage2.SetActive(false);
                    caravanBImage3.SetActive(false);
                    caravanBImage4.SetActive(true);
                    caravanBImage5.SetActive(false);
                    caravanBImage6.SetActive(false);
                    caravanBImage7.SetActive(false);
                    caravanBImage8.SetActive(false);
                    caravanBImage9.SetActive(false);
                    caravanBImage10.SetActive(false);
                    caravanBImage11.SetActive(false);
                }
                else if (Caravan_B == 5)
                {
                    caravanBImage1.SetActive(false);
                    caravanBImage2.SetActive(false);
                    caravanBImage3.SetActive(false);
                    caravanBImage4.SetActive(false);
                    caravanBImage5.SetActive(true);
                    caravanBImage6.SetActive(false);
                    caravanBImage7.SetActive(false);
                    caravanBImage8.SetActive(false);
                    caravanBImage9.SetActive(false);
                    caravanBImage10.SetActive(false);
                    caravanBImage11.SetActive(false);
                }
                else if (Caravan_B == 6)
                {
                    caravanBImage1.SetActive(false);
                    caravanBImage2.SetActive(false);
                    caravanBImage3.SetActive(false);
                    caravanBImage4.SetActive(false);
                    caravanBImage5.SetActive(false);
                    caravanBImage6.SetActive(true);
                    caravanBImage7.SetActive(false);
                    caravanBImage8.SetActive(false);
                    caravanBImage9.SetActive(false);
                    caravanBImage10.SetActive(false);
                    caravanBImage11.SetActive(false);
                }
                else if (Caravan_B == 7)
                {
                    caravanBImage1.SetActive(false);
                    caravanBImage2.SetActive(false);
                    caravanBImage3.SetActive(false);
                    caravanBImage4.SetActive(false);
                    caravanBImage5.SetActive(false);
                    caravanBImage6.SetActive(false);
                    caravanBImage7.SetActive(true);
                    caravanBImage8.SetActive(false);
                    caravanBImage9.SetActive(false);
                    caravanBImage10.SetActive(false);
                    caravanBImage11.SetActive(false);
                }
                else if (Caravan_B == 8)
                {
                    caravanBImage1.SetActive(false);
                    caravanBImage2.SetActive(false);
                    caravanBImage3.SetActive(false);
                    caravanBImage4.SetActive(false);
                    caravanBImage5.SetActive(false);
                    caravanBImage6.SetActive(false);
                    caravanBImage7.SetActive(false);
                    caravanBImage8.SetActive(true);
                    caravanBImage9.SetActive(false);
                    caravanBImage10.SetActive(false);
                    caravanBImage11.SetActive(false);
                }
                else if (Caravan_B == 9)
                {
                    caravanBImage1.SetActive(false);
                    caravanBImage2.SetActive(false);
                    caravanBImage3.SetActive(false);
                    caravanBImage4.SetActive(false);
                    caravanBImage5.SetActive(false);
                    caravanBImage6.SetActive(false);
                    caravanBImage7.SetActive(false);
                    caravanBImage8.SetActive(false);
                    caravanBImage9.SetActive(true);
                    caravanBImage10.SetActive(false);
                    caravanBImage11.SetActive(false);
                }
                else if (Caravan_B == 10)
                {
                    caravanBImage1.SetActive(false);
                    caravanBImage2.SetActive(false);
                    caravanBImage3.SetActive(false);
                    caravanBImage4.SetActive(false);
                    caravanBImage5.SetActive(false);
                    caravanBImage6.SetActive(false);
                    caravanBImage7.SetActive(false);
                    caravanBImage8.SetActive(false);
                    caravanBImage9.SetActive(false);
                    caravanBImage10.SetActive(true);
                    caravanBImage11.SetActive(false);
                }
                else if (Caravan_B == 11)
                {
                    caravanBImage1.SetActive(false);
                    caravanBImage2.SetActive(false);
                    caravanBImage3.SetActive(false);
                    caravanBImage4.SetActive(false);
                    caravanBImage5.SetActive(false);
                    caravanBImage6.SetActive(false);
                    caravanBImage7.SetActive(false);
                    caravanBImage8.SetActive(false);
                    caravanBImage9.SetActive(false);
                    caravanBImage10.SetActive(false);
                    caravanBImage11.SetActive(true);
                };
                //Set Caravan Image C//
                int Caravan_C = ((Ink.Runtime.IntValue)DialogueManager
    .GetInstance()
    .GetVariableState("caravanC_Image")).value;
                if (Caravan_C == 0)
                {
                    caravanCImage1.SetActive(false);
                    caravanCImage2.SetActive(false);
                    caravanCImage3.SetActive(false);
                    caravanCImage4.SetActive(false);
                    caravanCImage5.SetActive(false);
                    caravanCImage6.SetActive(false);
                    caravanCImage7.SetActive(false);
                    caravanCImage8.SetActive(false);
                    caravanCImage9.SetActive(false);
                    caravanCImage10.SetActive(false);
                    caravanCImage11.SetActive(false);
                }
                else if (Caravan_C == 1)
                {
                    caravanCImage1.SetActive(true);
                    caravanCImage2.SetActive(false);
                    caravanCImage3.SetActive(false);
                    caravanCImage4.SetActive(false);
                    caravanCImage5.SetActive(false);
                    caravanCImage6.SetActive(false);
                    caravanCImage7.SetActive(false);
                    caravanCImage8.SetActive(false);
                    caravanCImage9.SetActive(false);
                    caravanCImage10.SetActive(false);
                    caravanCImage11.SetActive(false);
                }
                else if (Caravan_C == 2)
                {
                    caravanCImage1.SetActive(false);
                    caravanCImage2.SetActive(true);
                    caravanCImage3.SetActive(false);
                    caravanCImage4.SetActive(false);
                    caravanCImage5.SetActive(false);
                    caravanCImage6.SetActive(false);
                    caravanCImage7.SetActive(false);
                    caravanCImage8.SetActive(false);
                    caravanCImage9.SetActive(false);
                    caravanCImage10.SetActive(false);
                    caravanCImage11.SetActive(false);
                }
                else if (Caravan_C == 3)
                {
                    caravanCImage1.SetActive(false);
                    caravanCImage2.SetActive(false);
                    caravanCImage3.SetActive(true);
                    caravanCImage4.SetActive(false);
                    caravanCImage5.SetActive(false);
                    caravanCImage6.SetActive(false);
                    caravanCImage7.SetActive(false);
                    caravanCImage8.SetActive(false);
                    caravanCImage9.SetActive(false);
                    caravanCImage10.SetActive(false);
                    caravanCImage11.SetActive(false);
                }
                else if (Caravan_C == 4)
                {
                    caravanCImage1.SetActive(false);
                    caravanCImage2.SetActive(false);
                    caravanCImage3.SetActive(false);
                    caravanCImage4.SetActive(true);
                    caravanCImage5.SetActive(false);
                    caravanCImage6.SetActive(false);
                    caravanCImage7.SetActive(false);
                    caravanCImage8.SetActive(false);
                    caravanCImage9.SetActive(false);
                    caravanCImage10.SetActive(false);
                    caravanCImage11.SetActive(false);
                }
                else if (Caravan_C == 5)
                {
                    caravanCImage1.SetActive(false);
                    caravanCImage2.SetActive(false);
                    caravanCImage3.SetActive(false);
                    caravanCImage4.SetActive(false);
                    caravanCImage5.SetActive(true);
                    caravanCImage6.SetActive(false);
                    caravanCImage7.SetActive(false);
                    caravanCImage8.SetActive(false);
                    caravanCImage9.SetActive(false);
                    caravanCImage10.SetActive(false);
                    caravanCImage11.SetActive(false);
                }
                else if (Caravan_C == 6)
                {
                    caravanCImage1.SetActive(false);
                    caravanCImage2.SetActive(false);
                    caravanCImage3.SetActive(false);
                    caravanCImage4.SetActive(false);
                    caravanCImage5.SetActive(false);
                    caravanCImage6.SetActive(true);
                    caravanCImage7.SetActive(false);
                    caravanCImage8.SetActive(false);
                    caravanCImage9.SetActive(false);
                    caravanCImage10.SetActive(false);
                    caravanCImage11.SetActive(false);
                }
                else if (Caravan_C == 7)
                {
                    caravanCImage1.SetActive(false);
                    caravanCImage2.SetActive(false);
                    caravanCImage3.SetActive(false);
                    caravanCImage4.SetActive(false);
                    caravanCImage5.SetActive(false);
                    caravanCImage6.SetActive(false);
                    caravanCImage7.SetActive(true);
                    caravanCImage8.SetActive(false);
                    caravanCImage9.SetActive(false);
                    caravanCImage10.SetActive(false);
                    caravanCImage11.SetActive(false);
                }
                else if (Caravan_C == 8)
                {
                    caravanCImage1.SetActive(false);
                    caravanCImage2.SetActive(false);
                    caravanCImage3.SetActive(false);
                    caravanCImage4.SetActive(false);
                    caravanCImage5.SetActive(false);
                    caravanCImage6.SetActive(false);
                    caravanCImage7.SetActive(false);
                    caravanCImage8.SetActive(true);
                    caravanCImage9.SetActive(false);
                    caravanCImage10.SetActive(false);
                    caravanCImage11.SetActive(false);
                }
                else if (Caravan_C == 9)
                {
                    caravanCImage1.SetActive(false);
                    caravanCImage2.SetActive(false);
                    caravanCImage3.SetActive(false);
                    caravanCImage4.SetActive(false);
                    caravanCImage5.SetActive(false);
                    caravanCImage6.SetActive(false);
                    caravanCImage7.SetActive(false);
                    caravanCImage8.SetActive(false);
                    caravanCImage9.SetActive(true);
                    caravanCImage10.SetActive(false);
                    caravanCImage11.SetActive(false);
                }
                else if (Caravan_C == 10)
                {
                    caravanCImage1.SetActive(false);
                    caravanCImage2.SetActive(false);
                    caravanCImage3.SetActive(false);
                    caravanCImage4.SetActive(false);
                    caravanCImage5.SetActive(false);
                    caravanCImage6.SetActive(false);
                    caravanCImage7.SetActive(false);
                    caravanCImage8.SetActive(false);
                    caravanCImage9.SetActive(false);
                    caravanCImage10.SetActive(true);
                    caravanCImage11.SetActive(false);
                }
                else if (Caravan_C == 11)
                {
                    caravanCImage1.SetActive(false);
                    caravanCImage2.SetActive(false);
                    caravanCImage3.SetActive(false);
                    caravanCImage4.SetActive(false);
                    caravanCImage5.SetActive(false);
                    caravanCImage6.SetActive(false);
                    caravanCImage7.SetActive(false);
                    caravanCImage8.SetActive(false);
                    caravanCImage9.SetActive(false);
                    caravanCImage10.SetActive(false);
                    caravanCImage11.SetActive(true);
                };
                //Set Caravan Image D//
                int Caravan_D = ((Ink.Runtime.IntValue)DialogueManager
    .GetInstance()
    .GetVariableState("caravanD_Image")).value;
                if (Caravan_D == 0)
                {
                    caravanDImage1.SetActive(false);
                    caravanDImage2.SetActive(false);
                    caravanDImage3.SetActive(false);
                    caravanDImage4.SetActive(false);
                    caravanDImage5.SetActive(false);
                    caravanDImage6.SetActive(false);
                    caravanDImage7.SetActive(false);
                    caravanDImage8.SetActive(false);
                    caravanDImage9.SetActive(false);
                    caravanDImage10.SetActive(false);
                    caravanDImage11.SetActive(false);
                }
                else if (Caravan_D == 1)
                {
                    caravanDImage1.SetActive(true);
                    caravanDImage2.SetActive(false);
                    caravanDImage3.SetActive(false);
                    caravanDImage4.SetActive(false);
                    caravanDImage5.SetActive(false);
                    caravanDImage6.SetActive(false);
                    caravanDImage7.SetActive(false);
                    caravanDImage8.SetActive(false);
                    caravanDImage9.SetActive(false);
                    caravanDImage10.SetActive(false);
                    caravanDImage11.SetActive(false);
                }
                else if (Caravan_D == 2)
                {
                    caravanDImage1.SetActive(false);
                    caravanDImage2.SetActive(true);
                    caravanDImage3.SetActive(false);
                    caravanDImage4.SetActive(false);
                    caravanDImage5.SetActive(false);
                    caravanDImage6.SetActive(false);
                    caravanDImage7.SetActive(false);
                    caravanDImage8.SetActive(false);
                    caravanDImage9.SetActive(false);
                    caravanDImage10.SetActive(false);
                    caravanDImage11.SetActive(false);
                }
                else if (Caravan_D == 3)
                {
                    caravanDImage1.SetActive(false);
                    caravanDImage2.SetActive(false);
                    caravanDImage3.SetActive(true);
                    caravanDImage4.SetActive(false);
                    caravanDImage5.SetActive(false);
                    caravanDImage6.SetActive(false);
                    caravanDImage7.SetActive(false);
                    caravanDImage8.SetActive(false);
                    caravanDImage9.SetActive(false);
                    caravanDImage10.SetActive(false);
                    caravanDImage11.SetActive(false);
                }
                else if (Caravan_D == 4)
                {
                    caravanDImage1.SetActive(false);
                    caravanDImage2.SetActive(false);
                    caravanDImage3.SetActive(false);
                    caravanDImage4.SetActive(true);
                    caravanDImage5.SetActive(false);
                    caravanDImage6.SetActive(false);
                    caravanDImage7.SetActive(false);
                    caravanDImage8.SetActive(false);
                    caravanDImage9.SetActive(false);
                    caravanDImage10.SetActive(false);
                    caravanDImage11.SetActive(false);
                }
                else if (Caravan_D == 5)
                {
                    caravanDImage1.SetActive(false);
                    caravanDImage2.SetActive(false);
                    caravanDImage3.SetActive(false);
                    caravanDImage4.SetActive(false);
                    caravanDImage5.SetActive(true);
                    caravanDImage6.SetActive(false);
                    caravanDImage7.SetActive(false);
                    caravanDImage8.SetActive(false);
                    caravanDImage9.SetActive(false);
                    caravanDImage10.SetActive(false);
                    caravanDImage11.SetActive(false);
                }
                else if (Caravan_D == 6)
                {
                    caravanDImage1.SetActive(false);
                    caravanDImage2.SetActive(false);
                    caravanDImage3.SetActive(false);
                    caravanDImage4.SetActive(false);
                    caravanDImage5.SetActive(false);
                    caravanDImage6.SetActive(true);
                    caravanDImage7.SetActive(false);
                    caravanDImage8.SetActive(false);
                    caravanDImage9.SetActive(false);
                    caravanDImage10.SetActive(false);
                    caravanDImage11.SetActive(false);
                }
                else if (Caravan_D == 7)
                {
                    caravanDImage1.SetActive(false);
                    caravanDImage2.SetActive(false);
                    caravanDImage3.SetActive(false);
                    caravanDImage4.SetActive(false);
                    caravanDImage5.SetActive(false);
                    caravanDImage6.SetActive(false);
                    caravanDImage7.SetActive(true);
                    caravanDImage8.SetActive(false);
                    caravanDImage9.SetActive(false);
                    caravanDImage10.SetActive(false);
                    caravanDImage11.SetActive(false);
                }
                else if (Caravan_D == 8)
                {
                    caravanDImage1.SetActive(false);
                    caravanDImage2.SetActive(false);
                    caravanDImage3.SetActive(false);
                    caravanDImage4.SetActive(false);
                    caravanDImage5.SetActive(false);
                    caravanDImage6.SetActive(false);
                    caravanDImage7.SetActive(false);
                    caravanDImage8.SetActive(true);
                    caravanDImage9.SetActive(false);
                    caravanDImage10.SetActive(false);
                    caravanDImage11.SetActive(false);
                }
                else if (Caravan_D == 9)
                {
                    caravanDImage1.SetActive(false);
                    caravanDImage2.SetActive(false);
                    caravanDImage3.SetActive(false);
                    caravanDImage4.SetActive(false);
                    caravanDImage5.SetActive(false);
                    caravanDImage6.SetActive(false);
                    caravanDImage7.SetActive(false);
                    caravanDImage8.SetActive(false);
                    caravanDImage9.SetActive(true);
                    caravanDImage10.SetActive(false);
                    caravanDImage11.SetActive(false);
                }
                else if (Caravan_D == 10)
                {
                    caravanDImage1.SetActive(false);
                    caravanDImage2.SetActive(false);
                    caravanDImage3.SetActive(false);
                    caravanDImage4.SetActive(false);
                    caravanDImage5.SetActive(false);
                    caravanDImage6.SetActive(false);
                    caravanDImage7.SetActive(false);
                    caravanDImage8.SetActive(false);
                    caravanDImage9.SetActive(false);
                    caravanDImage10.SetActive(true);
                    caravanDImage11.SetActive(false);
                }
                else if (Caravan_D == 11)
                {
                    caravanDImage1.SetActive(false);
                    caravanDImage2.SetActive(false);
                    caravanDImage3.SetActive(false);
                    caravanDImage4.SetActive(false);
                    caravanDImage5.SetActive(false);
                    caravanDImage6.SetActive(false);
                    caravanDImage7.SetActive(false);
                    caravanDImage8.SetActive(false);
                    caravanDImage9.SetActive(false);
                    caravanDImage10.SetActive(false);
                    caravanDImage11.SetActive(true);
                };

                //Character Health Bar A//
                int C_AHealth = ((Ink.Runtime.IntValue)DialogueManager
    .GetInstance()
    .GetVariableState("caravanA_Health")).value;
                if (C_AHealth >= 90)
                {
                    healthBarAFull.SetActive(true);
                    healthBarAGood.SetActive(false);
                    healthBarAMed.SetActive(false);
                    healthBarAPoor.SetActive(false);
                    healthBarACrit.SetActive(false);
                }
                else if (C_AHealth >= 70 && C_AHealth < 90)
                {
                    healthBarAFull.SetActive(false);
                    healthBarAGood.SetActive(true);
                    healthBarAMed.SetActive(false);
                    healthBarAPoor.SetActive(false);
                    healthBarACrit.SetActive(false);

                }
                else if (C_AHealth >= 50 && C_AHealth < 70)
                {
                    healthBarAFull.SetActive(false);
                    healthBarAGood.SetActive(false);
                    healthBarAMed.SetActive(true);
                    healthBarAPoor.SetActive(false);
                    healthBarACrit.SetActive(false);

                }
                else if (C_AHealth >= 30 && C_AHealth < 50)
                {
                    healthBarAFull.SetActive(false);
                    healthBarAGood.SetActive(false);
                    healthBarAMed.SetActive(false);
                    healthBarAPoor.SetActive(true);
                    healthBarACrit.SetActive(false);

                }
                else if (C_AHealth >= 1 && C_AHealth < 30)
                {
                    healthBarAFull.SetActive(false);
                    healthBarAGood.SetActive(false);
                    healthBarAMed.SetActive(false);
                    healthBarAPoor.SetActive(false);
                    healthBarACrit.SetActive(true);

                }
                else if (C_AHealth <= 0)
                {
                    healthBarAFull.SetActive(false);
                    healthBarAGood.SetActive(false);
                    healthBarAMed.SetActive(false);
                    healthBarAPoor.SetActive(false);
                    healthBarACrit.SetActive(false);
                    //If dead//
                    caravanAImage1.SetActive(false);
                    caravanAImage2.SetActive(false);
                    caravanAImage3.SetActive(false);
                    caravanAImage4.SetActive(false);
                    caravanAImage5.SetActive(false);
                    caravanAImage6.SetActive(false);
                    caravanAImage7.SetActive(false);
                    caravanAImage8.SetActive(false);
                    caravanAImage9.SetActive(false);
                    caravanAImage10.SetActive(false);
                    caravanAImage11.SetActive(false);
                    caravanAname.text = "";
                    caravanAbonus.text = "";

                };
                //Character Health Bar B//
                int C_BHealth = ((Ink.Runtime.IntValue)DialogueManager
    .GetInstance()
    .GetVariableState("caravanB_Health")).value;
                if (C_BHealth >= 90)
                {
                    healthBarBFull.SetActive(true);
                    healthBarBGood.SetActive(false);
                    healthBarBMed.SetActive(false);
                    healthBarBPoor.SetActive(false);
                    healthBarBCrit.SetActive(false);
                }
                else if (C_BHealth >= 70 && C_BHealth < 90)
                {
                    healthBarBFull.SetActive(false);
                    healthBarBGood.SetActive(true);
                    healthBarBMed.SetActive(false);
                    healthBarBPoor.SetActive(false);
                    healthBarBCrit.SetActive(false);

                }
                else if (C_BHealth >= 50 && C_BHealth < 70)
                {
                    healthBarBFull.SetActive(false);
                    healthBarBGood.SetActive(false);
                    healthBarBMed.SetActive(true);
                    healthBarBPoor.SetActive(false);
                    healthBarBCrit.SetActive(false);

                }
                else if (C_BHealth >= 30 && C_BHealth < 50)
                {
                    healthBarBFull.SetActive(false);
                    healthBarBGood.SetActive(false);
                    healthBarBMed.SetActive(false);
                    healthBarBPoor.SetActive(true);
                    healthBarBCrit.SetActive(false);

                }
                else if (C_BHealth >= 1 && C_BHealth < 30)
                {
                    healthBarBFull.SetActive(false);
                    healthBarBGood.SetActive(false);
                    healthBarBMed.SetActive(false);
                    healthBarBPoor.SetActive(false);
                    healthBarBCrit.SetActive(true);

                }
                else if (C_BHealth <= 0)
                {
                    healthBarBFull.SetActive(false);
                    healthBarBGood.SetActive(false);
                    healthBarBMed.SetActive(false);
                    healthBarBPoor.SetActive(false);
                    healthBarBCrit.SetActive(false);
                    //If dead//
                    caravanBImage1.SetActive(false);
                    caravanBImage2.SetActive(false);
                    caravanBImage3.SetActive(false);
                    caravanBImage4.SetActive(false);
                    caravanBImage5.SetActive(false);
                    caravanBImage6.SetActive(false);
                    caravanBImage7.SetActive(false);
                    caravanBImage8.SetActive(false);
                    caravanBImage9.SetActive(false);
                    caravanBImage10.SetActive(false);
                    caravanBImage11.SetActive(false);
                    caravanBname.text = "";
                    caravanBbonus.text = "";

                };
                //Character Health Bar C//
                int C_CHealth = ((Ink.Runtime.IntValue)DialogueManager
    .GetInstance()
    .GetVariableState("caravanC_Health")).value;
                if (C_CHealth >= 90)
                {
                    healthBarCFull.SetActive(true);
                    healthBarCGood.SetActive(false);
                    healthBarCMed.SetActive(false);
                    healthBarCPoor.SetActive(false);
                    healthBarCCrit.SetActive(false);
                }
                else if (C_CHealth >= 70 && C_CHealth < 90)
                {
                    healthBarCFull.SetActive(false);
                    healthBarCGood.SetActive(true);
                    healthBarCMed.SetActive(false);
                    healthBarCPoor.SetActive(false);
                    healthBarCCrit.SetActive(false);

                }
                else if (C_CHealth >= 50 && C_CHealth < 70)
                {
                    healthBarCFull.SetActive(false);
                    healthBarCGood.SetActive(false);
                    healthBarCMed.SetActive(true);
                    healthBarCPoor.SetActive(false);
                    healthBarCCrit.SetActive(false);

                }
                else if (C_CHealth >= 30 && C_CHealth < 50)
                {
                    healthBarCFull.SetActive(false);
                    healthBarCGood.SetActive(false);
                    healthBarCMed.SetActive(false);
                    healthBarCPoor.SetActive(true);
                    healthBarCCrit.SetActive(false);

                }
                else if (C_CHealth >= 1 && C_CHealth < 30)
                {
                    healthBarCFull.SetActive(false);
                    healthBarCGood.SetActive(false);
                    healthBarCMed.SetActive(false);
                    healthBarCPoor.SetActive(false);
                    healthBarCCrit.SetActive(true);

                }
                else if (C_CHealth <= 0)
                {
                    healthBarCFull.SetActive(false);
                    healthBarCGood.SetActive(false);
                    healthBarCMed.SetActive(false);
                    healthBarCPoor.SetActive(false);
                    healthBarCCrit.SetActive(false);
                    //If dead//
                    caravanCImage1.SetActive(false);
                    caravanCImage2.SetActive(false);
                    caravanCImage3.SetActive(false);
                    caravanCImage4.SetActive(false);
                    caravanCImage5.SetActive(false);
                    caravanCImage6.SetActive(false);
                    caravanCImage7.SetActive(false);
                    caravanCImage8.SetActive(false);
                    caravanCImage9.SetActive(false);
                    caravanCImage10.SetActive(false);
                    caravanCImage11.SetActive(false);
                    caravanCname.text = "";
                    caravanCbonus.text = "";

                };
                //Character Health Bar D//
                int C_DHealth = ((Ink.Runtime.IntValue)DialogueManager
    .GetInstance()
    .GetVariableState("caravanD_Health")).value;
                if (C_DHealth >= 90)
                {
                    healthBarDFull.SetActive(true);
                    healthBarDGood.SetActive(false);
                    healthBarDMed.SetActive(false);
                    healthBarDPoor.SetActive(false);
                    healthBarDCrit.SetActive(false);
                }
                else if (C_DHealth >= 70 && C_DHealth < 90)
                {
                    healthBarDFull.SetActive(false);
                    healthBarDGood.SetActive(true);
                    healthBarDMed.SetActive(false);
                    healthBarDPoor.SetActive(false);
                    healthBarDCrit.SetActive(false);

                }
                else if (C_DHealth >= 50 && C_DHealth < 70)
                {
                    healthBarDFull.SetActive(false);
                    healthBarDGood.SetActive(false);
                    healthBarDMed.SetActive(true);
                    healthBarDPoor.SetActive(false);
                    healthBarDCrit.SetActive(false);

                }
                else if (C_DHealth >= 30 && C_DHealth < 50)
                {
                    healthBarDFull.SetActive(false);
                    healthBarDGood.SetActive(false);
                    healthBarDMed.SetActive(false);
                    healthBarDPoor.SetActive(true);
                    healthBarDCrit.SetActive(false);

                }
                else if (C_DHealth >= 1 && C_DHealth < 30)
                {
                    healthBarDFull.SetActive(false);
                    healthBarDGood.SetActive(false);
                    healthBarDMed.SetActive(false);
                    healthBarDPoor.SetActive(false);
                    healthBarDCrit.SetActive(true);

                }
                else if (C_DHealth <= 0)
                {
                    healthBarDFull.SetActive(false);
                    healthBarDGood.SetActive(false);
                    healthBarDMed.SetActive(false);
                    healthBarDPoor.SetActive(false);
                    healthBarDCrit.SetActive(false);
                    //If dead//
                    caravanDImage1.SetActive(false);
                    caravanDImage2.SetActive(false);
                    caravanDImage3.SetActive(false);
                    caravanDImage4.SetActive(false);
                    caravanDImage5.SetActive(false);
                    caravanDImage6.SetActive(false);
                    caravanDImage7.SetActive(false);
                    caravanDImage8.SetActive(false);
                    caravanDImage9.SetActive(false);
                    caravanDImage10.SetActive(false);
                    caravanDImage11.SetActive(false);
                    caravanDname.text = "";
                    caravanDbonus.text = "";

                };

            }   
        } //end of trigger               
    } //End of the update function//
    private void OnDisable()
    {
        playerControls.Disable();

    }
}