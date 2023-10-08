using UnityEngine;

public class PlayerModel : IPlayerModel
{
    public PlayerData Data { get; }
    public CharacterController Controller { get; }
    public Transform RotateObject { get; }
    public Camera Camera { get; }

    public PlayerModel(PlayerData data, CharacterController controller, Transform rotateObject, Camera camera)
    {
        Camera = camera;
        RotateObject = rotateObject;
        Controller = controller;
        Data = data;
    }
}
