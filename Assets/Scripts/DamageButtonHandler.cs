public class DamageButtonHandler : BaseButtonHandler
{
    public override void ButtonClick()
    {
        float damage = _healthDelta * -1;
        _health.ChangeHealth(damage);
    }
}
