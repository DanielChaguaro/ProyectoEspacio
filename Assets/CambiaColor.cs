using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaColor : MonoBehaviour
{
    private int impactosRecibidos = 0;
    private Renderer rend;

    public Color Amarillo;
    public Color Naranja;
    public Color Rojo;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            impactosRecibidos++;

            switch (impactosRecibidos)
            {
                case 1:
                    CambiarColor(Amarillo);
                    break;
                case 2:
                    CambiarColor(Naranja);
                    break;
                case 3:
                    CambiarColor(Rojo);
                    break;
                case 4:
                    DestruirObjeto();
                    break;
            }
        }
    }

    void CambiarColor(Color nuevoColor)
    {
        rend.material.color = nuevoColor;
    }

    void DestruirObjeto()
    {
        Destroy(gameObject);
    }
}
