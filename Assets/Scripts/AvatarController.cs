using UnityEngine;

public class AvatarController : MonoBehaviour
{
    public float moveSpeed;
    public float velocityY;

    Vector3 velocity;
    bool isJumping;

    public void OnMovementAction(Vector2 movement)
    {
        velocity.x = movement.x; // D (movement[0] is 1) or A (movement[0] is -1) were pressed
        velocity.z = movement.y; // W (movement[1] is 1) or S (movement[1] is -1) were pressed
    }

    public void OnJumpingAction(bool _isJumping)
    {
        // When spacebar is pressed _isJumping is true, otherweise it is false.
        isJumping = _isJumping;
    }

    private void Update()
    {
        transform.position += velocity * moveSpeed * Time.deltaTime;
        if (isJumping)
            transform.position += Vector3.up * velocityY * Time.deltaTime;
    }
}
