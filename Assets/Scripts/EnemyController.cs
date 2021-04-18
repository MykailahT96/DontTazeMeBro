using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
public class EnemyController : MonoBehaviour
{
    
    public NavMeshAgent enemyAgent;

    public ThirdPersonCharacter enemyCharacter;

    void Start()
    {
        agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
