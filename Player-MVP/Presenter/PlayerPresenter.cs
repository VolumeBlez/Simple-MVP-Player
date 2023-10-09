public class PlayerPresenter : IPlayerPresenter
{
    public PlayerRotateService RotateService { get; }
    public PlayerMoveService MoveService { get; }
    public PlayerInteractService InteractService { get; }

    public PlayerPresenter(IPlayerModel model)
    {
        RotateService = new(model, this);
        MoveService = new(model, this);
        InteractService = new(model, this);
    }
}
