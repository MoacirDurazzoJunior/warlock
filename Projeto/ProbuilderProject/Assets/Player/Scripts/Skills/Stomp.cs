using UnityEngine;
using System.Collections;

public class Stomp : MonoBehaviour {

	public float pushForce;
	public int damage;
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
		if( other.gameObject.tag == "Capsule" ){
			other.gameObject.GetComponent<LifeController>().TakeDamage(damage, true);
			Vector3 dir = other.transform.position - transform.position;			
			other.gameObject.GetComponent<Rigidbody>().AddForce(dir * pushForce, ForceMode.Force);
		}
		if( other.tag == "Player"  ){
			other.gameObject.GetComponent<AvatarController>().TakeDamage(damage);
			Vector3 dir = other.transform.position - transform.position;			
			other.gameObject.GetComponent<Rigidbody>().AddForce(dir * pushForce, ForceMode.Force);
		}
	}
}
