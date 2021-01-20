using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoqueModeloMoto : MonoBehaviour
{

    [SerializeField]
    ChoquesMoto audioChoques;


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Car"))
        {
            print(other.name);
            audioChoques.GolpeConCarro();
        }
        else
        {
            if (other.CompareTag("Ped"))
            {
                print(other.name);
                audioChoques.GolpeConPersona();
            }
            else {
                print(other.name);
                //audioChoques.GolpeObjeto();
            }
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            print(other.gameObject.name);
            audioChoques.GolpeConCarro();
        }
        else
        {
            if (other.gameObject.CompareTag("Ped"))
            {
                print(other.gameObject.name);
                audioChoques.GolpeConPersona();
            }
            else
            {
                print(other.gameObject.name);
                //audioChoques.GolpeObjeto();
            }
        }
    }
}
