using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class AIChase : MonoBehaviour
{
    
    public enum AIState
    {
        Patrol,
        Chase,
        Attack
    }
    
    private NavMeshAgent _agent;
    private Transform _player;
    [SerializeField]
    private GameObject[] _waypoints;
    [SerializeField]
    private int _currentWaypoint = 0;
    [SerializeField]
    private AIState _currentState;
    private AIState CurrentState
    {
        get => _currentState;
        set
        {
            // Set new state
            _currentState = value;
        
            // Stop all coroutines
            StopAllCoroutines();
            
            // Start new coroutine based on state
            switch (_currentState)
            {
                case AIState.Patrol:
                    StartCoroutine(Patrol());
                    break;
                case AIState.Chase:
                    StartCoroutine(Chase());
                    break;
                case AIState.Attack:
                    StartCoroutine(Attack());
                    break;
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        // get all waypoints
        _waypoints = GameObject.FindGameObjectsWithTag("Waypoints");
        // set agent to this gameobject
        _agent = GetComponent<NavMeshAgent>();
        // set player to the player gameobject
        _player = GameObject.FindWithTag("Player").transform;
        // set current state to patrol
        CurrentState = AIState.Patrol;
    }

    public IEnumerator Chase()
    {
        // while current state is chase
        // set destination to player
        while (CurrentState == AIState.Chase)
        {
            // set destination to player
            _agent.SetDestination(_player.position);
            
            // if distance to player is less than 2
            // set current state to attack
            if (Vector3.Distance(transform.position, _player.position) < 2f)
            {
                CurrentState = AIState.Attack;
            }
            // wait for next frame
            yield return null;
        }
    }
    
    public IEnumerator Attack()
    {
        while (CurrentState == AIState.Attack)
        {
            print("Attack!");
            
            // set destination to player
            _agent.SetDestination(_player.position);
            
            // if distance to player is greater than 2
            // set current state to chase
            if (Vector3.Distance(transform.position, _player.position) > 2f)
            {
                CurrentState = AIState.Chase;
            }
            
            // wait for next frame
            yield return null;
        }
    }
    
    public IEnumerator Patrol()
    {
        // set current waypoint to 0
        _currentWaypoint = 0;
        // set min distance to 2
        float minDistance = 2f;
        
        // while current state is patrol
        // set destination to waypoint
        while (CurrentState == AIState.Patrol)
        {
            // get distance to waypoint
            float distanceToWaypoint = Vector3.Distance(transform.position, _waypoints[_currentWaypoint].transform.position);
            
            // if distance to waypoint is less than min distance
            if (distanceToWaypoint < minDistance)
            {
                // wait 1 second 
                yield return new WaitForSeconds(1f);
                
                // Get random waypoint
                _currentWaypoint = Random.Range(0, _waypoints.Length);
            }
            // set destination to waypoint
            _agent.SetDestination(_waypoints[_currentWaypoint].transform.position);
            
            // wait for next frame
            yield return null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CurrentState = AIState.Chase;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CurrentState = AIState.Patrol;
        }
    }
}
