using UnityEngine;
using System.Collections;


public class Menu : MonoBehaviour
{
	float vWidth = 1280f;
	float vHeigth = 800f;
	float dHeigth = 800f;
	public int dFont = 48;
	public int mFont = 200;
	public float dFonto = 12f;


	// Use this for initialization
	void Start ()
	{
		//GUI.matrix = Matrix4x4.TRS (Vector3.zero, Quaternion.identity, new Vector3 (Screen.width / vWidth, Screen.height / vHeigth, 1.0f));

	}

	// Update is called once per frame
	void Update ()
	{
	}


	public void Quit ()
	{
		Application.Quit (); 
	}


	bool m_showGUI;
	public ClientSocket m_theObject;
	string m_theNewName = "192.168.4.1";
	//enable the GUI
	public void ShowGUI ()
	{
		//m_theObject = GetComponent<ClientSocket> ();
		m_theObject = GameObject.Find("NetStatus").GetComponent<ClientSocket> (); 
		m_showGUI = true;

	}
	//render the GUI

	void OnGUI ()
	{
		GUI.matrix = Matrix4x4.TRS (Vector3.zero, Quaternion.identity, new Vector3 (Screen.width / vHeigth, Screen.height / vWidth, 1.0f));

		dFonto = Screen.width / dHeigth * dFont;
		mFont = (int) dFonto;

		GUI.skin.label.fontSize = GUI.skin.box.fontSize = GUI.skin.textField.fontSize = GUI.skin.button.fontSize = mFont;


		if (m_showGUI) {
			// draw gui stuff

			m_theNewName = GUI.TextField (new Rect (10, 10, 500, 100), m_theNewName, 25);
			if (GUI.Button (new Rect (10, 150, 500, 300), "Finish"))
				FinishedEditing ();
		}
	}
	// assign the name and close the GUI
	void FinishedEditing ()
	{
		m_theObject.Host = m_theNewName;
		m_theObject.listo = true;
		m_showGUI = false;
		// continue running the game and whatever else you need to do here
	}

	public void ConectF ()
	{
		m_theObject.Host = m_theNewName;
		m_theObject.listo = true;
	}


}