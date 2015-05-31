using UnityEngine;
using System.Collections;

public class AvatarController : MonoBehaviour {

	#region controllers
	private AnimationController anim;
	private LifeController life;
	private Transform target;
	private Camera myCamera;
	#endregion

	#region basicGameplay
	public string myLayer;
	#endregion

	#region fireball
	public float fireballBaseCooldown;
	private float fireballCooldown = 0F;
	public GameObject fireball;
	public Transform fireballLaunch;
	#endregion

	#region lightning
	public float lightningBaseCooldown;
	private float lightningCooldown = 0F;
	public GameObject lightning;
	public Transform lightningLaunch;
	#endregion

	#region meteor
	public float meteorBaseCooldown;
	private float meteorCooldown = 0F;
	public GameObject meteor;
	public Transform meteorLaunch;
	#endregion

	#region stomp
	public float stompBaseCooldown;
	private float stompCooldown = 0F;
	public GameObject stomp;
	public Transform stompLaunch;
	#endregion

	// Use this for initialization
	void Start () {
		anim = GetComponent<AnimationController> ();
		life = GetComponent<LifeController> ();
		target = GetComponent<PathFindingAStar> ().target;
		myCamera = GetComponent<PathFindingAStar> ().myCamera;
	}
	
	// Update is called once per frame
	void Update () {
		SkillSmartCast();
		SkillControl ();
	}

	public void TakeDamage(int damage){
		life.TakeDamage (damage, true);
	}

	public void Die(){
		Debug.Log("Morto");
		Application.LoadLevel (0);
	}

	private void SkillSmartCast(){
		LayerMask layerMask = ~(1 << LayerMask.NameToLayer (myLayer) | 1 << LayerMask.NameToLayer ("Floor"));
		Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		Vector3 eulerAngles = new Vector3 (0,0,0);

		if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask)) {
			Vector3 mousePoint = hit.point;

			fireballLaunch.LookAt(mousePoint);
			eulerAngles = fireballLaunch.transform.rotation.eulerAngles;
			eulerAngles = new Vector3(0, eulerAngles.y, 0);
			fireballLaunch.transform.rotation = Quaternion. Euler(eulerAngles);

			lightningLaunch.LookAt(mousePoint);
			eulerAngles = lightningLaunch.transform.rotation.eulerAngles;
			eulerAngles = new Vector3(0, eulerAngles.y, 0);
			lightningLaunch.transform.rotation = Quaternion. Euler(eulerAngles);

			meteorLaunch.transform.position = new Vector3(mousePoint.x, meteorLaunch.transform.position.y, mousePoint.z);
		}
	}

	private void SkillControl(){
		#region fireball
		if( fireballCooldown <= 0F ){
			if( Input.GetKeyUp(KeyCode.Q) ){ //FireBall
				fireballCooldown = fireballBaseCooldown;
				anim.Fireball();
			}
		}else{
			fireballCooldown -= Time.deltaTime;
		}
		#endregion

		#region lightning
		if( lightningCooldown <= 0F ){
			if( Input.GetKeyUp(KeyCode.W) ){ //lightning
				lightningCooldown = lightningBaseCooldown;
				anim.Lightning();
			}
		}else{
			lightningCooldown -= Time.deltaTime;
		}
		#endregion

		#region meteor
		if( meteorCooldown <= 0F ){
			if( Input.GetKeyUp(KeyCode.E) ){ //meteor
				meteorCooldown = meteorBaseCooldown;
				anim.Meteor();
			}
		}else{
			meteorCooldown -= Time.deltaTime;
		}
		#endregion

		#region stomp
		if( stompCooldown <= 0F ){
			if( Input.GetKeyUp(KeyCode.R) ){ //stomp
				stompCooldown = stompBaseCooldown;
				anim.Stomp();
			}
		}else{
			stompCooldown -= Time.deltaTime;
		}
		#endregion
	}

	public void LaunchFireball(){
		GameObject f = Instantiate( fireball, fireballLaunch.position, fireballLaunch.rotation ) as GameObject;
		f.layer = LayerMask.NameToLayer (myLayer);
	}

	public void LaunchLightning(){
		GameObject f = Instantiate( lightning, lightningLaunch.position, lightningLaunch.rotation ) as GameObject;
		f.layer = LayerMask.NameToLayer (myLayer);
	}

	public void LaunchMeteor(){
		GameObject f = Instantiate( meteor, meteorLaunch.position, meteorLaunch.rotation ) as GameObject;
		f.layer = LayerMask.NameToLayer (myLayer);
	}

	public void LaunchStomp(){
		GameObject s = Instantiate( stomp, stompLaunch.position, stompLaunch.rotation ) as GameObject;
		s.layer = LayerMask.NameToLayer (myLayer);
	}
}
