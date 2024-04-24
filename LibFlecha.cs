using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibFlecha : MonoBehaviour
{
    public  GameObject flecha;
    private Transform local;
    private float controla = 2;
    private int segundoAnt = 0;
    public  int Timer ;
    void Start()
    {
        local = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float seg = GameManager.inst.segundo_real;
        while (GameManager.inst.segundo_real > segundoAnt)
        {
            segundoAnt = GameManager.inst.segundo_real;
            if ((seg % Timer == 0) && controla == 2)
            {
                controla = 1;
                GameObject flechanova = Instantiate(flecha, local.position, local.rotation);
            }
        }
        controla = 2;
        if (GameManager.inst.segundo_real == 0 && (GameManager.inst.MinutoAtual == 1 || GameManager.inst.MinutoAtual == 2 || GameManager.inst.MinutoAtual == 3 || GameManager.inst.MinutoAtual == 4))
        {
            segundoAnt = 0;
        }
    }
}
