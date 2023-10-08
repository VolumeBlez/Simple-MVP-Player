public class PlayerPresenter : IPlayerPresenter
{
    public PlayerRotateService RotateService { get; }
    public PlayerMoveService MoveService { get; }

    public PlayerPresenter(PlayerMoveService moveService, PlayerRotateService rotateService)
    {
        RotateService = rotateService;
        MoveService = moveService;
    }
}
