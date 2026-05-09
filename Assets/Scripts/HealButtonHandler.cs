public class HealButtonHandler : BaseButtonHandler
{
    public override void ButtonClick()
    {
        _health.ChangeHealth(_healthDelta);
    }
}
