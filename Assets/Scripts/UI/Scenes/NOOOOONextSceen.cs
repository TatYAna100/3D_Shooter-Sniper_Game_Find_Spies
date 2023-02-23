using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NOOOOONextSceen : MonoBehaviour
{
    private int _screenIndex;
    private int _levelComplete;


    private void Start()
    {
        _screenIndex = SceneManager.GetActiveScene().buildIndex;
        _levelComplete = PlayerPrefs.GetInt("LevelComplete");
    }

    private void isEndGame()
    {

    }
}