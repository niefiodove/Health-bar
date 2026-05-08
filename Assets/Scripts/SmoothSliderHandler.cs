using UnityEngine;
using UnityEngine.UI;

public class SmoothSliderHandler : MonoBehaviour
{
    [SerializeField] private float _smoothSpeed = 5f;

    private Slider _slider;
    private float _maximumHealth;
    private float _targetValue;
    private bool _hasTarget = false;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _targetValue = _slider.value;
    }

    private void OnEnable()
    {
        HealthBar.HealthIndicatorChanged += OnHealthChanged;
        HealthBar.HealthIndicatorCreated += InitializeMaximumHealth;
    }

    private void OnDisable()
    {
        HealthBar.HealthIndicatorChanged -= OnHealthChanged;
        HealthBar.HealthIndicatorCreated -= InitializeMaximumHealth;
    }

    private void Update()
    {
        if (_hasTarget)
        {
            _slider.value = Mathf.Lerp(_slider.value, _targetValue, _smoothSpeed * Time.deltaTime);
        }
    }

    private void OnHealthChanged(float health)
    {
        _targetValue = health / _maximumHealth;
        _hasTarget = true;
    }

    private void InitializeMaximumHealth(float health)
    {
        _maximumHealth = health;
        _targetValue = _slider.value;
        _hasTarget = true;
    }
}