using UnityEngine;
using UnityEngine.UI;

public class DrawCount : MonoBehaviour
{
    [SerializeField] protected Text _targetText;

    protected void Draw(int count)
    {
        _targetText.text = count.ToString();
    }
}
