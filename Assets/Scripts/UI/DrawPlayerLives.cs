using UnityEngine;

public class DrawPlayerLives : DrawCount
{
    [SerializeField] private FinishGameHandler _finishGameHandler;

    private void OnEnable()
    {
        _finishGameHandler.PlayerLivesChanged += Draw;
    }

    private void OnDisable()
    {
        _finishGameHandler.PlayerLivesChanged -= Draw;
    }
}
