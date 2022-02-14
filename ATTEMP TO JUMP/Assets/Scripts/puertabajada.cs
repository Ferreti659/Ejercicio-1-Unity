using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertabajada : MonoBehaviour
{
    public int valor = 1;
    public GameManager gameManager;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        gameManager.puertabajada(valor);



    }
}
