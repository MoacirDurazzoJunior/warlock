using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public float changeFloorTime;
	private float counter;

	public GameObject[] floors;
	private int index;
	private int maxIndex;

	// Use this for initialization
	void Start () {
		index = 0;
		maxIndex = floors.Length - 1;
		counter = changeFloorTime;

		foreach( GameObject f in floors ){
			f.SetActive(false);
		}

		floors [index].SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (index < maxIndex) {
			if (counter <= 0F) {
				floors [index].SetActive (false);
				index++;
				floors [index].SetActive (true);
				counter = changeFloorTime;
			} else {
				counter -= Time.deltaTime;
			}
		}
		//Debug.Log (counter);
	}
}
