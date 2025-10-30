using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Ink.Runtime;
using Ink.Parsed;
using UnityEngine.SceneManagement;


public class ExitGame : MonoBehaviour
{
    public void OnClickExit()
    {
        Application.Quit();
    }
}
