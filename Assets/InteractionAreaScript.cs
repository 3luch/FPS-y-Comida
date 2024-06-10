using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionAreaScript : MonoBehaviour
{


    int puntaje = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PickUpScript>())
        {
            PickUpScript mante = other.GetComponent<PickUpScript>();
            if (mante.esComida == true)
            {
                puntaje += mante.puntosHambre;
                Destroy(other.gameObject);
            }
            else
            {
                puntaje += mante.puntosHambre;

            }
        }
    }
}