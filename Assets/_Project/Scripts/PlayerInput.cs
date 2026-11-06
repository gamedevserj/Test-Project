using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerController controller;

    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        controller.Move(new Vector2(horizontalInput, verticalInput));

    }
}
