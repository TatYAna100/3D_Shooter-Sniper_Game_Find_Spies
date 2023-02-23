using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScreen : MonoBehaviour
{
    [SerializeField] private Button _playButtom;
    [SerializeField] private Button _levelsButtom;
    [SerializeField] private Button _settingsButtom;
    [SerializeField] private Button _exitButtom;

    //[SerializeField] private GameScreen _gameScreen;
    [SerializeField] private LevelsScreen _levelsScreen;
    [SerializeField] private SettingsScreen _settingsScreen;
    //[SerializeField] private ExerciseScreen _exerciseScreen;

    private void OnEnable()
    {
        _playButtom.onClick.AddListener(OnPlayButtonClick);
        _levelsButtom.onClick.AddListener(OnLevelsButtonClick);
        _settingsButtom.onClick.AddListener(OnSettingsButtonClick);
        _exitButtom.onClick.AddListener(OnExitButtonClick);
    }

    private void OnDisable()
    {
        _playButtom.onClick.RemoveListener(OnPlayButtonClick);
        _levelsButtom.onClick.RemoveListener(OnLevelsButtonClick);
        _settingsButtom.onClick.RemoveListener(OnSettingsButtonClick);
        _exitButtom.onClick.AddListener(OnExitButtonClick);
    }

    //private void Start()
    //{
    //    //_levelsScreen.gameObject.SetActive(false);
    //    //_settingsScreen.gameObject.SetActive(false);
    //    //this.gameObject.SetActive(true);
    //    //Time.timeScale = 1;
    //}

    //public void PlayScreenActive(bool flag)
    public void OnPlayButtonClick()
    {
        //this.gameObject.SetActive(false);
        _levelsScreen.gameObject.SetActive(true);
        //this.gameObject.SetActive(false);
        //_gameScreen.gameObject.SetActive(true);////////////////////////////////////
        //_levelsScreen.gameObject.SetActive(true);
        //this.gameObject.SetActive(false);
        //_gameScreen.gameObject.SetActive(true);
        //this.gameObject.SetActive(false);
        ////Time.timeScale = 1;
    }

    public void OnLevelsButtonClick()
    {
        //this.gameObject.SetActive(false);
        _levelsScreen.gameObject.SetActive(true);
        //Time.timeScale = 0;
    }

    public void OnSettingsButtonClick()
    {
        //this.gameObject.SetActive(false);
        _settingsScreen.gameObject.SetActive(true);
        ////Time.timeScale = 0;        
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
    }
}