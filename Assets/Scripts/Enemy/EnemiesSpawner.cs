using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private EnemyHandler _prefab;
    [SerializeField] private Transform[] _spawnPoints;

    [SerializeField] private int _enemiesLeftCount = 20;
    [SerializeField] private int _maximumEnemiesOnMap = 5;
    [SerializeField] private float _spawnDelay = 4f;

    [SerializeField] private EnemiesCountHandler _enemiesCountHandler;

    public event Action<int> EnemySpawned;
    public int EnemiesLeft => _enemiesLeftCount;
    
    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (_enemiesLeftCount > 0)
        {
            if (_enemiesCountHandler.AliveEnemyCount < _maximumEnemiesOnMap)
            {
                 Spawn();
            }
            yield return new WaitForSeconds(_spawnDelay);
        }
    }

    private void Spawn()
    {
        _enemiesLeftCount--;
        EnemyHandler enemy = Instantiate(_prefab, _spawnPoints[Random.Range(0, _spawnPoints.Length)]);
        enemy.SetEnemiesHandler(_enemiesCountHandler);
        EnemySpawned?.Invoke(_enemiesLeftCount);
    }
}
