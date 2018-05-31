using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 5f;
    public float rotationSpeed = 360f;
   

    CharacterController characterController;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Coin")
        {
            moveSpeed = moveSpeed * 2;
            Destroy(other.gameObject);
        }


        if (other.tag == "Enemy")
        {
            Application.LoadLevel(Application.loadedLevel);
            Debug.Log("죽었다... -다음장-");
        }

    }


    // Use this for initialization
    void Start () {

        characterController = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {

        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if(direction.sqrMagnitude>0.01f)
        {
            Vector3 forward = Vector3.Slerp(
                transform.forward, direction,
                rotationSpeed * Time.deltaTime / Vector3.Angle(transform.forward, direction));
            transform.LookAt(transform.position + forward);
        }
        
        characterController.Move(direction * moveSpeed * Time.deltaTime);

        
        

    }

    


}
