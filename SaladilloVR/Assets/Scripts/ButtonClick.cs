///////////////////////////////
// Práctica: SaladilloVR
// Alumno: Antonio Carlos Ordoñez Cintrano
// Curso: 2017/2018
// Fichero: ButtonClick.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour {

    #region Declaracion de variables

    // GameObject que se modifica cuando se pulsa el boton
    public GameObject clickObject;

    #endregion

    #region Metodos

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        // Si el objeto estaa activo, se desactiva y viceversa
        clickObject.SetActive(!clickObject.activeSelf);
    }

    #endregion
}
