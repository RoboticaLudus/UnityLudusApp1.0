using UnityEngine;
using System.Collections;

public class Funcion : MonoBehaviour {

	public GameObject PanelF;
	Orden MiordenF = null;

	//public Text list;
	//int i=1;
	string comandoF;
	public string cadenaF= "n,n,n,n";

	//ClientSocket Net;


	// Use this for initialization
	void Update () {

		}

	// Update is called once per frame
	public void MostrarF () {

		PanelF.gameObject.SetActive(true);
		//ActualizarF ();
	}

	void ActualizarF () {

		cadenaF = "";
		//posiciones = GameObject.FindGameObjectsWithTag ("Posiciones");
		//foreach (GameObject posicion in posiciones) {
		for (int ab = 1; ab < 5; ab++){

			GameObject posicion = GameObject.Find ("PosicionF " + ab);
			MiordenF = posicion.transform.GetComponentInChildren<Orden>();

			if (MiordenF && MiordenF.eslabon.ToString() != "r")
			{

				cadenaF  +=  MiordenF.eslabon.ToString() + ",";

				//i++;
			} else {
				//			list.text = list.text + i + " Nada \n";
				cadenaF  +=  "n" + ",";
				//i++;
			}
		}
	}


	public void LimpiarF(){
		//	list.text = "Instrucciones \n";
		//	i = 1;

		for (int a = 1; a < 5; a++){

		GameObject posicion = GameObject.Find ("PosicionF " + a);
		MiordenF = posicion.transform.GetComponentInChildren<Orden>();

		if (MiordenF) {
				
				GameObject.Destroy (MiordenF.gameObject);
		
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

	public void VolverI(){
		//ActualizarF ();
		//Debug.Log(cadenaF);
		PanelF.gameObject.SetActive(false);
	}

	public void VolverF(){
		ActualizarF ();
		//Debug.Log(cadenaF);
		PanelF.gameObject.SetActive(false);
	}
}



