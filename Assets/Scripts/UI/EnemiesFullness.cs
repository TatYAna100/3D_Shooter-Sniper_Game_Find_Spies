using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemiesFullness : MonoBehaviour
{
    [SerializeField] private TMP_Text _textNumberEnemies;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        //_textNumberEnemies.text = _player.EnemyCount.ToString();
        //_player.EnemyCountChanged += OnEnemyCountChanged;
        //_player.EnemiesKilledChanged += OnEnemiesChanged;
    }

    private void OnDisable()
    {
        //_player.EnemyCountChanged -= OnEnemyCountChanged;        
        //_player.EnemiesKilledChanged -= OnEnemiesChanged;
    }

    private void OnEnemiesChanged(Enemy enemy)
    {
        //_player.ApplyDamage(enemy);
        //_player.AddScore(enemy.Score);
    }

    private void OnEnemyCountChanged(int score)
    {
        //_textNumberEnemies.text = score.ToString();
    }
}