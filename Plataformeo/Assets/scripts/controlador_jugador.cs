using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_jugador : MonoBehaviour
{
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
        MiCuerpo.velocity = new Vector3(5, 0, 0);

        MiAnimador.SetBool("caminata", true);
    }
}
