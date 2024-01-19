using UnityEngine;

public class VolleyballGame : MonoBehaviour
{
    public GameObject ball;
    public Transform net;
    public float bumpForce = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Bump the ball
            Rigidbody ballRb = ball.GetComponent<Rigidbody>();
            Vector3 direction = net.position - ball.transform.position;
            ballRb.AddForce(direction.normalized * bumpForce, ForceMode.Impulse);
        }
    }
}
