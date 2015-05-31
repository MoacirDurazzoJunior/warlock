using UnityEngine;
using System.Collections;

public class LavaFloor : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if( other.tag == "Player" || other.tag == "Capsule" ){
			other.gameObject.GetComponent<LifeController>().inLava = false;
		}
	}

	void OnTriggerExit(Collider other) {
		if( other.tag == "Player" || other.tag == "Capsule" ){
			other.gameObject.GetComponent<LifeController>().inLava = true;
		}
	}

}
