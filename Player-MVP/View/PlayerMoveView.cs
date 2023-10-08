using UnityEngine;

public class PlayerMoveView : BasePlayerView
{
    [SerializeField] private Transform _movabelObject;
    private Vector3 _newDirection;
    private Vector3 _currentMoveDirection;

    private void Update() 
    {
        _currentMoveDirection = _movabelObject.right * _newDirection.x + _movabelObject.forward * _newDirection.y;
        _currentMoveDirection = _currentMoveDirection.normalized * Time.deltaTime;

        if(_currentMoveDirection != _newDirection)
        {
            Presenter.MoveService.SetMove(_currentMoveDirection);
        }
    }

    public void SetDirection(Vector2 direction) => _newDirection = direction;

    public void ResetDirection() => _newDirection = Vector3.zero; 
}
