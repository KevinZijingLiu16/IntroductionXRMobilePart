using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] private InputActionReference moveAction;
    private float moveSpeed = 5f;

    private void Update()
    {
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
        Vector2 moveDirection = moveAction.action.ReadValue<Vector2>();

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        //transform.Translate(Vector3) is used to move the object in the direction and the magnitude of the vector.
    }
}

