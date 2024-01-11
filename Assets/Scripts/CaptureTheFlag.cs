using UnityEngine;

public class CaptureTheFlag : MonoBehaviour
{
    public GameObject player1Flag;
    public GameObject player2Flag;
    public Transform base1;
    public Transform base2;

    private bool player1HasFlag = false;
    private bool player2HasFlag = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (player1HasFlag)
            {
                // Check if player 1 is in base 2
                float distance = Vector3.Distance(player1Flag.transform.position, base2.position);
                if (distance < 1.0f)
                {
                    // Player 1 scores
                    Debug.Log("Player 1 scores!");
                    ResetFlags();
                }
            }

            if (player2HasFlag)
            {
                // Check if player 2 is in base 1
                float distance = Vector3.Distance(player2Flag.transform.position, base1.position);
                if (distance < 1.0f)
                {
                    // Player 2 scores
                    Debug.Log("Player 2 scores!");
                    ResetFlags();
                }
            }
        }
    }

    void ResetFlags()
    {
        player1HasFlag = false;
        player2HasFlag = false;

        // Reset flag positions
        player1Flag.transform.position = new Vector3(-10, 0, 0);
        player2Flag.transform.position = new Vector3(10, 0, 0);
    }

    // Implement player movement, flag pickup, and drop logic here
}
