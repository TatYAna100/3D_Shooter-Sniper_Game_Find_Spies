using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TimeCount : MonoBehaviour
{
    //[SerializeField] private Player _player;
    [SerializeField] private float _duration;
    //[SerializeField] private GameOverScreen _gameOverScreen;
    //[SerializeField] private AudioSource _audioSource;
    //[SerializeField] private AudioClip _audioClip;
    [SerializeField] private LevelEndScreen _levelEndScreen;

    private float _currentTime;

    public event UnityAction<float> TimerChanged;
    public event UnityAction GameOver;

    private void Start()
    {
        _currentTime = _duration;

        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        //if(_currentTime != 0/* && _levelEndScreen.isActiveAndEnabled == false*/)
        while (_currentTime != 0)
        {
            yield return new WaitForSeconds(1f);
            _currentTime--;            
            TimerChanged?.Invoke(_currentTime);
        }
        //else
        //{
        //    GameOver?.Invoke();
        //    _gameOverScreen.gameObject.SetActive(true);
        //    _audioSource.PlayOneShot(_audioClip);
        //}
        if(_levelEndScreen.isActiveAndEnabled == false)
        {
            GameOver?.Invoke();
        }

        //_gameOverScreen.gameObject.SetActive(true);
        //_audioSource.PlayOneShot(_audioClip);
    }
}