using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _health = 10f;
    private float _maximumHealth;
    private float _minimumHealth = 0f;

    public event Action<float> HealthIndicatorChanged;
    public event Action<float> HealthIndicatorCreated;

    private void Awake()
    {
        _maximumHealth = _health;
    }

    private void Start()
    {
        HealthIndicatorCreated?.Invoke(_health);
    }

    public void ChangeHealth(float delta)
    {
        _health += delta;
        BoundaryChecking();
        HealthIndicatorChanged?.Invoke(_health);
    }

    private void BoundaryChecking()
    {
        if (_health > _maximumHealth)
            _health = _maximumHealth;

        if (_health < _minimumHealth)
            _health = _minimumHealth;
    }
}