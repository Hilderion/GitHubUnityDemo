using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonReact : MonoBehaviour
{
    
	// Use this for initialization
	void Start ()
	{
        

	}
	
	// Update is called once per frame
	void Update () {

	    


        //TODO : 캐논 각 조절 구현

        if (Input.GetKeyDown("q"))
        {
	        transform.rotation = Quaternion.Euler(-30,0, 0);
            Debug.Log("포신 위로");
            
	    }

	    if (Input.GetKeyDown("e"))
	    {
	        transform.rotation = Quaternion.Euler(0, 0, 0);
            Debug.Log("포신 정면으로");
	    }


	    if (Input.GetKeyDown("r"))
	    {
	        transform.rotation = Quaternion.Euler(-10, 0, 0);
	        Debug.Log("포신 원래 위치로");
	    }

    }
}
