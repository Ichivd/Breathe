using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Aventura()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void Opciones()
    {
        
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void Titulo()
    {
        SceneManager.LoadScene("PantallaInicio");
    }
}
