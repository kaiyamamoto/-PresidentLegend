using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEditor;


public class TitleScript : MonoBehaviour
{

    public void GamePlay()
    {
        SceneManager.LoadScene("Main");
    }

    public void GameEnd()
    {
#if UNITY_EDITOR
        EditorApplication.Exit(0);
#else
        Application.Quit();
#endif
    }
}
