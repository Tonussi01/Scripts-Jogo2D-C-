using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D rb_player;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.CompareTag("passaro_tag"))
        {
            foreach (ContactPoint2D hitPos in col.contacts)
            {
                if (hitPos.normal.y > 0 && hitPos.normal.y >= Mathf.Abs(hitPos.normal.x))
                {
                    rb_player.AddForce(Vector2.up * 2, ForceMode2D.Impulse);
                    Destroy(col.gameObject);
                }
                else
                {
                    rb_player.AddForce(new Vector2(hitPos.normal.x * 2, hitPos.normal.y * 2), ForceMode2D.Impulse);
                    if (GameManager.inst.vida > 0)
                    {
                        GameManager.inst.vida--;
                        GameManager.inst.imgCoracao[GameManager.inst.vida].enabled = false;
                    }
                    if (GameManager.inst.vida <= 0)
                    {
                        Destroy(gameObject);
                        GameManager.inst.ganhou = 2;
                    }
                }
            }
        }

        if (col.gameObject.CompareTag("caixaEsp_tag") || col.gameObject.CompareTag("lamina_tag") || col.gameObject.CompareTag("faca_tag") || col.gameObject.CompareTag("bomba_tag") || col.gameObject.CompareTag("flecha_tag"))
        {

            rb_player.AddForce(new Vector2(2, 2), ForceMode2D.Impulse);
            if (GameManager.inst.vida > 0)
            {
                GameManager.inst.vida--;
                GameManager.inst.imgCoracao[GameManager.inst.vida].enabled = false;
            }
            if (GameManager.inst.vida <= 0)
            {
                Destroy(gameObject);
                GameManager.inst.ganhou = 2;
            }
        }


        if (col.gameObject.CompareTag("cogu_tag"))

        {
            foreach (ContactPoint2D hitPos in col.contacts)
            {
                if (hitPos.normal.y > 0 && hitPos.normal.y >= Mathf.Abs(hitPos.normal.x))
                {
                    rb_player.AddForce(Vector2.up * 2.5f, ForceMode2D.Impulse);
                }
            }
        }


        if (col.gameObject.CompareTag("lava_tag"))

        {
            GameManager.inst.ganhou = 2;
            Destroy(gameObject);
        }


        if (col.gameObject.CompareTag("trofeu_tag"))

        {
            Destroy(gameObject);
            GameManager.inst.ganhou = 1;
        }

        if (col.gameObject.CompareTag("abelha_tag"))
        {
            {
                rb_player.AddForce(new Vector2(2, 2), ForceMode2D.Impulse);
                if (GameManager.inst.vida > 0)
                {
                    GameManager.inst.vida--;
                    GameManager.inst.imgCoracao[GameManager.inst.vida].enabled = false;
                }
                if (GameManager.inst.vida <= 0)
                {
                    Destroy(gameObject);
                    GameManager.inst.ganhou = 2;
                }
            }
        }
    }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("fase1"))

            {
                GameManager.inst.faseAtual = 1;
            }
            if (collision.gameObject.CompareTag("fase2"))

            {
                GameManager.inst.faseAtual = 2;
            }
            if (collision.gameObject.CompareTag("fase3"))

            {
                GameManager.inst.faseAtual = 3;
            }
            if (collision.gameObject.CompareTag("fase4"))

            {
                GameManager.inst.faseAtual = 4;
            }
            if (collision.gameObject.CompareTag("fase5"))

            {
                GameManager.inst.faseAtual = 5;
            }
        }
    
}
