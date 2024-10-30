using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


/// <summary>
/// script que lleva el tiempo transcurrido del juego y al final guarda el highscore
/// </summary>
public class Crono : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textTime;


    float initialTime = 0;

    void Start()
    {
        initialTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {


        UpdTimer(Time.time - initialTime);



    }

    /// <summary>
    /// metodo que lleva a cabo para poder modificar el texto y ver cuanto tiempo llevamos
    /// </summary>
    /// <param name="timer"></param>
    public void UpdTimer(float timer)
    {
        float minutes = Mathf.FloorToInt(timer / 60);
        float second = Mathf.FloorToInt(timer % 60);

        if (second < 10)
        {
            textTime.text = minutes.ToString() + ": 0" + second.ToString() ;

        }
        else
        {
            textTime.text = minutes.ToString() + ": " + second.ToString() ;
        }

        if (minutes == 3)
        {
            int escenaActual = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(escenaActual);
        }
    }
}