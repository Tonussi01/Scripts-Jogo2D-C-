using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Plataforma : MonoBehaviour
{
    private float z;
    public float velocidade;
    
    public int movimento;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        z = transform.rotation.z;
        //Debug.Log(z);

        if (movimento == 0)
        {
           transform.Rotate(0, 0, velocidade * Time.deltaTime, Space.World);
        }

        if (z >= 0.300f)
        {
            movimento = 1;
        }
        if (z <= -0.300f)
        {
            movimento = 0;
        }
         
        if (movimento == 1)
        {
            transform.Rotate(0,0,-velocidade * Time.deltaTime, Space.World);
        }
    }
}
