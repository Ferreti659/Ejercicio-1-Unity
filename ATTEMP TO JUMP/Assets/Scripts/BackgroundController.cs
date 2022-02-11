using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public Transform personaje;
    private float tamañoBackground;
    private float alturaBackground;

    void Start()
    {
        tamañoBackground = Camera.main.orthographicSize;
        alturaBackground = tamañoBackground * 2;
    }

    // Update is called once per frame
    void Update()
    {
        CalcularPosicionCamra();
    }

    void CalcularPosicionCamra()
    {
        int pantallaPersonaje = (int)(personaje.position.y / alturaBackground);
        float alturaCamara = (pantallaPersonaje * alturaBackground) + tamañoBackground;

        transform.position = new Vector3(transform.position.x, alturaCamara, transform.position.z);
    }
}
