using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    // Start is called before the first frame update

    KeyCode jumpKey;
    KeyCode leftKey;
    KeyCode rightKey;


    void Start()
    {
        jumpKey = KeyCode.Space;
        leftKey = KeyCode.A;
        rightKey = KeyCode.D;
    }

    // Update is called once per frame
    void Update()
    {
        // Detectar si se presiona la tecla asignada al salto
        if (Input.GetKeyDown(jumpKey))
        {
            Debug.Log("Salto!");
            // Realiza la acci�n de salto aqu�
        }

        // Detectar si se presiona la tecla asignada al movimiento a la izquierda
        if (Input.GetKey(leftKey))
        {
            Debug.Log("Izquierda!");
            // Realiza la acci�n de movimiento a la izquierda aqu�
        }

        // Detectar si se presiona la tecla asignada al movimiento a la derecha
        if (Input.GetKey(rightKey))
        {
            Debug.Log("Derecha!");
            // Realiza la acci�n de movimiento a la derecha aqu�
        }


    }

    public void SetJumpKey(KeyCode key)
    {
        jumpKey = key;
    }

    public void SetLeftKey(KeyCode key)
    {
        leftKey = key;
    }

    public void SetRightKey(KeyCode key)
    {
        rightKey = key;
    }
}

