using UnityEngine;

public class WASD : MonoBehaviour
{
    public float moveSpeed;
    public float rotSpeed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.up, rotSpeed * Time.deltaTime);
        }
    }
}
