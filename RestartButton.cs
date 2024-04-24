using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Cinemachine;

public class RestartButton : MonoBehaviour
{
    public GameObject player;

    public CinemachineVirtualCamera vCam;

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
        Debug.Log("clicou");
        if (GameManager.inst.ganhou == 2)
        {
            GameObject newplayer = Instantiate(player, GameManager.inst.nasc.position, Quaternion.identity);
            for (int i = 0; i < GameManager.inst.imgCoracao.Length; i++)
            {
                GameManager.inst.imgCoracao[i].enabled = true;
            }

            vCam.m_Follow = newplayer.transform;
            GameManager.inst.vida = 4;
            GameManager.inst.restartou = true;
        }
    }
}

