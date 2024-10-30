using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Start is called before the first frame update

    //Variables de fisicas
    private Rigidbody2D rb;
    private float Horizontal ;
    private bool Grounded;

    //Variables de movimiento
    public float FuerzaSalto;
    public float Velocidad;


    //Variables animaciones
    private Animator animator;



    public enum ControlScheme
    {
        ArrowKeys,
        WASD,
        IJKL
    }

    public ControlScheme controlScheme;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 

        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()

    {
        Horizontal = Input.GetAxisRaw("Horizontal"); //Funcion par saber que está pulsando el jugador

        if(Horizontal < 0)
        {
            transform.localScale = new Vector3(-0.1023967f, 0.1023967f, 0.1023967f);
        }
        else if (Horizontal > 0.0f)
        {
            transform.localScale = new Vector3(0.1023967f, 0.1023967f, 0.1023967f);
        }



        //Lanza un rayo que comprueba que esta en el suelo  para poder saltar 
        //Debug.DrawRay(transform.position, Vector3.down * 1f, Color.red); //Simula el reyo

        animator.SetBool("Walk", Horizontal != 0.0f);

        if (Physics2D.Raycast(transform.position, Vector3.down, 1f))
        {
            Grounded = true;
        }
        else
        {
            Grounded = false;
        }




        if (Input.GetKeyDown(KeyCode.W) && Grounded == true)
        {
            Jump();
        }



        //Debug.Log(Grounded);

        

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Horizontal*Velocidad , rb.velocity.y);
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * FuerzaSalto, ForceMode2D.Impulse);
    }
}
