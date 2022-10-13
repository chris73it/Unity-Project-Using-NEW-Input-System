using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float moveSpeed;
    Vector3 velocity;

    public void OnMovementAction(Vector2 movement)
    {
        velocity.x = movement.x; // D (movement[0] is 1) or A (movement[0] is -1) were pressed
        velocity.y = movement.y; // W (movement[1] is 1) or S (movement[1] is -1) were pressed
    }

    private void Update()
    {
        transform.position += velocity * moveSpeed * Time.deltaTime;
    }
}
