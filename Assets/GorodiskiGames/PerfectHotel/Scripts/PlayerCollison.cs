using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerCollison : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navMeshAgent;

    void Start()
    {
        
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("HERE IS THE NAME OF OBJECT : " + other.gameObject.name);
    //    navMeshAgent.enabled = false;
    //}

    //private void OnTriggerStay(Collider other)
    //{
    //    navMeshAgent.enabled = false;
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    navMeshAgent.enabled = true;
    //    Debug.Log("HERE IS THE NAME OF OBJECT : exits");
    //}
}
