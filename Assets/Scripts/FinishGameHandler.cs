using System;
using UnityEngine;

public class FinishGameHandler : MonoBehaviour
{
    [SerializeField] private int _playerLives;
    [SerializeField] private PlayerSpawner _playerSpawner;
    [SerializeField] private EnemiesCountHandler _enemiesCountHandler;
    [SerializeField] private EnemiesSpawner _enemiesSpawner;
    
    public event Action<bool> GameEnded;
    public event Action<int> PlayerLivesChanged;

    private void Start()
    {
        PlayerLivesChanged?.Invoke(_playerLives);
    }

    private void OnEnable()
    {
        _playerSpawner.PlayerSpawned += OnPlayerSpawned;
        _enemiesCountHandler.EnemyDestroy += OnEnemyDestroyed;
    }

    private void OnDisable()
    {
        _playerSpawner.PlayerSpawned -= OnPlayerSpawned;
    }

    private void OnPlayerSpawned(Endurance endurance)
    {
        endurance.Destroyed += OnPlayerDestroy;
    }

    private void OnPlayerDestroy()
    {
        _playerLives--;

        if (_playerLives > 0)
        {
            _playerSpawner.SpawnPlayer();
        }
        else
        {
            GameEnded?.Invoke(false);
        }
        
        PlayerLivesChanged?.Invoke(_playerLives);
    }

    private void OnEnemyDestroyed(int enemyAlives)
    {
        if (enemyAlives == 0 && _enemiesSpawner.EnemiesLeft == 0)
        {
            GameEnded?.Invoke(true);
        }
    }
}
