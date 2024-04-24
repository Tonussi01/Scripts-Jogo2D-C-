using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtRestartWin : MonoBehaviour
{
    public GameObject player;

    public CinemachineVirtualCamera vCam;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        if (GameManager.inst.ganhou == 1)
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
