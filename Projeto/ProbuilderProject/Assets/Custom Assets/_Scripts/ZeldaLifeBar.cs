using UnityEngine;
using UnityEngine.UI;

public class ZeldaLifeBar : MonoBehaviour {
	public  Image[] hearts;
	public int numberOfHearts;

	public void Start() {
		numberOfHearts = hearts.Length - 1;
	}

	public void OnCollisionEnter(Collision hit) {
		if (hit.gameObject.tag == "lava") {
			if (numberOfHearts >= 0) {
				hearts[numberOfHearts].enabled = false;
				numberOfHearts--;
			}
		}
	}
}
