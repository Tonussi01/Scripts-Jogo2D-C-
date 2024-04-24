using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alavanca : MonoBehaviour
{
    public Animator anim;
    public Animator animPlat;
    public Transform plat;
    
    void Start()
    {
        anim.SetBool("status", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay2D(Collider2D outro)
    {        
        if (outro.gameObject.CompareTag("Player") || outro.gameObject.CompareTag("arma_tag"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {                
                anim.SetBool("status",true);

                animPlat.SetBool("Ativada", true);
            }
        }

    }
}
