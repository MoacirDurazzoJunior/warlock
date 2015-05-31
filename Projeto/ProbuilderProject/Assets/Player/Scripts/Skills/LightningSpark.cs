using UnityEngine;
using System.Collections;

public class LightningSpark : MonoBehaviour {

	public int damage;
	public float time;
	public GameObject explosion;
	public float speed;
	
	// Use this for initialization
	void Start () {
		Destroy (gameObject, time);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0, 0, speed));
	}
	
	void OnCollisionEnter(Collision col){
		if( col.gameObject.tag == "Player" ){
			col.gameObject.GetComponent<AvatarController>().TakeDamage(damage);
		}
		if( col.gameObject.tag == "Capsule" ){
			col.gameObject.GetComponent<LifeController>().TakeDamage(damage, true);
		}
		GameObject f = Instantiate (explosion, transform.position,  Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
		f.layer = gameObject.layer;
		Destroy (gameObject);
	}
}
