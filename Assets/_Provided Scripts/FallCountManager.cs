using UnityEngine;

public class FallCountManager : MonoBehaviour
{
    public static FallCountManager Instance;
    public int fallCount;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Keeps it alive across scenes
        }
        else
        {
            Destroy(gameObject); // Ensures there's only one instance
        }
    }

    public void IncrementFallCount()
    {
        fallCount++;
    }
}
