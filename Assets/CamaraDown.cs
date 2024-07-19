using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraDown : MonoBehaviour
{
    public Transform target; // El objeto que la cámara seguirá
    public float smoothSpeed = 0.125f; // Velocidad de suavizado de la cámara. Cuanto más bajo, más suave será el seguimiento.
    public Vector3 offset; // Offset o desplazamiento de la cámara respecto al jugador

    void LateUpdate()
    {
        if (target == null)
            return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target); // Hace que la cámara mire hacia el jugador todo el tiempo
    }
}
