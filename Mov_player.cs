using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using System.Threading;


public class Mov_player : MonoBehaviour
{
    [SerializeField]
    private AudioSource SomPulo;
    public  Animator    anim;
    private Rigidbody2D rb_player;
    private Transform   heroiT;

    public  bool    face        = true;
    private float   forca       = 5;
    private bool    liberaPulo  = true;
    private bool    vivo        = true;
    private float   vel         = 2.5f;
    private float   vel2        = 5f;

    void Start()
    {
        heroiT      = GetComponent<Transform>();
        rb_player   = GetComponent<Rigidbody2D>();      
    }

    void Update()
    {

        if (vivo == true)
        {
            if (Input.GetKey(KeyCode.D) && !face)
            {
                Flip();
            }

            if (Input.GetKey(KeyCode.A) && face)
            {
                Flip();
            }
        }
        else 
        {
            morte();
        }


        if (vivo == true)
        {

            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(new Vector2(vel2 * Time.deltaTime, 0));

                Correr();

            }
            else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(new Vector2(-vel2 * Time.deltaTime, 0));

                Correr();
            }

            //ANDAR

            else if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKeyDown(KeyCode.Space))
            {
                transform.Translate(new Vector2(vel * Time.deltaTime, 0));

                Andar();
            }

            else if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKeyDown(KeyCode.Space))
            {
                transform.Translate(new Vector2(-vel * Time.deltaTime, 0));
                Andar();

            }

            else if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            {

                anim.SetBool("Idle"     , true);
                anim.SetBool("andando"  , false);
                anim.SetBool("correndo" , false);

            }

            if (Input.GetKeyDown(KeyCode.Space) && liberaPulo == true )
            {                
                anim.SetBool("Idle"     , false);
                anim.SetBool("pulando"  , true);
                anim.SetBool("andando"  , false);
                anim.SetBool("correndo" , false);
                rb_player.AddForce(new Vector2(0, forca * 1.5f), ForceMode2D.Impulse);
                liberaPulo = false;
            }          

            //bate
            if (Input.GetKeyDown(KeyCode.C) )
            {
                bater();
            }
            else if (!Input.GetKeyDown(KeyCode.C) )
            {
                anim.SetBool("batendo", false);
            }

            //Joga Pedrinha
            if (Input.GetKeyDown(KeyCode.E))
            {
                pedra();
            }
            else if (!Input.GetKeyDown(KeyCode.E))
            {
                anim.SetBool("pedra", false);
            }
        } 
    }
    private void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("chao_tag") || outro.gameObject.CompareTag("parede_tag") || outro.gameObject.CompareTag("cogu_tag"))
        {
            liberaPulo = true;
            anim.SetBool("pulando", false);
        }

    }

    void Flip()
    {
        face                = !face;
        Vector3 scala       = heroiT.localScale;
        scala.x             *= -1;
        heroiT.localScale   = scala;
    }

    void Correr()
    {
        anim.SetBool("Idle"     , false);
        anim.SetBool("andando"  , false);
        anim.SetBool("correndo" , true);
    }

    void Andar()
    {
        anim.SetBool("Idle"     , false);
        anim.SetBool("andando"  , true);
        anim.SetBool("correndo" , false);
    }

    void bater()
    {
        anim.SetBool("Idle"     , false);
        anim.SetBool("batendo"  , true);
    }
    void pedra()
    {
        anim.SetBool("Idle", false);
        anim.SetBool("pedra", true);
    }

    void morte()
    {
        anim.SetBool("Idle", false);
        anim.SetBool("vivo", false);
    }


}
