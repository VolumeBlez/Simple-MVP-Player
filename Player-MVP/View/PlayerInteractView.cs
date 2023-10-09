public class PlayerInteractView : BasePlayerView
{
    public void PerformInteract()
    {
        Presenter.InteractService.PerformRay();
    }
}
