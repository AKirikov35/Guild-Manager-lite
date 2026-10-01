using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private Vector2 _moveInput;

    private void FixedUpdate()
    {
        Vector2 move = new(_moveInput.x, _moveInput.y);
        transform.Translate(move);
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector2>();
    }
}