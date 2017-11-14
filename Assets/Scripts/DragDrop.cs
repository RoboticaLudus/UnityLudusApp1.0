using UnityEngine;
using System.Collections;

public class DragDrop : MonoBehaviour {


	public int dist = 100;
	Vector3 inicio;
	// Use this for initialization
	void Start () {
		inicio = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Drag() {
		GameObject.FindWithTag ("Comandos").transform.position = Input.mousePosition;
			
	}


	public void Drop() {
		GameObject ph1 = GameObject.FindWithTag ("Posiciones");
		float distance = Vector3.Distance (GameObject.FindWithTag ("Comandos").transform.position, ph1.transform.position);
		//print ("distncia" + distance);
		if (distance < dist) {

			if (ph1.tag == "Posiciones")	GameObject.FindWithTag ("Comandos").transform.position = ph1.transform.position;
			else	GameObject.FindWithTag ("Comandos").transform.position = inicio;

		}
}}
