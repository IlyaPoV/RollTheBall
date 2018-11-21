using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {
	public GameObject ground;
	public GameObject nextLvl;
	public bool Useable = true;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "Player" && Useable == true) {
			transform.Translate(Vector3.down/2);
			ground.transform.Translate(Vector3.left*18);
			nextLvl.transform.Translate(Vector3.left*18);
			Useable = false;
		}
 }
}
