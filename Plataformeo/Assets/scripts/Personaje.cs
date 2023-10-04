using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    public int hp = 70;
    public int hpMax = 100;
    public int vidas = 3;
    public int score = 10;

    public GameObject splashHeartPrefab;

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (hp = 0)
        {
            GameObject efectoBroke = Instantiate(splashHeartPrefab);

            efectoBroke.transform.position = elPerso.transform.position;
        }
    }

    public void hacerDanio(int puntosDanio, GameObject enemigo)
    {
        hp = hp - puntosDanio;
        print(name + " recibe daño de " + puntosDanio + " por " + enemigo);
    }

    public void muerteInsta(GameObject quien)
    {

        print(name + " murio instantaneamente por " + quien);
        hp = 0;

    }


   

    
        
    


}
