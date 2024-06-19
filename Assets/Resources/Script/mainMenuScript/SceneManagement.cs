using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PindahScene : MonoBehaviour
{
    // void Start()
    // {
    //     SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);
    // }

    public void changeToIngameScene()
    {
        SceneManager.LoadScene("inGameScene");
        Debug.Log("inGameScene Loaded")
    }
}