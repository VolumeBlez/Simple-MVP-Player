public interface IPlayerPresenter
{
    PlayerRotateService RotateService { get; }
    PlayerMoveService MoveService { get; }
    PlayerInteractService InteractService { get; }
}
