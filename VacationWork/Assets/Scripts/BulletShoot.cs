using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour {

    //public void Shoot(Vector3 dir)
    //{
    //    GetComponent<Rigidbody>().AddForce(dir);
    //}


    public int bulletCount = 0;
    public float speed = 2500f;

    // Use this for initialization
    void Start () {

        

        GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        bulletCount++;
        //Shoot(new Vector3(0, 200, 2000));
        if (bulletCount == 10)
        {
            //TODO : 총탄 숫자가 10개일때 총탄 오브젝트 전부 파괴}
        }

    }

   

    // Update is called once per frame
    void Update () {
		
	}
}
