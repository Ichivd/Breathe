using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Jugador;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = Jugador.transform.position.x;
        position.y = Jugador.transform.position.y;
     

        transform.position = position;

        
    }
}
