using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {

    Animator animator;

    float vertical;
    float horizontal;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space)){
            animator.SetTrigger("jump");
        }
        if (vertical == 0){
            animator.SetBool("run", false);
        }
        if (vertical >= 0.1f){
            animator.SetBool("run", true);
        }
	}
}
