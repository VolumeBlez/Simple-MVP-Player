using UnityEngine;

public class PlayerData : ScriptableObject
{
    [SerializeField] private float _mouseSens;
    [SerializeField] private float _moveSpeed;

    public float MouseSens => _mouseSens;
    public float MoveSpeed => _moveSpeed;
}
