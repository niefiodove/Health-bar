using UnityEngine;

public abstract class BaseButtonHandler : MonoBehaviour
{
    [SerializeField] protected Health _health;
    [SerializeField] protected float _healthDelta;

    public abstract void ButtonClick();
}
