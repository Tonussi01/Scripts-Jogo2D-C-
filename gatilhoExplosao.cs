using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatilhoExplosao : MonoBehaviour
{
    public Animator anim;
    public Collider2D col;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("chao_tag"))
        {
            
        }
        else
        {
            anim.SetBool("explode", true);
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            col.isTrigger = true;
            Destroy(gameObject,1);
        }
    }
}
