using UnityEngine;

public class Mover : MonoBehaviour
{

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * 0.1f;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * 0.1f;;

        transform.Translate(xValue, yValue, zValue);
    }
}
