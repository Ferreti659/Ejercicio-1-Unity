using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    
    public int PuntosTotales { get { return puntosTotales; } }
    private int puntosTotales;
    private int puertaPasada;
    private int puertaBajada;


    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales += puntosASumar;
        Debug.Log(puntosTotales);
    }

    private void Update()
    {
        puertasiguientenivel();
        puertanivelanterior();
    }

    public void puertasubida(int puertaCruzada)
    {
        puertaPasada += puertaCruzada;
        Debug.Log(puertaPasada);
    }

    public void puertabajada(int bajar)
    {
        puertaBajada += bajar;
        Debug.Log(puertaBajada);
    }

    public void puertasiguientenivel()
    {
        if(puertaPasada==1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
    }

    public void puertanivelanterior()
    {
        if (puertaBajada == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            
        }
    }

    public void seleccionpersonaje()
    {
        SceneManager.LoadScene("seleccionpersonaje");
    }

    public void jugar()
    {
        SceneManager.LoadScene("lvl1");
    }

    public void Opciones()
    {
        SceneManager.LoadScene("Opciones");
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void volvermainmenu()
    {
        SceneManager.LoadScene("menu");
    }
}
