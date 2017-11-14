using UnityEngine;
using System.Collections;

public class Orden : MonoBehaviour {

	public enum Ordenes
	{
		Avanzar,                                                               // Items will be swapped between cells
		Retroceder,                                                           // Item will be dropped into cell
		Derecha,                                                           // Item will be dragged from this cell
		Izquierda                                                     // Item will be cloned and dragged from this cell
	}

	public enum LetraCadena
	{
		a,                                                               // Items will be swapped between cells
		r,                                                           // Item will be dropped into cell
		d,                                                           // Item will be dragged from this cell
		i                                                     // Item will be cloned and dragged from this cell
	}


	public Ordenes accion;
	public LetraCadena eslabon;


	// Use this for initialization
	void Start () {

	}
	







}
