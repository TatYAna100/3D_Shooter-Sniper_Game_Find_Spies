using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScreen : MonoBehaviour
{
    [SerializeField] private Button _pauseButtom;
    [SerializeField] private PauseScreen _pauseScreen;
    //[SerializeField] private ScopeWindow _scopeWindow;

    private void OnEnable()
    {
        //_shotButtom.onClick.AddListener(OnShotButtonClick);
        _pauseButtom.onClick.AddListener(OnPauseButtonClick);
    }

    private void OnDisable()
    {
        //_shotButtom.onClick.RemoveListener(OnShotButtonClick);
        _pauseButtom.onClick.RemoveListener(OnPauseButtonClick);
    }

    //private void OnShotButtonClick()
    //{
    //    if (_lastShootTime <= 0)
    //    {
    //        if (_scopeWindow.isActiveAndEnabled)
    //        {
    //            _player.ApplyShooting();
    //            _lastShootTime = _secondsBetweenShoot;
    //        }
    //    }

    //    _lastShootTime -= Time.deltaTime;
    //}

    private void OnPauseButtonClick()
    {
        Time.timeScale = 0;
        _pauseScreen.gameObject.SetActive(true);
    }
}