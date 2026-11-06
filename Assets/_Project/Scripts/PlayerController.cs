using UnityEngine;

public partial class PlayerController : MonoBehaviour
{
    private Transform tr;
    private Direction direction;
    private enum EnemyState { Idle, Patrol, Attack }
    private enum MenuType { MainMenu, Options}
    [SerializeField] private MenuType _menuType;

    private void Awake()
    {
        tr = GetComponent<Transform>();
    }

    public void Move(Vector2 movement)
    {
        tr.Translate(movement * Time.deltaTime, Space.World);
        if ((int)direction == 1)
        {

        }

        switch (direction)
        {
            case Direction.Left: // 
                break;
            case Direction.Right: 
                break;
            case Direction.Up:
                break;
            case Direction.Down:
                break;
            default:
                break;
        }
    }
}
