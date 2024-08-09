using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraJogador : MonoBehaviour
{
    public Transform matias, andrey;
    public Transform auxiliar;

    public static bool estaNoMatias = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (matias.position.x, matias.position.y, transform.position.z);

        trocar ();
    }

    void trocar ()
    {
        /*if (Input.GetMouseButtonDown (1))
        { 
            transform.position = new Vector3 (alvo.position.x, alvo.position.y, transform.position.y);
        }*/

        switch (estaNoMatias)
        {
            case true:

            transform.position = new Vector3 (matias.position.x, matias.position.y, transform.position.z);

            if (Input.GetMouseButtonDown (1))
            {
                estaNoMatias = false;
            }

            break;


            case false:

            transform.position = new Vector3 (andrey.position.x, andrey.position.y, transform.position.z);

            if (Input.GetMouseButtonDown (1))
            {
                estaNoMatias = true;
            }

            break;
        }
    }
}

