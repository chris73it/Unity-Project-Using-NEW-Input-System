using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotSpeed;

    void Update()
    {
        transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
    }
}
