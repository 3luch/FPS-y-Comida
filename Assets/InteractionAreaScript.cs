using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionAreaScript : MonoBehaviour
{
    public Text Text;

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
            Text.text = "puntos: " + puntaje;
        }
    }
}