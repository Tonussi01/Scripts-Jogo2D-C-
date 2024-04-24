using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_abelha : MonoBehaviour
{

    private Transform abelha;
    public bool face = false;
    public SliderJoint2D slider;
    public JointMotor2D aux;
    public float vel;

    void Start()
    {
        abelha = GetComponent<Transform>();
        aux = slider.motor;
    }

    void Update()
    {
        if (slider.limitState == JointLimitState2D.LowerLimit)
        {
            aux.motorSpeed = vel;
            slider.motor   = aux;
            Flip();
        }
        if (slider.limitState == JointLimitState2D.UpperLimit)
        {
            aux.motorSpeed = -vel;
            slider.motor = aux;
            Flip();
        }
    }

    void Flip()
    {
        face = !face;
        Vector3 scala = abelha.localScale;
        scala.x *= -1;
        abelha.localScale = scala;
    }

}
