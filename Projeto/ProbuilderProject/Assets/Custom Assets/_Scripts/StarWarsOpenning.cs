using UnityEngine;
using UnityEngine.UI;

public class StarWarsOpenning : MonoBehaviour {

	public Font  textFont;
	public int   textFontSize = 20;
	public Color textColor    = Color.yellow;
	public float speed        = 2;
	public Text  title;
	public Text  rest;
	public Text  main;

	public void Start() {
		main.text = "";
		title.rectTransform.sizeDelta = new Vector2(400, 100);
		rest.rectTransform.sizeDelta = new Vector2(400, 500);
		title.rectTransform.Rotate(45, 0, 0);
		rest.rectTransform.Rotate(45, 0, 0);

		// Must Compute the Position based on the Camera Frustum and if
		//   FullScreen is set or not

		title.rectTransform.localPosition = new Vector3(-30, -72, 78);
		rest.rectTransform.localPosition  = new Vector3(0, -259, -109);



		title.font      = textFont;
		rest.font       = textFont;
		title.fontSize  = textFontSize;
		rest.fontSize   = textFontSize;
		title.alignment = TextAnchor.UpperCenter;
		rest.alignment  = TextAnchor.UpperLeft;
		title.color     = textColor;
		rest.color      = textColor;
	}

	void Update () { 
		main.rectTransform.Translate((transform.up + transform.forward) * speed * Time.deltaTime);
		//title.rectTransform.Translate(Vector3.up * speed * Time.deltaTime);
		//rest.rectTransform.Translate(Vector3.up * speed * Time.deltaTime);
	}
}
