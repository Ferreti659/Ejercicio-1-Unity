using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform personaje;
    private float tamañoCamara;
    private float alturaPantalla;


    void Start()
    {
        tamañoCamara = Camera.main.orthographicSize;
        alturaPantalla = tamañoCamara * 2;
    }

    // Update is called once per frame
    void Update()
    {
        CalcularPosicionCamara();
    }

    void CalcularPosicionCamara()
    {
        //camara eje y
        int pantallaPersonaje = (int)(personaje.position.y / alturaPantalla);
        float alturaCamara = (pantallaPersonaje * alturaPantalla) + tamañoCamara;
        

        transform.position = new Vector3(transform.position.x, alturaCamara, transform.position.z);
        
        //camara eje x
        
    }
}
