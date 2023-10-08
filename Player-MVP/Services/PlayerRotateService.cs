using UnityEngine;

public class PlayerRotateService : BasePlayerService
{
    public PlayerRotateService(IPlayerModel model) : base(model)
    {
    }

    public void SetRotation(Vector2 rotation, ref float xRotation)
    {
        rotation = rotation * Model.Data.MouseSens * Time.deltaTime;

        xRotation -= rotation.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        Model.Camera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Model.RotateObject.Rotate(Vector3.up * rotation.x);
    }
}
