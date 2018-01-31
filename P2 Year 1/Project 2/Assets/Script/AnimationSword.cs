using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSword : MonoBehaviour {
    private Animator animator;

	
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            animator.Play("Sword Slash");
        }
	}
}
