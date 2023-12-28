using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class RagdollController : MonoBehaviour
{
    public Animator animator;

    public float transitionSpeed = 1;

    private static readonly int Speed = Animator.StringToHash("Speed");

    [Header("---右腿---")] public bool isRightLegBacking;
    public ConfigurableJoint rightLeg;

    public Vector3 rightLegIdleEuler = new Vector3(0, 0, 0);
    public Vector3 rightLegRunEuler = new Vector3(-90, 0, 0);
    
    [Header("---右膝盖---")]
    public ConfigurableJoint rightKnee;

    public Vector3 rightKneeIdleEuler = new Vector3(0, 0, 0);
    public Vector3 rightKneeUpEuler = new Vector3(0, 0, 0);
    public Vector3 rightKneeRunEuler = new Vector3(-90, 0, 0);
    
    [Header("---左腿---")]public bool isLeftLegBacking;
    public ConfigurableJoint leftLeg;
    public Vector3 leftLegIdleEuler = new Vector3(0, 0, 0);
    public Vector3 leftLegRunEuler = new Vector3(-90, 0, 0);
    
    [Header("---左膝盖---")]
    public ConfigurableJoint leftKnee;

    public Vector3 leftKneeIdleEuler = new Vector3(0, 0, 0);
    public Vector3 leftKneeUpEuler = new Vector3(0, 0, 0);
    public Vector3 leftKneeRunEuler = new Vector3(-90, 0, 0);

    public ConfigurableJoint hip;

    public Vector3 hipIdleEuler;

    public Vector3 hipRunEuler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private bool pressA;
    private bool pressD;
    private bool running;
    
    
    private string rightLegTargetEuler;
    private string rightKneeTargetEuler;
    
    private string leftLegTargetEuler;
    private string leftKneeTargetEuler;

   

    // Update is called once per frame
    void Update()
    {
        running=false;

        pressD = Input.GetKey(KeyCode.D);
        pressA = Input.GetKey(KeyCode.A);
        
        if (pressD)
        {
            rightLeg.targetRotation = Quaternion.Euler(rightLegRunEuler);
            rightKnee.targetRotation = Quaternion.Euler(rightKneeRunEuler);
            running = true;

            //Debug
            rightLegTargetEuler = nameof(rightLegRunEuler);
            rightKneeTargetEuler = nameof(rightKneeRunEuler);
        }
        else
        {
            rightLeg.targetRotation=Quaternion.Euler(rightLegIdleEuler);

            //Debug
            rightLegTargetEuler = nameof(rightLegIdleEuler);
            
            if (!pressA)
            {
                rightKnee.targetRotation = Quaternion.Euler(rightKneeIdleEuler);
                rightKneeTargetEuler = nameof(rightKneeIdleEuler);
            }
            else
            {
                rightKnee.targetRotation=Quaternion.Euler(rightKneeUpEuler);
                rightKneeTargetEuler = nameof(rightKneeUpEuler);
            }
            
           
            
        }
        
        if (pressA)
        {
            leftLeg.targetRotation = Quaternion.Euler(leftLegRunEuler);
            leftKnee.targetRotation = Quaternion.Euler(leftKneeRunEuler);
            running = true;
            
            //Debug
            leftLegTargetEuler = nameof(leftLegRunEuler);
            leftKneeTargetEuler = nameof(leftKneeRunEuler);
        }
        else
        {
            leftLeg.targetRotation=Quaternion.Euler(leftLegIdleEuler);
            leftLegTargetEuler = nameof(leftLegIdleEuler);
            
            if (!pressD)
            {
                leftKnee.targetRotation = Quaternion.Euler(leftKneeIdleEuler);
                leftKneeTargetEuler = nameof(leftKneeIdleEuler);
            }
            else
            {
                leftKnee.targetRotation = Quaternion.Euler(leftKneeUpEuler);
                leftKneeTargetEuler = nameof(leftKneeUpEuler);
            }
            
        }
        
        if(running)
            hip.targetRotation=Quaternion.Euler(hipRunEuler);
        else
        {
            hip.targetRotation=Quaternion.Euler(hipIdleEuler);
        }

    }

    private void OnGUI()
    {
        string ret=rightLegTargetEuler+"\n" + rightKneeTargetEuler + "\n \n" + leftLegTargetEuler + "\n" +
            leftKneeTargetEuler;
        GUI.Label(new Rect(500,500,300,300),ret);
    }
}
