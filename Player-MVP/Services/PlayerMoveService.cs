using UnityEngine;

public class PlayerMoveService : BasePlayerService
{
    public PlayerMoveService(IPlayerModel model, IPlayerPresenter presenter) : base(model, presenter)
    {
    }

    public void SetMove(Vector3 moveDirection)
    {
        Model.Controller.Move(moveDirection * Model.Data.MoveSpeed);
    }
}
