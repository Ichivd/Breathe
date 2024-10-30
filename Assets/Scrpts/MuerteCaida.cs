using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class MuerteCaida : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jugador"))
        {
            StartCoroutine(ReiniciarEscena());
        }
    }

    IEnumerator ReiniciarEscena()
    {
        yield return new WaitForSeconds(1f); // Espera 1 segundo
        int escenaActual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(escenaActual);
    }
}
