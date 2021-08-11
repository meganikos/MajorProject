using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/* This component moves our player.
		- If we have a focus move towards that.
		- If we don't move to the desired point.
*/

[RequireComponent(typeof(NavMeshAgent))]
//[RequireComponent(typeof(PlayerController))]
public class PlayerMotor : MonoBehaviour {

	Transform target;
	NavMeshAgent agent;     // Reference to our NavMeshAgent
    Animator anime;
    private string currentState;
    //Animation states
    const string PLAYER_IDLE = "Player_idle";
    const string PLAYER_MOVE = "Player_move";
   

    void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
        anime = GetComponent<Animator>();
	}

	public void MoveToPoint (Vector3 point)
	{
        
		agent.SetDestination(point);
        ChangeAnimationState(PLAYER_MOVE);
	}
    


    void ChangeAnimationState(string newState)
    {
        //stop the same animation from interuptig itself
        if(currentState==newState) return;

        anime.Play(newState);
    }
	
		

}
