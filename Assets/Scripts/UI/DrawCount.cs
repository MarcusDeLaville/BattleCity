using UnityEngine;
using UnityEngine.UI;

public class DrawCount : MonoBehaviour
{
    [SerializeField] protected Text TargetText;

    protected void Draw(int count)
    {
        TargetText.text = count.ToString();
    }
}
