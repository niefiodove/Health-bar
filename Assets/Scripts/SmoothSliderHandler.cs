using UnityEngine;

public class SmoothSliderHandler : BaseSliderHandler
{
    [SerializeField] private float _smoothSpeed = 5f;

    private float _targetValue;
    private bool _hasTarget = false;

    protected override void Awake()
    {
        base.Awake();
        _targetValue = _slider.value;
    }

    private void Update()
    {
        if (_hasTarget)
        {
            _slider.value = Mathf.Lerp(_slider.value, _targetValue, _smoothSpeed * Time.deltaTime);
        }
    }

    protected override void OnHealthChanged(float health)
    {
        _targetValue = health / _maximumHealth;
        _hasTarget = true;
    }

    protected override void InitializeMaximumHealth(float health)
    {
        base.InitializeMaximumHealth(health);
        _targetValue = _slider.value;
        _hasTarget = true;
    }
}