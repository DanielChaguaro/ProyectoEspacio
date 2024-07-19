using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer=180f;
    public Text textTimer;
    public Puntaje puntaje;
    public GameObject image;
    public GameObject button;
    public GameObject player;
    public GameObject enemies;
    // Update is called once per frame
    
    void Update()
    {
        timer=timer-Time.deltaTime;
        textTimer.text=""+timer.ToString("f1");
        if (timer <= 0)
        {
            timer = 0f; 
            
            
            image.SetActive(true);
            button.SetActive(true);
            enemies.SetActive(false);
            player.SetActive(false);
        }
    }
}
