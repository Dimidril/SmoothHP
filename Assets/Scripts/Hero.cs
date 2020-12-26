using UnityEngine;
using UnityEngine.Events;

public class Hero : MonoBehaviour
{
    [SerializeField] private float _maxHelthPoints = 100f;
    [SerializeField] private float _helthPoints = 50f;

    public delegate void ChangeHP(float ratioOfRemainderToTheMaximumHP);
    public event ChangeHP HPChanged;

    private void Start()
    {
        HPChanged?.Invoke(_helthPoints / _maxHelthPoints);
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
        HPChanged?.Invoke(_helthPoints / _maxHelthPoints);
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
