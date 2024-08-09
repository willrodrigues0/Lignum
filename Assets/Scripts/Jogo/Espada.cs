using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : MonoBehaviour
{
    public Transform quemColeta;

    public int velocidade;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D (Collider2D col)
    {
        transform.position = Vector2.MoveTowards (transform.position, quemColeta.position, velocidade * Time.deltaTime);
    }
}
