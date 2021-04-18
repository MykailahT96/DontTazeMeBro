using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerController : MonoBehaviour
{
    public Camera camel;

    public NavMeshAgent agent;

    public ThirdPersonCharacter character;

    void Start()
    {
        agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray raymond = camel.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(raymond, out hit))
            {
                // MOVE OUR AGENT
                agent.SetDestination(hit.point);
            }
        }

        if(agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }
    }
}
