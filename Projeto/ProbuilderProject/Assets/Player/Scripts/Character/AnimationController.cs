using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	public void Walk(bool walk){
		anim.SetBool ("Walk", walk);
	}

	public void Fireball(){
		anim.SetTrigger ("Attack2");
	}

	public void Lightning(){
		anim.SetTrigger ("Attack1");
	}

	public void Meteor(){
		anim.SetTrigger ("Attack3");
	}

	public void Stomp(){
		anim.SetTrigger ("Attack4");
	}
}
