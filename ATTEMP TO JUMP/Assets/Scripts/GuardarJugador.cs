using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardarJugador : MonoBehaviour
{

    private string NuevaPuntuacionURL = "quester22.square7.ch//RankingScripts//NuevaPuntuacion.php?";
    private string claveSecreta = "dcbkx12fjea59";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnviarJugadores("Cristian", 2));
    }

    public string Md5Sum(string strToEncrypt)
    {
        System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
        byte[] bytes = ue.GetBytes(strToEncrypt);
        System.Security.Cryptograhy.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashBytes = md5.ComputeHash(bytes);
        string hashString = "";
        for(int i = 0; i < hashBytes.length; i++)
        {
            hashString += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
        }
        return hashString.Padleft(32, '0');
    }

    IEnumerator EnviarJugadores(string nombreJugador, int puntuacionJugador)
    {
        string hash = Md5Sum(nombreJugador + puntuacionJugador + claveSecreta);

        string PostURL = NuevaPuntuacionURL + "nombre" + WWW.EscapeURL(nombreJugador) + "&puntuacion=" + puntuacionJugador + "&hash" + hash;

        WWW DataPost = new WWW("http://" + PostURL);
        yield return DataPost;

        if(DataPost.error != null)
        {
            print("Problema al intentar enviar el jugador y su puntuacion a la base de datos: " + DataPost.error);
        }
        else
        {
            Debug.Log((System.Text.Encoding.UTF8.GetString(DataPost.bytes)));
        }
    }


}
