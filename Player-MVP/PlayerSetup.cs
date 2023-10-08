using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    [Header("Player Components")]
    [SerializeField] private PlayerData _data;
    [SerializeField] private CharacterController _controller;
    [SerializeField] private Transform _rotateObject;
    [SerializeField] private Camera _camera;

    [Header("Player Views")]
    [SerializeField] private BasePlayerView[] _views;

    void Start() // or init in Bootstrap
    {
        IPlayerModel model = new PlayerModel(_data, _controller, _rotateObject, _camera);

        PlayerMoveService moveService = new(model);
        PlayerRotateService rotateService = new(model);

        IPlayerPresenter presenter = new PlayerPresenter(moveService, rotateService);

        foreach (BasePlayerView view in _views)
        {
            view.InitView(presenter);
        }
    }
}
