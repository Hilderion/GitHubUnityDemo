using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour {

    public GameObject Bullet;
    public Transform firePos;

    public float lifeTime = 2.0f; //life 

    // Use this for initialization
    void Start () {
	    Destroy(GameObject.Find(Bullet.name + "(Clone)"), lifeTime);

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))Fire();
		
	}

    void Fire()
    {
        CreateBullet();
    }

    void CreateBullet()
    {
        Instantiate(Bullet, firePos.position, firePos.rotation);
    

    }

}

