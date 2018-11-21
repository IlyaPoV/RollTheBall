using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	public bool Play;
	public bool Exit;
	private Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnMouseEnter() {
		rend.material.color = Color.cyan;
}
	void OnMouseExit() {
		rend.material.color = Color.white;
		}
	void OnMouseUp() {
		if (Play == true)
						Application.LoadLevel (0);
		if (Exit == true)
						Application.Quit ();
		}

}