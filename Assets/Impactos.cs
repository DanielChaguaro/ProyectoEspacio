using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impactos : MonoBehaviour
{
    private Vector3 initialPlayerPosition; // Guarda la posición inicial del jugador
    public GameObject player; // Referencia al GameObject del jugador
    private Vector3 initialPosition; 
    public float cantidadpuntos;
    public Puntaje puntaje;
    void Start()
    {
        // Encuentra al jugador por su tag al inicio
        if (player != null)
        {
            initialPosition = transform.position;
            initialPlayerPosition = player.transform.position; // Guarda la posición inicial del jugador
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            TeleportToInitialPosition(); // Teletransporta al enemigo a la posición inicial
            puntaje.SumarPuntos(cantidadpuntos);
        }
        // Verifica si el enemigo ha colisionado con el jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            TeleportPlayerToInitialPosition(); // Teletransporta al jugador a su posición inicial
        }
    }

    void TeleportPlayerToInitialPosition()
    {
        if (player != null)
        {
            player.transform.position = initialPlayerPosition; // Teletransporta al jugador a la posición inicial guardada
            player.GetComponent<Rigidbody>().velocity = Vector3.zero; // Reinicia la velocidad del jugador si tiene Rigidbody
        }
        
    }
    void TeleportToInitialPosition()
    {
        transform.position = initialPosition; // Teleporta al enemigo a la posición inicial guardada
       
    }
}
