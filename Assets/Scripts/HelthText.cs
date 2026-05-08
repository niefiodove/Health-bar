using TMPro;
using UnityEngine;

public class HelthText : MonoBehaviour
{
    private float _maximumHelth;
    private TextMeshProUGUI _myText;

    private void Awake()
    {
        _myText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        _myText.text = $"{_maximumHelth}/{_maximumHelth}";
    }

    private void OnEnable()
    {
        HealthBar.HealthIndicatorChanged += ChangeText;
        HealthBar.HealthIndicatorCreated += InitializeMaximumHelth;
    }

    private void OnDisable()
    {
        HealthBar.HealthIndicatorChanged -= ChangeText;
        HealthBar.HealthIndicatorCreated -= InitializeMaximumHelth;
    }

    private void ChangeText(float health)
    {
        _myText.text = $"{health}/{_maximumHelth}";
    }

    private void InitializeMaximumHelth(float health)
    {
        _maximumHelth = health;
    }
}
