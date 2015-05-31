using UnityEngine;
using System.Collections;

public class LightningStrike : MonoBehaviour {

	public float pushForce;
	
	// Use this for initialization
	void Start () {
		GameObject.Destroy (gameObject,1F);
	}
	
	void OnTriggerEnter(Collider other) {
		if( other.tag == "Player" || other.tag == "Capsule" ){
			Vector3 dir = other.transform.position - transform.position;			
			other.gameObject.GetComponent<Rigidbody>().AddForce(dir * pushForce, ForceMode.Force);
		}
	}

}
