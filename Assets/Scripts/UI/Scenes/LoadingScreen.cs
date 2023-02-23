using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] public int _waitTime;
    //[SerializeField] public ExerciseScreen _exerciseScreen;

    private void Start()
    {
        StartCoroutine(WaitForLevel());
    }

    IEnumerator WaitForLevel()
    {
        yield return new WaitForSeconds(_waitTime);
        SceneManager.LoadScene(0);
    }
}