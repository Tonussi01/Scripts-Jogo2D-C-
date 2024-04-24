using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_elevador : MonoBehaviour
{
    public SliderJoint2D slider;
    public JointMotor2D aux;
    public float vel;

    // Start is called before the first frame update
    void Start()
    {
        aux = slider.motor;
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.limitState == JointLimitState2D.LowerLimit)
        {
            aux.motorSpeed = vel;
            slider.motor = aux;
        }
        if (slider.limitState == JointLimitState2D.UpperLimit)
        {
            aux.motorSpeed = -vel;
            slider.motor = aux;
        }
    }
}
