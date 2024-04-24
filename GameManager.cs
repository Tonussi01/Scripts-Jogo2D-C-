using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public  static GameManager inst;
    public  int vida;
    public  Image[] imgCoracao;
    public  Text contador_carne;
    public  Text segundo;
    public  Text minuto;
    public  Transform nasc;
    public  int carne;
    public  int ganhou;
    public  int segundo_real;
    public  GameObject winPanel;
    public  GameObject losePanel;
    public  int faseAtual;
     


    [Range(0, 23)]
    public int HoraAtual = 1;
    [Range(0, 59)]
    public int MinutoAtual = 0;
    [Range(0, 599)]
    public int SegundoAtual = 0;

    [Header("Velocidade do Relogio")]
    public  float VelocidadeDoRelogio = 15f;
    private float Contador = 0;

    public  bool restartou = false;

    void FixedUpdate()
    {
        segundo_real    = SegundoAtual / 10;
        minuto.text     = MinutoAtual.ToString("D2"); 
        segundo.text    = segundo_real.ToString("D2");
        Relogio();
    }


    void Awake()
    {

        Destroy(GameObject.Find("GameManager(Clone)"));
        if (inst == null)
        {
            inst = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        faseAtual       = 2;
        vida            = 4;
        carne           = 0;
        Time.timeScale  = 1;
    }

    void Update()
    {
        contador_carne.text = carne.ToString();

        if (ganhou == 1)
        {
            winPanel.SetActive(true);
        }
        if (ganhou == 2)
        {
            losePanel.SetActive(true);
        }
        if (ganhou == 0)
        {
        }

        if(restartou == true)
        {
           // StatusPartida.enabled = false;
            restartou = false;
            ganhou    = 0;
            carne     = 0;
            winPanel.SetActive(false);
            losePanel.SetActive(false);
        }
        
    }


    
    void Relogio()
    {
        Contador += Time.deltaTime * VelocidadeDoRelogio;

        if (Contador >= 1)
        {
            SegundoAtual = SegundoAtual + 1;
            Contador = 0;

            if (SegundoAtual >= 600)
            {
                MinutoAtual = MinutoAtual + 1;
                SegundoAtual = 0;

                if (MinutoAtual >= 60)
                {
                    MinutoAtual = 0;
                    HoraAtual = HoraAtual + 1;
                }
            }
        }
    }
}