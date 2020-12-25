using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private HelthBar _helthBar;
    [SerializeField] private float _maxHelthPoints = 100f;
    [SerializeField] private float _helthPoints = 50f;

    private void Start()
    {
        _helthBar.SetBarValue(_helthPoints / _maxHelthPoints);
    }

    public void TakeDamage(float damage)
    {
        _helthPoints -= damage;
        if (_helthPoints > _maxHelthPoints)
        {
            _helthPoints = _maxHelthPoints;
        }
        else if(_helthPoints < 0)
        {
            _helthPoints = 0;
            Die();
        }
        _helthBar.SetBarValue(_helthPoints / _maxHelthPoints);
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
