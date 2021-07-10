using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    private EnemiesCountHandler _enemiesCountHandler;

    private void OnDisable()
    {
        _enemiesCountHandler.OnDestroyedEnemy(this);
    }

    public void SetEnemiesHandler(EnemiesCountHandler enemiesCountHandler)
    {
        _enemiesCountHandler = enemiesCountHandler;
        _enemiesCountHandler.OnSpawnedEnemy(this);
    }
        
}
