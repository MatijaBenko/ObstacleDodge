using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xMoveSpeed = 200f;
    [SerializeField] float yMoveSpeed = 200f;
    [SerializeField] float zMoveSpeed = 200f;

    void Update()
    {
        float xAngle = Time.deltaTime * xMoveSpeed;
        float yAngle = Time.deltaTime * yMoveSpeed;
        float zAngle = Time.deltaTime * zMoveSpeed;
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
