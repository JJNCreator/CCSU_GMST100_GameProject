using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class CheckpointManager : MonoBehaviour
{
    private static CheckpointManager instance;
    public static CheckpointManager Instance { get { return instance; } }

    private GameData checkpointData;
    private FileDataHandler checkpointDataHandler;

    [SerializeField] private string checkpointFileName = "checkpoint.save";
    [SerializeField] private bool useEncryption = true;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        checkpointDataHandler = new FileDataHandler(Application.persistentDataPath, checkpointFileName, useEncryption);
    }

    public void CreateCheckpoint()
    {
        checkpointData = new GameData();

        // Find all objects that implement IDataPersistence
        List<IDataPersistence> dataPersistenceObjects = FindAllDataPersistenceObjects();

        // Save data to checkpoint
        foreach (IDataPersistence dataPersistenceObj in dataPersistenceObjects)
        {
            dataPersistenceObj.SaveData(checkpointData);
        }

        // Save the checkpoint data to a file
        checkpointDataHandler.Save(checkpointData, "checkpoint");
        Debug.Log("Checkpoint Created");
    }

    public void LoadCheckpoint()
    {
        // Load the checkpoint data from the file
        checkpointData = checkpointDataHandler.Load("checkpoint");

        if (checkpointData == null)
        {
            Debug.Log("No checkpoint data found.");
            return;
        }

        // Find all objects that implement IDataPersistence
        List<IDataPersistence> dataPersistenceObjects = FindAllDataPersistenceObjects();

        // Load data from checkpoint
        foreach (IDataPersistence dataPersistenceObj in dataPersistenceObjects)
        {
            dataPersistenceObj.LoadData(checkpointData);
        }
    }

    public void OverwriteCurrentSaveWithCheckpoint()
    {
        // Ensure checkpoint data exists
        if (checkpointData == null)
        {
            Debug.LogWarning("No checkpoint data found to overwrite the current save.");
            return;
        }

        // Access the DataPersistenceManager instance
        DataPersistenceManager dataPersistenceManager = DataPersistenceManager.instance;

        if (dataPersistenceManager == null)
        {
            Debug.LogError("DataPersistenceManager instance not found.");
            return;
        }

        // Overwrite the current game data with checkpoint data
        dataPersistenceManager.SaveGameFromCheckpoint(checkpointData);
        Debug.Log("Checkpoint data successfully overwrote the current save file.");
    }

    private List<IDataPersistence> FindAllDataPersistenceObjects()
    {
        IEnumerable<IDataPersistence> dataPersistenceObjects = FindObjectsOfType<MonoBehaviour>(true)
            .OfType<IDataPersistence>();

        return new List<IDataPersistence>(dataPersistenceObjects);
    }
}