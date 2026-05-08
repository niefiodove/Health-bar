using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private float _healthDelta = 2f;
    [SerializeField] private bool _isDamage;

    public void ButtonClick()
    {
        _healthBar.ChangeHealth(_healthDelta, _isDamage);
    }
}
