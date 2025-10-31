using System.Collections;
using UnityEngine;
using Ink.Runtime;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public class ChangeSceneInk : MonoBehaviour
{
    [Header("Scene ID")]
    [SerializeField] private int sceneID;

    [Header("Number Used in Ink Script")]
    [SerializeField] private int scenechangenum;

    private bool sceneChanging = false;
    private ScreenFader screenFader;

    private void Start()
    {
        screenFader = FindObjectOfType<ScreenFader>(); // Find the ScreenFader in the scene
        if (screenFader == null)
        {
            Debug.LogError("ChangeSceneInk: No ScreenFader found in scene!");
        }
    }

    private void Update()
    {
        if (sceneChanging) return;

        int scenechangetrigger = ((Ink.Runtime.IntValue)DialogueManager
            .GetInstance()
            .GetVariableState("scenechange")).value;

        if (scenechangetrigger == scenechangenum)
        {
            //StartCoroutine(ChangeSceneRoutine());
            ChangeSceneRoutine().Forget();
        }
    }

    /*private IEnumerator ChangeSceneRoutine()
    {
        sceneChanging = true;

        // Start fade-out immediately, with a duration of 2 seconds
        if (screenFader != null)
        {
            yield return screenFader.FadeOut(5f); // Override with 5 seconds
        }

        // Save game data before changing scenes
        GameData gameData = new GameData();
        DialogueManager.GetInstance().SaveData(gameData);

        SceneManager.LoadScene(sceneID);
    }*/
    private async UniTask ChangeSceneRoutine()
    {
        sceneChanging = true;

        // Start fade-out immediately, with a duration of 2 seconds
        if (screenFader != null)
        {
            //yield return screenFader.FadeOut(5f); // Override with 5 seconds
            await screenFader.FadeOut(5f);
        }

        // Save game data before changing scenes
        GameData gameData = new GameData();
        DialogueManager.GetInstance().SaveData(gameData);

        SceneManager.LoadScene(sceneID);
    }
}
