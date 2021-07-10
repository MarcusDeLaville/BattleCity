using System;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private Endurance _playerPrefab;
    [SerializeField] private Transform _spawnPosition;

    public event Action<Endurance> PlayerSpawned;
    
    private void Start()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        Endurance spawnedPlayer = Instantiate(_playerPrefab, _spawnPosition);
        PlayerSpawned?.Invoke(spawnedPlayer);
    }
}
