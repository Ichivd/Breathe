using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaGotas : MonoBehaviour
{
    public GameObject Gota;
    public float DisparoIntervalo = 2f; // Intervalo de tiempo entre disparos
    public float GotaDesapareceDespues = 3f; // Tiempo en segundos que la Gota desaparece despu�s de ser disparada

    private float tiempoDesdeUltimoDisparo = 0f;

    // Update is called once per frame
    void Update()
    {
        tiempoDesdeUltimoDisparo += Time.deltaTime;
        if (tiempoDesdeUltimoDisparo >= DisparoIntervalo)
        {
            DispararGota();
            tiempoDesdeUltimoDisparo = 0f;
        }
    }

    void DispararGota()
    {
        // Instancia un nuevo objeto Gota a partir del prefab
        GameObject gota = Instantiate( Gota, transform.position, Quaternion.identity );
        // Destruye el objeto Gota despu�s de un cierto tiempo
        Destroy(gota, GotaDesapareceDespues);
    }
}
