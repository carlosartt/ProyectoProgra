using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    //parametro que indica la fuerza con la que salta la pelota
    public float FuerzaSalto = 5;
    //es una referencia al componente Rigi body 2d
    private Rigidbody2D MiCuerpo;

    // Start is called before the first frame update
    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Si en este frame fue presionado el
        //boton para saltar (espacio)
        if (Input.GetButtonDown("Jump")) 
        {
            print("se presiono el salto");
            MiCuerpo.AddForce(
                new Vector3(
                    0,FuerzaSalto, 0),
                ForceMode2D.Impulse);
        }
}
}
