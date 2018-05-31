using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyChase : MonoBehaviour {

    public GameObject target;
    NavMeshAgent agent;
   


	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
     
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        { Destroy(gameObject); }

    }


    // Update is called once per frame
    void Update () {

        agent.destination = target.transform.position;

	}
}
