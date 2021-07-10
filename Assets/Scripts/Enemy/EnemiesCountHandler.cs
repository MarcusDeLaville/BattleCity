using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesCountHandler : MonoBehaviour
{
    [SerializeField] private List<EnemyHandler> _aliveEnemies;
    public int AliveEnemyCount => _aliveEnemies.Count;
    public event Action<int> EnemyDestroy;
    
    public void OnSpawnedEnemy(EnemyHandler enemyHandler)
    {
        _aliveEnemies.Add(enemyHandler);
    }

    public void OnDestroyedEnemy(EnemyHandler enemyHandler)
    {
        _aliveEnemies.Remove(enemyHandler);
        EnemyDestroy?.Invoke(AliveEnemyCount);
    }
}
