using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{
    public enum Difficulty { Easy, Medium, Hard };
    public Difficulty difficultyLevel;
    public GameObject targetFlag;
    public float moveSpeed = 3f;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        switch (difficultyLevel)
        {
            case Difficulty.Easy:
                // Easy difficulty behavior
                RandomMove();
                break;
            case Difficulty.Medium:
                // Medium difficulty behavior
                MoveTowardsFlag();
                break;
            case Difficulty.Hard:
                // Hard difficulty behavior
                MoveAndIntercept();
                break;
        }
    }

    void RandomMove()
    {
        // Implement random movement behavior
        transform.Translate(Random.insideUnitCircle * moveSpeed * Time.deltaTime);
    }

    void MoveTowardsFlag()
    {
        // Implement behavior to move towards the player's flag
        transform.position = Vector3.MoveTowards(transform.position, targetFlag.transform.position, moveSpeed * Time.deltaTime);
    }

    void MoveAndIntercept()
    {
        {
            // Set destination to player's flag position
            agent.SetDestination(targetFlag.transform.position);
        }

        // Implement other methods (RandomMove, MoveTowardsFlag) as before
    }
}

