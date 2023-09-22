using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_jugador : MonoBehaviour
{
    public float velocidadCaminar = 5;
    public float fuerzaSalto = 20;

    private Rigidbody2D MiCuerpo;
    private Animator MiAnimador;
    // Start is called before the first frame update
    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
        MiAnimador = GetComponent<Animator>();
        
        
    }

    // Update is called once per frame
    void Update()
    {

        float velVert = MiCuerpo.velocity.y;
        float movHoriz = Input.GetAxis("Horizontal");
        

        if (movHoriz > 0)//Se mueve a la derecha
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);

            MiCuerpo.velocity = new Vector3(velocidadCaminar, velVert, 0);

            MiAnimador.SetBool("CAMINANDO", true);
        }
        else if (movHoriz < 0) //Se mueve a la izq
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);

            MiCuerpo.velocity = new Vector3(-velocidadCaminar, velVert, 0);
            MiAnimador.SetBool("CAMINANDO", true);
        }
        else
        {
            MiCuerpo.velocity = new Vector3(0, velVert, 0);
            MiAnimador.SetBool("CAMINANDO", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
<<<<<<< HEAD
            MiCuerpo.AddForce(new Vector3(0,fuerzaSalto,0), ForceMode2D.Impulse);
        }

        MiAnimador.SetFloat("Vel_Vert", velVert);
    } 
    
   
=======
            MiCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
        }

        MiAnimador.SetFloat("VEL_VERT", velVert);
    }
>>>>>>> a805d1eb37a764cb9a3f65bc4704a3530abc665a
}

