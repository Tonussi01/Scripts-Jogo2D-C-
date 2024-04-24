using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_passar : MonoBehaviour
{
    public SliderJoint2D slider;
    public JointMotor2D aux;
    public float vel;
    public Animator anima;


    void Start()
    {
        aux = slider.motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.limitState == JointLimitState2D.LowerLimit)
        {
            aux.motorSpeed  = vel;
            slider.motor    = aux;
            anima.SetInteger("direcao", 1);
        }
        if (slider.limitState == JointLimitState2D.UpperLimit)
        {
            aux.motorSpeed  = -vel;
            slider.motor    = aux;
            anima.SetInteger("direcao", 3);
        }               
    }


}
