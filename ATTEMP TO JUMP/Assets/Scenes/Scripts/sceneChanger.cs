using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    public int valor = 1;
    public GameManager gameManager;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        gameManager.puertasubida(valor);
        


    }
}
