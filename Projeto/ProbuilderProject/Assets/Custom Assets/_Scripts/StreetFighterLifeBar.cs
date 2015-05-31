using UnityEngine;
using UnityEngine.UI;

public class StreetFighterLifeBar : MonoBehaviour {
	public Image lifeBar;
	public float damage = 10;

	public void OnCollisionEnter(Collision hit) {
		if (hit.gameObject.tag == "lava") {
			if (!lifeBar.sprite) {
				Vector2 size = lifeBar.rectTransform.sizeDelta;
				size.x -= damage;
				if (size.x < 0) {
					size.x = 0;
					// Reload
				}
				lifeBar.rectTransform.sizeDelta = size;
				lifeBar.rectTransform.Translate(-damage * 0.5F, 0, 0);
			} else {
				lifeBar.fillAmount -= 0.05F;
			}
		}
	}

}
