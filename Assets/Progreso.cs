using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Progreso : MonoBehaviour
{
    public Image barraProgreso;
    public Puntaje puntaje;
    public float progresoActual;
    public float progresoMaximo;
    public TextMeshProUGUI nivelText;
    private int nivel = 1;
    private float puntosAnteriores = 0f;
    void Start()
    {
        nivelText.text = nivel.ToString("0");
    }
    void Update()
    {
        progresoActual = puntaje.puntos % progresoMaximo;

        // Actualiza la barra de progreso
        barraProgreso.fillAmount = progresoActual / progresoMaximo;

        // Incrementa el nivel y reinicia la barra de progreso si progresoActual alcanza o supera 1000
        if ((int)(puntaje.puntos / progresoMaximo) > (int)(puntosAnteriores / progresoMaximo))
        {
            nivel++;
            nivelText.text = nivel.ToString("0");
        }

        // Actualiza puntosAnteriores para la próxima verificación
        puntosAnteriores = puntaje.puntos;

    }
}
