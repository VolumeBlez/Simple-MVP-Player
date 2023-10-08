public abstract class BasePlayerService
{
    protected readonly IPlayerModel Model;

    protected BasePlayerService(IPlayerModel model)
    {
        Model = model;
    }
}
