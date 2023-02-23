using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Button _restartButtom;
    [SerializeField] private Button _menuButtom;
    //[SerializeField] private int _menuScreen = 0;
    [SerializeField] private TimeCount _timeCount;
    //[SerializeField] private AimingScope _aimingScope;
    [SerializeField] private GameOverScreen _gameOverScreen;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;

    private int _menuScreen = 0;

    private void OnEnable()
    {
        _timeCount.GameOver += OnGameOver;
        _restartButtom.onClick.AddListener(OnRestartButtonClick);
        _menuButtom.onClick.AddListener(OnMenuButtonClick);
    }

    private void OnDisable()
    {
        _timeCount.GameOver -= OnGameOver;
        _restartButtom.onClick.RemoveListener(OnRestartButtonClick);
        _menuButtom.onClick.RemoveListener(OnMenuButtonClick);
    }

    private void OnGameOver()
    {
        _gameOverScreen.gameObject.SetActive(true);
        _audioSource.PlayOneShot(_audioClip);
        Debug.Log("321");
        //_aimingScope.OnReturnButtonClick();
        //Time.timeScale = 0;
    }

    private void OnRestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnMenuButtonClick()
    {
        SceneManager.LoadScene(_menuScreen);
        //this.gameObject.SetActive(false);
        //_menuScreen.gameObject.SetActive(true);
        //Menu.Load();
        //Time.timeScale = 0;
    }
}