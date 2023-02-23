using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseScreen : MonoBehaviour
{
    [SerializeField] private Button _continueButtom;
    [SerializeField] private Button _settingsButtom;
    [SerializeField] private Button _menuButtom;
    //[SerializeField] private GameScreen _gameScreen;
    [SerializeField] private SettingsScreen _settingsScreen;
    [SerializeField] private MenuScreen _menuScreen;

    private void OnEnable()
    {
        _continueButtom.onClick.AddListener(OnContinueButtonClick);
        _settingsButtom.onClick.AddListener(OnSettingsButtonClick);
        _menuButtom.onClick.AddListener(OnMenuButtonClick);
    }

    private void OnDisable()
    {
        _continueButtom.onClick.RemoveListener(OnContinueButtonClick);
        _settingsButtom.onClick.RemoveListener(OnSettingsButtonClick);
        _menuButtom.onClick.RemoveListener(OnMenuButtonClick);
    }

    private void OnContinueButtonClick()
    {
        this.gameObject.SetActive(false);
        Time.timeScale = 1;
        //_gameScreen.gameObject.SetActive(true);
    }

    private void OnSettingsButtonClick()
    {
        Time.timeScale = 0;
        _settingsScreen.gameObject.SetActive(true);
        //this.gameObject.SetActive(false);
        //_settingsScreen.gameObject.SetActive(true);
        ////Time.timeScale = 0;
    }

    private void OnMenuButtonClick()
    {
        this.gameObject.SetActive(false);
        _menuScreen.gameObject.SetActive(true);
        //Time.timeScale = 0;
    }
}