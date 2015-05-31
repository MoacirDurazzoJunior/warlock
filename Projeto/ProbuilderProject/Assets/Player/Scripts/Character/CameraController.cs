using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float speed;
	public Transform target;
	public Camera camera;

	public float space;
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKey(KeyCode.UpArrow) ) transform.Translate (new Vector3 (0, 0, speed));
		if( Input.GetKey(KeyCode.DownArrow) ) transform.Translate (new Vector3 (0, 0, -speed));
		if( Input.GetKey(KeyCode.RightArrow) ) transform.Translate (new Vector3 (speed, 0, 0));
		if( Input.GetKey(KeyCode.LeftArrow) ) transform.Translate (new Vector3 (-speed, 0, 0));

		if (Input.mousePosition.x > Screen.width - 20) transform.Translate (new Vector3 (speed, 0, 0));
		if (Input.mousePosition.x < 0 + 20) transform.Translate (new Vector3 (-speed, 0, 0));
		if (Input.mousePosition.y > Screen.height - 20) transform.Translate (new Vector3 (0, 0, speed));
		if (Input.mousePosition.y < 0 + 20) transform.Translate (new Vector3 (0, 0, -speed));


		if (Input.GetAxis ("Mouse ScrollWheel") > 0) {
			//camera.orthographicSize--;
			camera.transform.Translate (new Vector3 (0, 0, speed));
		}
		if (Input.GetAxis ("Mouse ScrollWheel") < 0) {
			//camera.orthographicSize++;
			camera.transform.Translate (new Vector3 (0, 0, -speed));
		}

		if (Input.GetMouseButtonUp (0)) {
			LayerMask layerMask = ~(1 << LayerMask.NameToLayer ("Floor"));
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask)) {
				transform.position = hit.point + new Vector3 (0, transform.position.y, 0);
			}
		}

		if (Input.GetMouseButtonUp(2)) {
			Vector3 newPos = new Vector3 (target.position.x, transform.position.y, target.position.z - space);
			transform.position = newPos;
		}

	}
}
