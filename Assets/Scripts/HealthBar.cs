using System;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _health = 10f;
    private float _maximumHealth;
    private float _minimumHealth = 0f;

    public static event Action<float> HealthIndicatorChanged;
    public static event Action<float> HealthIndicatorCreated;

    private void Awake()
    {
        _maximumHealth = _health;
    }
    private void Start()
    {
        HealthIndicatorCreated.Invoke(_health);
    }

    public void ChangeHealth(float damage, bool isDamage)
    {
        if (isDamage)
            _health -= damage;
        else
            _health += damage;

        BoundaryChecking();

        HealthIndicatorChanged.Invoke(_health);
    }

    private void BoundaryChecking()
    {
        if(_health > _maximumHealth)
            _health = _maximumHealth;

        if(_health < _minimumHealth)
            _health = _minimumHealth;
    }
}
