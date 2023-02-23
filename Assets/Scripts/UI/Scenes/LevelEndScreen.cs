using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelEndScreen : MonoBehaviour
{
    [SerializeField] private Button _continueButton;
    [SerializeField] private Button _menuButton;
    [SerializeField] private LevelsScreen _levelsScreen;
    //[SerializeField] private MenuScreen _menuScreen;
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _starDone;


    private int _menuScreen = 0;
    //private const string _starDone_1 = "StarDone";

    private void OnEnable()
    {
        _player.LevelEnd += OnLevelEnd;
        _continueButton.onClick.AddListener(OnContinueButtonClick);
        _menuButton.onClick.AddListener(OnMenuButtonClick);
    }

    private void OnDisable()
    {
        _player.LevelEnd -= OnLevelEnd;
        _continueButton.onClick.RemoveListener(OnContinueButtonClick);
        _menuButton.onClick.RemoveListener(OnMenuButtonClick);
    }

    private void OnLevelEnd()
    {
        Debug.Log("123");
        //_aimingScope.OnReturnButtonClick();
        
        //Time.timeScale = 0;
        
        //switch()
        //{
        //    case 1:
        //        _star.SetActiv(true);
        //        break;
        //}
    }

    private void OnContinueButtonClick()
    {
        SceneManager.LoadScene(_menuScreen);
        //_levelsScreen.gameObject.SetActive(true);
    }

    private void OnMenuButtonClick()
    {
        SceneManager.LoadScene(_menuScreen);
        //this.gameObject.SetActive(false);
        //_menuScreen.gameObject.SetActive(true);
        //Menu.Load();
    }
}
