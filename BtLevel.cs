using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtLevel : MonoBehaviour
{
    public Text levelTxtBTN;
    public int desbloqueadoBtn;
    private Button bt;
    void Start()
    {
        bt = GetComponent<Button>();
    }
    public void Click()
    {
       

        if (bt.name == "BtMapa1")
        {
            SceneManager.LoadScene("Fase 1");
        }

        if (bt.name == "BtMapa2")
        {
            SceneManager.LoadScene("Fase 2");
        }

        if (bt.name == "BtMapa3")
        {
            SceneManager.LoadScene("Fase 3");
        }

        if (bt.name == "BtMapa4")
        {
            SceneManager.LoadScene("Fase 4");
        }

        if (bt.name == "BtMapa5")
        {
            SceneManager.LoadScene("Boss");
        }
    }
}
