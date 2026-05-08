using UnityEngine;
using UnityEngine.UI;

public class SliderHandler : MonoBehaviour
{
    private Slider _slider;
    private float _maximumHelth;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void OnEnable()
    {
        HealthBar.HealthIndicatorChanged += ChangeSlider;
        HealthBar.HealthIndicatorCreated += InitializeMaximumHelth;
    }

    private void OnDisable()
    {
        HealthBar.HealthIndicatorChanged -= ChangeSlider;
        HealthBar.HealthIndicatorCreated -= InitializeMaximumHelth;
    }

    private void ChangeSlider(float health)
    {
        _slider.value = health / _maximumHelth; 
    }
    private void InitializeMaximumHelth(float health)
    {
        _maximumHelth = health;
    }
}
