using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerta : MonoBehaviour
{
    //public GameObject SplashAguaPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            print(name + " detecte colision con " + otroObjeto);

            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            elPerso.muerteInsta(this.gameObject);


            //GameObject efectoSplash = Instantiate(splashAguaPrefab);

            //efectoSplash.transform.position = elPerso.transform.position;
        }
    }
}
