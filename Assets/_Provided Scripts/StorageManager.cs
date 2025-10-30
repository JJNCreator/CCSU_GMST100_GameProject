using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StorageManager : MonoBehaviour
{
    [SerializeField] private GameObject gamecontrolsimage; // Controls menu reference
    [SerializeField] private GameObject dialoguePanel; // Dialogue panel reference
    [SerializeField] private GameObject mapMenu; // Map menu reference
    [SerializeField] private GameObject storagePaneldefault; // Storage menu reference
    [SerializeField] private GameObject caravanpanel; // Caravan panel reference
    [SerializeField] private GameObject[] storageLevels; // Array to store storage level GameObjects
    [SerializeField] private TMP_Text invlist; // Inventory list text
    [SerializeField] private TMP_Text invtitle; // Inventory title text
    [SerializeField] private TMP_Text plyname; // Player name text
    [SerializeField] private TMP_Text plyhome; // Player home text
    [SerializeField] private TMP_Text plybackgr; // Player background text
    [SerializeField] private TMP_Text plymission; // Player mission text
    [SerializeField] private TMP_Text plylang; // Player language text
    [SerializeField] private TMP_Text plynick; // Player nickname text
    [SerializeField] private TMP_Text daytext; // Days traveled text

    // References to MapManager and GameControls
    [SerializeField] private MapManager mapManager;
    [SerializeField] private GameControls gameControlsManager;

    private void Awake()
    {
        // Initialize all storage-related GameObjects and text fields
        storagePaneldefault.SetActive(false);
        foreach (var level in storageLevels)
        {
            level.SetActive(false);
        }
        ClearTextFields();
    }

    void Update()
    {
        // Dialogue overlap fix
        if (dialoguePanel.activeSelf && storagePaneldefault.activeSelf)
        {
            DeactivateStorage();
        }
    }

    // Public method to toggle the storage menu
    public void ToggleStorage()
    {
        if (storagePaneldefault.activeSelf)
        {
            DeactivateStorage();
        }
        else
        {
            // Close other menus (Map and Controls and Dialogue)
            if (mapMenu.activeSelf)
            {
                DeactivateMap();
            }
            if (gamecontrolsimage.activeSelf)
            {
                DeactivateControls();
            }
            if (dialoguePanel.activeSelf && storagePaneldefault.activeSelf)
            {
                DeactivateStorage();
            }

            ActivateStorage();
        }
    }

    // Activate the storage menu and update UI
    private void ActivateStorage()
    {
        storagePaneldefault.SetActive(true);

        // Update player information
        string plyname_text = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("player_Name")).value;
        string plyhome_text = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("player_Home")).value;
        string plybackgr_text = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("player_Type_Full")).value;
        string plymission_text = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("player_Mission")).value;
        string plylang_text = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("player_Language")).value;
        string plynick_text = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("player_Nickname")).value;

        if (!caravanpanel.activeSelf)
        {
            plyname.text = "<u>Name:</u><br><br>" + plyname_text;
            plyhome.text = "<u>Hometown:</u><br><br>" + plyhome_text;
            plybackgr.text = "<u>Prominent Relative:</u><br><br>" + plybackgr_text;
            plymission.text = "<u>Goal:</u><br><br>Journey to Mecca " + plymission_text;
            plylang.text = "<u>Languages Known:</u><br><br>Ottoman Turkish, Bosnian, " + plylang_text;
            plynick.text = "<u>Earned Nickname:</u><br><br>" + plynick_text;
        }

        // Update inventory list
        string inv_1_text = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("watch_name")).value;
        string inv_2_text = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("kaftan_name")).value;
        string inv_3_text = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("ganzi_name")).value;
        string inv_4_text = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("wine_name")).value;
        string inv_5_text = ((Ink.Runtime.StringValue)DialogueManager.GetInstance().GetVariableState("manasik_name")).value;
        int storagevalue = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("player_storage")).value;
        int storagemaxvalue = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("player_storagemax")).value;

        invlist.text = "Inventory(Storage Space): " + inv_1_text + inv_2_text + inv_3_text + inv_4_text + inv_5_text + "|| Storage Used: " + storagevalue + " | Storage Max: " + storagemaxvalue;
        invtitle.text = "Inventory List & Storage:";

        // Update days traveled
        float playerDay = ((Ink.Runtime.IntValue)DialogueManager.GetInstance().GetVariableState("current_day")).value;
        daytext.text = "Days Traveled: " + playerDay.ToString();

        // Activate the correct storage level based on storagevalue
        for (int i = 0; i < storageLevels.Length; i++)
        {
            storageLevels[i].SetActive((i + 1) * 10 == storagevalue);
        }
    }

    // Deactivate the storage menu and clear UI
    public void DeactivateStorage()
    {
        storagePaneldefault.SetActive(false);
        foreach (var level in storageLevels)
        {
            level.SetActive(false);
        }
        ClearTextFields();
    }

    // Clear all text fields
    public void ClearTextFields()
    {
        invlist.text = "";
        invtitle.text = "";
        plyname.text = "";
        plyhome.text = "";
        plybackgr.text = "";
        plymission.text = "";
        plylang.text = "";
        plynick.text = "";
        daytext.text = "";
    }

    // Call DeactivateMap from MapManager
    private void DeactivateMap()
    {
        if (mapManager != null)
        {
            mapManager.DeactivateMap();
        }
    }

    // Call DeactivateControls from GameControlsManager
    private void DeactivateControls()
    {
        if (gameControlsManager != null)
        {
            gameControlsManager.CloseControls();
        }
    }

    public bool IsStorageActive()
    {
        return storagePaneldefault.activeSelf;
    }
}
