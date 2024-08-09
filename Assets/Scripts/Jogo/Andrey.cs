using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andrey : MonoBehaviour
{

    Rigidbody2D rig;

    public int velocidade, pulo;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent <Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        mover ();
        pular ();
    }

    void mover ()
    {
        if (CameraJogador.estaNoMatias == false)
        {
            rig.velocity = new Vector2 (Input.GetAxis ("Horizontal") * velocidade, rig.velocity.y);
        }
    }

    void pular ()
    {
        if (Input.GetButtonDown ("Jump") && CameraJogador.estaNoMatias == false)
        {
            rig.AddForce (Vector2.up * pulo, ForceMode2D.Impulse);
        }
    }
}
