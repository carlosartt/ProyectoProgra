using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            print(name + " detecte colision con " + otroObjeto);

            Personaje elPerso = otroObjeto.GetComponent<Personaje>();

            elPerso.hacerDanio(5, this.gameObject);
        }
    }

}
