using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
public class EnemyController : MonoBehaviour
{
    public Transform player;
    
    public NavMeshAgent enemyAgent;

    public ThirdPersonCharacter enemyCharacter;

    void Start()
    {
        enemyAgent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Follow player position
        enemyAgent.SetDestination(player.position);

        if(enemyAgent.remainingDistance > enemyAgent.stoppingDistance)
        {                
            enemyCharacter.Move(enemyAgent.desiredVelocity, false, false);
        }
        else
        {
            enemyCharacter.Move(Vector3.zero, false, false);
        }
    }
}
