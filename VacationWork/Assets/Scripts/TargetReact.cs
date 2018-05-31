using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetReact : MonoBehaviour
{
    

	// Use this for initialization
	void Start () {

	}

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Bullet")
       {
            Destroy(other.gameObject);
            transform.rotation = Quaternion.Euler(50, 0, 0);
         


           Debug.Log("타겟 다운");
           



        }


    }

    // Update is called once per frame
    void Update () {

        
		
	}
}
