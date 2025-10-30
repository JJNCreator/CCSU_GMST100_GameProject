using UnityEngine;
using UnityEngine.SceneManagement;

public class Unfreeze : MonoBehaviour
{
    private void Awake()
    {
        // Immediately unfreeze time on awakening
        UnfreezeTime();
    }

    private void Start()
    {
        // Ensure time is unfrozen when the scene starts
        UnfreezeTime();
    }

    private void OnEnable()
    {
        // Subscribe to sceneLoaded event to unfreeze when new scene is loaded
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        // Unsubscribe to avoid memory leaks
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Unfreeze time when a new scene is loaded
        UnfreezeTime();
    }

    private void UnfreezeTime()
    {
        // Only unfreeze if it is currently frozen
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1; // Set time scale to normal
            Debug.Log("PlayerTimeUnfreezer: Time unfrozen.");
        }
    }
}
