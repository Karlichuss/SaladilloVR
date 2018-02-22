///////////////////////////////
// Práctica: SaladilloVR
// Alumno: Antonio Carlos Ordoñez Cintrano
// Curso: 2017/2018
// Fichero: SaveScript.cs
///////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveScript : MonoBehaviour {

    #region Declaracion de variables

    // Objeto con la direccion IP instroducida por el usuario
    public Text ipAddress;

    #endregion

    #region Metodos

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// Metodo que se ejecuta cuando se pulsa en el boton Save
    /// </summary>
    /// <remarks>
    /// Obtiene la direccion IP introducida por el usuario y la guarda en las preferencias de la aplicacion.
    /// </remarks>
    public void Click()
    {
        // Se obtiene la direccion IP introducida por el usuario
        GameManager.ipAddress = ipAddress.GetComponent<Text>().text;
        // Se guarda la direccion IP
        PlayerPrefs.SetString(GameManager.IP_ADDRESS, GameManager.ipAddress);
        // Se almacena el valor en la configuracion de la aplicacion
        PlayerPrefs.Save();
    }

    #endregion

}
