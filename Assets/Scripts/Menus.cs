using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Menus : MonoBehaviour {


	public AudioSource SoundOK;
	public ListarOredenes lista;

	// Use this for initialization
	public void Quit () {
		Application.Quit ();
	}
	
	// Update is called once per frame
	public void Recargar () {
	
		SceneManager.LoadScene (0);
	
	}

	public void Aceptar () {

		SoundOK.Play ();
		lista.Listar ();
		//SceneManager.LoadScene (0);

	}






}
