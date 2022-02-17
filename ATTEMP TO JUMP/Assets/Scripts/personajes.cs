using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "nuevoPersonaje", menuName = "Personaje")]

public class personajes : ScriptableObject
{
    public GameObject personajeJugable;

    public Sprite imagen;

    public string nombre;
}
