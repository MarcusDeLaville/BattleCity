using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DrawFinishWords : MonoBehaviour
{
    [SerializeField] private Text _finishText;
    
    [SerializeField] private string _winText;
    [SerializeField] private string _lossText;

    [SerializeField] private Color _winColor;
    [SerializeField] private Color _lossColor;

    [SerializeField] private FinishGameHandler _finishGameHandler;

    private void OnEnable()
    {
        _finishGameHandler.GameEnded += Draw;
    }

    private void OnDisable()
    {
        _finishGameHandler.GameEnded -= Draw;
    }

    private void Draw(bool isWin)
    {
        string finishText;

        if (isWin == false)
        {
            finishText = _lossText;
            _finishText.color = _lossColor;
        }
        else
        {
            finishText = _winText;
            _finishText.color = _winColor;
        }

        _finishText.DOText(finishText, 1.5f);
    }
}
