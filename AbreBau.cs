using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreBau : MonoBehaviour
{
    public Animator anim;
    public GameObject carnes;
    public Transform spawncarne;

    void Start()
    {
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
                anim.SetBool("aberto", true);
                GameObject carnesbonus = Instantiate(carnes, spawncarne.position, Quaternion.identity);
            }
        }

    }
}
