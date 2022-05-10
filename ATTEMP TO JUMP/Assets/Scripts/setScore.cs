using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setScore : MonoBehaviour
{

    public GameObject Nombre;
    public GameObject Puntuacion;

    public void SetScore(string nombreJugador, string puntuacionJugador)
    {

        Nombre.GetComponent<Text>().text = nombreJugador;
        Puntuacion.GetComponent<Text>().text = puntuacionJugador;

    }

}
