using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class menuselecion : MonoBehaviour
{
    private int index;
    [SerializeField] private Image imagen;
    [SerializeField] private TextMeshProUGUI nombre;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;

        index = PlayerPrefs.GetInt("JugadorIndex");

        if (index > gameManager.personajes.Count - 1)
        {
            index = 0;
        }
        
        CambiarPantalla();

    }

    public void CambiarPantalla()
    {
        PlayerPrefs.SetInt("JugadorIndex", index);
        imagen.sprite = gameManager.personajes[index].imagen;
        nombre.text = gameManager.personajes[index].nombre;
        
    }

    public void siguientePersonaje()
    {
        if (index == gameManager.personajes.Count - 1)
        {
            index = 0;
        }
        else
        {
            index += 1;
        }

        CambiarPantalla();
    }

    public void personajeAnterior()
    {
        if (index == 0)
        {
            index = gameManager.personajes.Count - 1;
        }
        else
        {
            index -= 1;
        }

        CambiarPantalla();
    }

    public void IniciarJuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
