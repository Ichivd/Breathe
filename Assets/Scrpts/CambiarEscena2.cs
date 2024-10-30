using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena2 : MonoBehaviour
{
    public string Nivel3; // El nombre de la escena a la que quieres cambiar

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que ha entrado en contacto es el objeto Jugador
        if (other.CompareTag("Jugador"))
        {
            // Carga la escena con el nombre especificado
            SceneManager.LoadScene("Nivel3");
            //Debug.Log("Hola");
        }
    }
}
