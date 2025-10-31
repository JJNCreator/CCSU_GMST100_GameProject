using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Cysharp.Threading.Tasks;

public class ScreenFader : MonoBehaviour
{
    [SerializeField] private Image fadeImage;
    [SerializeField] private float fadeDuration = 0.5f; // Default fade duration for both in and out
    private bool isFading = false;

    private void Awake()
    {
        if (fadeImage == null)
        {
            Debug.LogError("ScreenFader: No fadeImage assigned!");
        }

        // Ensure the fadeImage starts fully black and visible at scene load
        if (fadeImage != null)
        {
            fadeImage.gameObject.SetActive(true);
            fadeImage.color = new Color(0, 0, 0, 1);
        }

        // Subscribe to sceneLoaded event to trigger fade-in after the scene is loaded
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log($"ScreenFader: Scene '{scene.name}' loaded, starting fade-in.");

        // Trigger fade-in only after the scene has loaded, with a custom duration (e.g., 10f)
        if (!isFading)
        {
            //StartCoroutine(FadeIn(5f));  // Custom duration on scene load
            FadeIn(5f).Forget();
        }
    }

    /*public IEnumerator FadeOut(float durationOverride = -1f)
    {
        if (isFading) yield break;

        isFading = true;
        fadeImage.gameObject.SetActive(true);
        float elapsedTime = 0f;
        float duration = (durationOverride > 0f) ? durationOverride : fadeDuration;

        Color color = fadeImage.color;
        color.a = 0f;
        fadeImage.color = color;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;  // ✅ Use scaled time for consistency with game flow
            color.a = Mathf.Clamp01(elapsedTime / duration);
            fadeImage.color = color;
            yield return null;
        }

        color.a = 1f;
        fadeImage.color = color;
        isFading = false;
    }*/

    public async UniTask FadeOut(float durationOverride = -1f)
    {
        if (isFading) return;

        isFading = true;
        fadeImage.gameObject.SetActive(true);
        float elapsedTime = 0f;
        float duration = (durationOverride > 0f) ? durationOverride : fadeDuration;

        Color color = fadeImage.color;
        color.a = 0f;
        fadeImage.color = color;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;  // ✅ Use scaled time for consistency with game flow
            color.a = Mathf.Clamp01(elapsedTime / duration);
            fadeImage.color = color;
            await UniTask.Yield();
        }

        color.a = 1f;
        fadeImage.color = color;
        isFading = false;
    }

    /*public IEnumerator FadeIn(float durationOverride = -1f)
    {
        if (isFading) yield break;

        isFading = true;
        fadeImage.gameObject.SetActive(true);
        fadeImage.color = new Color(0, 0, 0, 1);

        float elapsedTime = 0f;
        float duration = (durationOverride > 0f) ? durationOverride : fadeDuration;

        Color color = fadeImage.color;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;  // ✅ Use scaled time for consistency with game flow
            color.a = Mathf.Clamp01(1f - (elapsedTime / duration));
            fadeImage.color = color;
            yield return null;
        }

        color.a = 0f;
        fadeImage.color = color;
        fadeImage.gameObject.SetActive(false);
        isFading = false;

        Debug.Log("ScreenFader: Fade-in complete.");
    }*/
    public async UniTask FadeIn(float durationOverride = -1f)
    {
        if (isFading) return;

        isFading = true;
        fadeImage.gameObject.SetActive(true);
        fadeImage.color = new Color(0, 0, 0, 1);

        float elapsedTime = 0f;
        float duration = (durationOverride > 0f) ? durationOverride : fadeDuration;

        Color color = fadeImage.color;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;  // ✅ Use scaled time for consistency with game flow
            color.a = Mathf.Clamp01(1f - (elapsedTime / duration));
            fadeImage.color = color;
            await UniTask.Yield();
        }

        color.a = 0f;
        fadeImage.color = color;
        fadeImage.gameObject.SetActive(false);
        isFading = false;

        Debug.Log("ScreenFader: Fade-in complete.");
    }
}
