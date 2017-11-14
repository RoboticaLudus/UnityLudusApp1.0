using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ListarOredenes : MonoBehaviour {

	//public GameObject[] posiciones;
	public AudioSource SoundX;
	public GameObject Lista;
	Orden Miorden = null;
	public Text list;
	int i=1;
	string comando;
	public string cadena= "p1,";
	public Funcion HayFuncion;
	ClientSocket Net;


	// Use this for initialization
	void Start () {

		//Lista.gameObject.GetComponent<Renderer> ().enabled = false;
		//Lista.gameObject.SetActive(false);

	}
	
	// Update is called once per frame
	public void Listar () {

		Lista.gameObject.SetActive(true);
		//posiciones = GameObject.FindGameObjectsWithTag ("Posiciones");
		//foreach (GameObject posicion in posiciones) {
		list.text = "Instrucciones \n";
		i = 1;
		for (int a = 1; a < 9; a++){

			GameObject posicion = GameObject.Find ("Posicion " + a);

			Miorden = posicion.transform.GetComponentInChildren<Orden>();

			//if (posicion.transform.Find ("Comando")) {
			if (Miorden) {

				//Comand = posicion.transform.Find ("Comando").gameObject;
				comando = Miorden.accion.ToString();


				if (Miorden.accion.ToString () == "Retroceder") {
					cadena += HayFuncion.cadenaF;
					list.text += i + " Comando Función" + "\n";
				} else {
					cadena += Miorden.eslabon.ToString () + ",";
					list.text += i + " Comando " + comando + "\n";
				}
				i++;
			} else {
				list.text = list.text + i + " Nada \n";
				cadena  +=  "n" + ",";
				i++;
			}
	
		}
		cadena  +=  "p2";
		Debug.Log(cadena);

		GameObject MiNet = GameObject.Find ("NetStatus");
		Net = MiNet.transform.GetComponent<ClientSocket>();
		Net.mensaje = cadena;
	
	
			cadena = "p1,";		
		}


	public void Limpiar(){
		//	list.text = "Instrucciones \n";
		//	i = 1;
		SoundX.Play ();
		for (int ab = 1; ab < 9; ab++){

			GameObject posicion = GameObject.Find ("Posicion " + ab);
			Miorden = posicion.transform.GetComponentInChildren<Orden>();

			if (Miorden) {

				GameObject.Destroy (Miorden.gameObject);

				//Comand = posicion.transform.Find ("Comando").gameObject;
				//			comando = Miorden.accion.ToString();
				//			list.text += i + " Comando " + comando + "\n";

				//			cadena  +=  Miorden.eslabon.ToString() + ",";
				//print (i);
				//Miorden = posicion.GetComponentInChildren<"Comando">.accion;



				//i++;
			} else {
				//			list.text = list.text + i + " Nada \n";
				//			cadena  +=  "n" + ",";
				//i++;
			}
		}

	}


	public void volver(){
		Lista.gameObject.SetActive(false);
	}
}
