using UnityEngine;
using System.Collections;

public class MeteorExplosion : MonoBehaviour {

	public float pushForce;
	private float counter;
	
	// Use this for initialization
	void Start () {
		GameObject.Destroy (gameObject,4F);
		counter = 2F;
	}

	void Update(){
		if (counter == 0F) {
			Destroy(gameObject.GetComponent<SphereCollider>());
		} else {
			counter -= Time.deltaTime;
		}
	}
	
	void OnTriggerEnter(Collider other) {
		if( other.tag == "Player" || other.tag == "Capsule" ){
			Vector3 dir = other.transform.position - transform.position;			
			other.gameObject.GetComponent<Rigidbody>().AddForce(dir * pushForce, ForceMode.Force);
		}
	}
}
