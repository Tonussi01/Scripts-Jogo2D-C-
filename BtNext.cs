using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtNext : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        if(GameManager.inst.faseAtual == 1)
        {
            SceneManager.LoadScene("Fase 2");
        }
        if (GameManager.inst.faseAtual == 2)
        {
            SceneManager.LoadScene("Fase 3");
        }
        if (GameManager.inst.faseAtual == 3)
        {
            SceneManager.LoadScene("Fase 4");
        }
        if (GameManager.inst.faseAtual == 4)
        {
            SceneManager.LoadScene("Boss");
        }
    }
}
