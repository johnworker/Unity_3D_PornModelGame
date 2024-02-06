using UnityEngine;

public class FlagController : MonoBehaviour
{
    private bool isPickedUp = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isPickedUp)
        {
            // Player picks up the flag
            transform.parent = other.transform;
            transform.localPosition = new Vector3(0, 1, 0); // Adjust flag position
            isPickedUp = true;
        }
    }

    public void DropFlag()
    {
        // Called when player drops the flag
        transform.parent = null;
        isPickedUp = false;
    }
}
