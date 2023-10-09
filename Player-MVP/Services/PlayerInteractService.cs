using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractService : BasePlayerService
{
    public PlayerInteractService(IPlayerModel model, IPlayerPresenter presenter) : base(model, presenter)
    {
    }

    public void PerformRay()
    {
        Ray ray = Model.Camera.ScreenPointToRay(Mouse.current.position.ReadValue());

        if(Physics.Raycast(ray, out RaycastHit hit, 10f))
        {
            //if(hit.transform.TryGetComponent(out IInteractable interactable))
            //    interactable.Interact();
        }
    }
}
