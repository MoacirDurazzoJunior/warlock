using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LifeController : MonoBehaviour {

	public int life;
	private int currentLife;
	public GameObject shield;
	public Slider healthBarSlider;
	public float shieldBaseCooldown;
	private float shieldCooldown;
	public bool capsule;

	public bool inLava;
	public int lavaDamage;
	private float counter;

	public Camera myCamera;

	private AvatarController avatar;

	void Start(){
		avatar = GetComponent<AvatarController> ();
		healthBarSlider.maxValue = life;
		healthBarSlider.minValue = 0F;
		healthBarSlider.value = life;

		currentLife = life;

		shieldCooldown = 0F;

		if(!capsule) myCamera = GetComponent<PathFindingAStar> ().myCamera;
	}
	
	// Update is called once per frame
	void Update () {
		SetLifebarPosition ();
		UpdateShield ();
		CheckLava ();
	}

	private void CheckLava(){
		if( inLava ){
			if( counter <= 0F ){
				counter = 1F;
				TakeDamage(lavaDamage, false);
			}else{
				counter -= Time.deltaTime;
			}
		}else{
			counter = 1F;
		}
	}

	private void UpdateShield(){
		if(shieldCooldown <= 0F){
			shield.SetActive(false);
		}else{
			shieldCooldown -= Time.deltaTime;
			shield.SetActive(true);
		}
	}

	private void SetLifebarPosition(){
		Vector3 wantedPos = RectTransformUtility.WorldToScreenPoint (myCamera, transform.Find("LifePoint").transform.position);
		healthBarSlider.GetComponent<RectTransform> ().position = wantedPos;
	}

	public void TakeDamage(int damage, bool useShield){
		if(shieldCooldown <= 0F){
			if(useShield) shieldCooldown = shieldBaseCooldown;
			currentLife -= damage;
			healthBarSlider.value -= damage; 
		}

		if (currentLife > life) currentLife = life;
		if (currentLife <= 0 && !capsule) avatar.Die ();
	}

}
