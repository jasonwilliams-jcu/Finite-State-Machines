using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unityEngine.AI;

public class AI : MonoBehaviour
{

    NavMeshAgent agent;
    Animator anim;
    public Transform plaer;
    State currentState;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        anim = this.GetComponent<NavMeshAgent>();
        currentState = new Idle(this.gameobject, agent, anim, player);
    }

    // Update is called once per frame
    void Update()
    {
        currentState = currentState.Process();
    }
}
