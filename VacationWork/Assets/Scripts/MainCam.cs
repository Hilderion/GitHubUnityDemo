using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCam : MonoBehaviour {

    public Transform Target;
    public float dist = 10f;
    public float height = 3f;
    public float dampTrace = 20f;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,
            Target.position - (Target.forward * dist) + (Vector3.up * height),
            Time.deltaTime * dampTrace);
        transform.LookAt(Target.position);
    }


    #region
    //public GameObject Player;

    //public float offsetX = 0f;
    //public float offsetY = 10f;
    //public float offsetZ = -35f;

    //Vector3 cameraPosition;

    //private void LateUpdate()
    //{
    //    cameraPosition.x = Player.transform.position.x + offsetX;
    //    cameraPosition.y = Player.transform.position.y + offsetY;
    //    cameraPosition.z = Player.transform.position.z + offsetZ;

    //    transform.position = cameraPosition;


    //}
    #endregion

}
