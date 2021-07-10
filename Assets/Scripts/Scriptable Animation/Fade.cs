using UnityEngine;
using  DG.Tweening;
using UnityEngine.UI;

public enum AnimationTarget
{
    Image,
    SpriteRenderer
}

public class Fade : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private SpriteRenderer _sprite;
    
    [SerializeField] private float _duration = 0.7f;
    [SerializeField] private float _fadeEnd = 0.8f;
    [SerializeField] private int _loopCount = -1;
    [SerializeField] private LoopType _loopType = LoopType.Yoyo;

    [SerializeField] private AnimationTarget _animationTarget;
    
    private void Start()
    {
        PlayAnimation();
    }

    private void PlayAnimation()
    {
        if (_animationTarget == AnimationTarget.Image)
        {
            _image.DOFade(_fadeEnd, _duration).SetLoops(_loopCount, _loopType);
        }
        else
        {
            _sprite.DOFade(_fadeEnd, _duration).SetLoops(_loopCount, _loopType);
        }
    }
}
