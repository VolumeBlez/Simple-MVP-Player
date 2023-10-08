using UnityEngine;

public interface IPlayerModel
{
    PlayerData Data { get; }
    CharacterController Controller { get; }
    Transform RotateObject { get; }
    Camera Camera { get; }
}
