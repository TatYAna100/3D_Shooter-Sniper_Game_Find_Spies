using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberBullets : MonoBehaviour
{
    [SerializeField] private TMP_Text _bullet;
    [SerializeField] private Weapon _weapon;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        //_player.ScoreChanged += OnBulletChanged;
        //_weapon.BulletChanged += OnBulletChanged;
    }

    private void OnDisable()
    {
        //_player.ScoreChanged -= OnBulletChanged;
        ////_weapon.BulletChanged -= OnBulletChanged;
    }

    private void OnBulletChanged(int score)
    {
        _bullet.text = score.ToString();
        //_player.AddScore();
    }
}