using UnityEngine;
using System.Collections;

public class trocaAnimTest : MonoBehaviour {
	Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			anim.SetBool ("Walk", false);
		} 
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			anim.SetBool ("Walk", true);
		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			anim.SetTrigger ("Attack1");
		} 

		if (Input.GetKeyDown (KeyCode.Alpha4)) {
			anim.SetTrigger ("Attack2");
		} 
		if (Input.GetKeyDown (KeyCode.Alpha5)) {
			anim.SetTrigger ("Attack3");
		} 

		if (Input.GetKeyDown (KeyCode.Alpha6)) {
			anim.SetTrigger ("Attack4");
		} 



	}
}
