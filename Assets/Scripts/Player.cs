using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public GameObject flag; // Reference to the flag object

    private bool hasFlag = false;

    void Update()
    {
        // Player movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);

        // Player interaction
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (hasFlag)
            {
                // Drop the flag
                flag.transform.parent = null;
                hasFlag = false;
            }
            else
            {
                // Check if the player is near the flag
                float distance = Vector3.Distance(transform.position, flag.transform.position);
                if (distance < 2.0f)
                {
                    // Pick up the flag
                    flag.transform.parent = transform;
                    flag.transform.localPosition = new Vector3(0, 2, 0); // Adjust the flag position
                    hasFlag = true;
                }
            }
        }
    }
}
