using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleta : MonoBehaviour
{
    [SerializeField]
    private GameObject SomColeta;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("carne_tag"))

        {
            GameManager.inst.carne++;
            Destroy(col.gameObject);
            Instantiate(SomColeta, transform.position, Quaternion.identity);
        }

        if (col.gameObject.CompareTag("trofeu_tag"))

        {
            Destroy(col.gameObject);
            GameManager.inst.ganhou = 1;
        }

        if (col.gameObject.CompareTag("maca_tag"))

        {
            Destroy(col.gameObject);
            if (GameManager.inst.vida != 4)
            {
                GameManager.inst.imgCoracao[GameManager.inst.vida].enabled = true;
                GameManager.inst.vida++;
            }
        }

        if (col.gameObject.CompareTag("lava_tag"))

        {            
               GameManager.inst.ganhou = 2;            
        }
        if (col.gameObject.CompareTag("trol_tag"))

        {
           
        }

    }
}
