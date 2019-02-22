using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject player;
    public float Offsetx = 0;
    public float Offsetz = -5;
    public float PlayerVelocity = 5;
    private float movementx;
    private float movementz;


    void Update() {
        movementx = (player.transform.position.x + Offsetx - this.transform.position.x);
        movementz = (player.transform.position.z + Offsetz - this.transform.position.z);
        transform.position += new Vector3((movementx * PlayerVelocity * Time.deltaTime), 0, (movementz * PlayerVelocity * Time.deltaTime));
    }
}
