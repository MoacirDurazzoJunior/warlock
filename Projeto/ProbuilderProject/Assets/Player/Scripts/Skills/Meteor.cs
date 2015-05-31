using UnityEngine;
using System.Collections;

public class Meteor : MonoBehaviour {

	public int damage;
	public GameObject explosion;
	
	void OnCollisionEnter(Collision col){
		if( col.gameObject.tag == "Player" ){
			col.gameObject.GetComponent<AvatarController>().TakeDamage(damage);
		}
		if( col.gameObject.tag == "Capsule" ){
			col.gameObject.GetComponent<LifeController>().TakeDamage(damage, true);
		}
		GameObject f = Instantiate (explosion, transform.position, transform.rotation) as GameObject;
		f.layer = gameObject.layer;
		Destroy (gameObject);
	}
}
