using UnityEngine;
using System.Collections;

public class PathFindingAStar : MonoBehaviour {

	public NavMeshAgent agent;
	public Transform target;
	public Camera myCamera;

	private AnimationController anim;
	private AvatarController player;

	public void Start () {
		anim = GetComponent<AnimationController> ();
		player = GetComponent<AvatarController> ();
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		float dist = agent.remainingDistance;
		//Debug.Log (dist);
		if (dist != Mathf.Infinity && agent.pathStatus == NavMeshPathStatus.PathComplete && dist <= 0.01F){
			anim.Walk(false);
			agent.Stop();
		}

		if (Input.GetMouseButtonDown (1)) {
			LayerMask layerMask = ~(1 << LayerMask.NameToLayer ("Floor"));
			Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask)) {
				target.position = hit.point + new Vector3 (0, 0.5F, 0);
				target.GetComponentInChildren<ParticleSystem>().Play();
			}
			agent.Resume();			
			agent.SetDestination (target.position);
			anim.Walk(true);
		}
	}
}
