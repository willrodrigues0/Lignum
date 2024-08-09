using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Servo : MonoBehaviour
{
    public Transform alvo;

    public float velocidade = 0.1f;
    public float distanciaObjetos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanciaObjetos = Vector2.Distance (alvo.position, transform.position);

        seguir ();
    }

    void seguir ()
    {
        if (distanciaObjetos < 8)
        {
            transform.position = Vector2.MoveTowards (transform.position, alvo.position, velocidade * Time.deltaTime);
        }
    }
}
