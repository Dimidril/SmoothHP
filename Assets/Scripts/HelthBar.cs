using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Slider))]
public class HelthBar : MonoBehaviour
{
    [SerializeField] private Hero _livingBeing;
    [SerializeField] private float _smoothTime = 2f;

    private Slider _bar;

    private void Awake()
    {
        _bar = GetComponent<Slider>();
        _livingBeing.HPChanged += SetBarValue;
    }

    public void SetBarValue(float value)
    {
        _bar.DOValue(value, _smoothTime).SetEase(Ease.Linear);
    }
}
