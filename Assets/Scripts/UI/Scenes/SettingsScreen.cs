using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScreen : MonoBehaviour
{
    [SerializeField] private Button _exitButtom;
    [SerializeField] private Button _soundsOnButton;
    [SerializeField] private Button _soundsOffButton;
    [SerializeField] private MenuScreen _menuScreen;
    [SerializeField] private AudioSource _audioSource;

    private float _minVolume = 0f;
    private float _maxVolume = 0.2f;

    private void OnEnable()
    {
        _soundsOnButton.onClick.AddListener(OnSoundsOnButtonClick);
        _soundsOffButton.onClick.AddListener(OnSoundsOffButtonClick);
        _exitButtom.onClick.AddListener(OnExitButtonClick);
    }

    private void OnDisable()
    {
        _soundsOnButton.onClick.RemoveListener(OnSoundsOnButtonClick);
        _soundsOffButton.onClick.RemoveListener(OnSoundsOffButtonClick);
        _exitButtom.onClick.RemoveListener(OnExitButtonClick);
    }

    private void Start()
    {
        //_audioSource = GetComponent<AudioSource>();
        _soundsOnButton.gameObject.SetActive(true);
        //_audioSource.Play();
        _audioSource.volume = _maxVolume;
    }

    //private void OnSoundsButtonClick()
    //{
    //    if(_audioSource.volume == _maxVolume)
    //    {
    //        _soundsOnButton.gameObject.SetActive(false);
    //        _soundsOffButton.gameObject.SetActive(true);
    //        _audioSource.volume = _minVolume;
    //    }
    //    else if(_audioSource.volume == _minVolume)
    //    {
    //        _soundsOffButton.gameObject.SetActive(false);
    //        _soundsOnButton.gameObject.SetActive(true);
    //        _audioSource.volume = _maxVolume;
    //    }
    //}

    private void OnSoundsOnButtonClick()
    {
        _soundsOnButton.gameObject.SetActive(false);
        _soundsOffButton.gameObject.SetActive(true);
        _audioSource.volume = _minVolume;
    }

    private void OnSoundsOffButtonClick()
    {
        _soundsOffButton.gameObject.SetActive(false);
        _soundsOnButton.gameObject.SetActive(true);
        _audioSource.volume = _maxVolume;
    }

    private void OnExitButtonClick()
    {
        this.gameObject.SetActive(false);

        //_pauseScreen.gameObject.SetActive(true);
        //Time.timeScale = 0;
    }

    //IEnumerator Loop()
    //{
    //    for (var i =_soundsSlider.value; i < 1f; i += Time.time)
    //    {
    //        _soundsSlider.value = i;
    //        yield return null;
    //    }
    //}
}