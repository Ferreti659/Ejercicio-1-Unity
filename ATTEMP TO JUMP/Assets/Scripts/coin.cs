using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int valor = 1;
    public GameManager gameManager;
    //public AudioClip coinSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
            gameManager.SumarPuntos(valor);
            Destroy(this.gameObject);
            //AudioManager.Instance.ReproducirSonido(coinSFX);
        

    }
}
