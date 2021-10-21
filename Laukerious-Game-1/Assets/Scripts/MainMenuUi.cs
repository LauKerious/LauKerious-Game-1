using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

// Neue Scene kreieren > Create Canvas unter Ui > im CAnvas neues Text- TExtMEshPro > Canvas >ui > Button-TextMeshPro

public class MainMenuUi : MonoBehaviour

{
    public void StartGame()
    {
        SceneManager.LoadScene("1");
    }

    public void CloseGame()
    {
        if (Application.isEditor) //überprüfen ob das Programm im Editor läuft
        {
            EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }
    }
}
