using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public Transform personaje;
    private float tama�oBackground;
    private float alturaBackground;

    void Start()
    {
        tama�oBackground = Camera.main.orthographicSize;
        alturaBackground = tama�oBackground * 2;
    }

    // Update is called once per frame
    void Update()
    {
        CalcularPosicionCamra();
    }

    void CalcularPosicionCamra()
    {
        int pantallaPersonaje = (int)(personaje.position.y / alturaBackground);
        float alturaCamara = (pantallaPersonaje * alturaBackground) + tama�oBackground;

        transform.position = new Vector3(transform.position.x, alturaCamara, transform.position.z);
    }
}
