using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExerciseScreen : MonoBehaviour
{
    [SerializeField] private Button _exerciseButtom;
    //[SerializeField] private GameScreen _gameScreen;

    private void OnEnable()
    {
        _exerciseButtom.onClick.AddListener(OnExerciseButtonClick);
    }

    private void OnDisable()
    {
        _exerciseButtom.onClick.RemoveListener(OnExerciseButtonClick);
    }

    //private void Start()
    //{
    //    this.gameObject.SetActive(true);
    //}

    private void OnExerciseButtonClick()
    {
        this.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}