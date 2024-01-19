using UnityEngine;

public class ClimbingGame : MonoBehaviour
{
    public GameObject player;
    public GameObject climbingWall;
    public float climbingSpeed = 5f;
    public float climbingTimeLimit = 60f;

    private float climbingTimer;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // Climb up
            if (climbingTimer < climbingTimeLimit)
            {
                player.transform.Translate(Vector3.up * climbingSpeed * Time.deltaTime);
                climbingTimer += Time.deltaTime;
            }
        }
    }
}
