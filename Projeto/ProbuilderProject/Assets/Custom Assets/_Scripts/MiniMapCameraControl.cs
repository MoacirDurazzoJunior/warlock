using UnityEngine;
using UnityEngine.UI;

public class MiniMapCameraControl : MonoBehaviour {
	public Transform target;


	public void LateUpdate() {
		transform.position = target.position + new Vector3 (0, 15, 0);
		transform.rotation = target.rotation;
		transform.Rotate (90, 0, 0);
	}
}