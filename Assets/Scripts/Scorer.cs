using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hit = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            hit++;
            Debug.Log("You've bumped into a thing this many times: " + hit);
        }

    }
}
