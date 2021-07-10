using UnityEngine;
using  DG.Tweening;
using UnityEngine.UI;

public class SizeFade : MonoBehaviour
{
    [SerializeField] private Transform _transform;

    [SerializeField] private float _duration = 0.7f;
    [SerializeField] private float _sizeEnd = 0.8f;
    
    private void Start()
    {
        _transform.DOScale(Vector3.one * _sizeEnd, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}