using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class RagdollController : MonoBehaviour
{
    public Animator animator;

    public float transitionSpeed = 1;

    private static readonly int Speed = Animator.StringToHash("Speed");

    [Header("---右腿---")] 
    public ConfigurableJoint rightLeg;

    public Vector3 rightLegIdleEuler = new Vector3(0, 0, 0);
    public Vector3 rightLegRunEuler = new Vector3(-90, 0, 0);
    
    [Header("---右膝盖---")]
    public ConfigurableJoint rightKnee;

    public Vector3 rightKneeIdleEuler = new Vector3(0, 0, 0);
    public Vector3 rightKneeUpEuler = new Vector3(0, 0, 0);
    public Vector3 rightKneeRunEuler = new Vector3(-90, 0, 0);
    
    [Header("---左腿---")]
    public ConfigurableJoint leftLeg;
    public Vector3 leftLegIdleEuler = new Vector3(0, 0, 0);
    public Vector3 leftLegRunEuler = new Vector3(-90, 0, 0);
    
    [Header("---左膝盖---")]
    public ConfigurableJoint leftKnee;

    public Vector3 leftKneeIdleEuler = new Vector3(0, 0, 0);
    public Vector3 leftKneeUpEuler = new Vector3(0, 0, 0);
    public Vector3 leftKneeRunEuler = new Vector3(-90, 0, 0);

    [FormerlySerializedAs("hip")] public ConfigurableJoint spine;
    public Vector2 rotateXLimit;
    public float scrollMultiplier = 0.1f;
    
    // public Vector3 hipIdleEuler;
    //
    // public Vector3 hipRunEuler;

    
    //value
    [Header("修改以设置初始值")]
    private float hipEulerX=-3;
    
    private PlayerInputActions playerInputActions;
    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        
        
    }

    void OnRightLegStarted(InputAction.CallbackContext context)
    {
        pressD = true;
    }
    
    void OnRightLegCanceled(InputAction.CallbackContext context)
    {
        pressD = false;
    }
    
    void OnLeftLegStarted(InputAction.CallbackContext context)
    {
        pressA = true;
    }
    
    void OnLeftLegCanceled(InputAction.CallbackContext context)
    {
        pressA = false;
    }

    
    
    // void OnHipRotateByScroll(InputAction.CallbackContext context)
    // {
    //     var value = context.ReadValue<Vector2>().y;
    //     Debug.Log(value);
    //     hipEulerX += value;
    // }
    
    // void OnHipRotateByAxis(InputAction.CallbackContext context)
    // {
    //     var value = context.ReadValue<float>();
    //     Debug.Log(value);
    //     hipEulerX += value;
    // }
    private void OnEnable()
    {
        playerInputActions.Player.RightLeg.started += OnRightLegStarted;
        playerInputActions.Player.RightLeg.canceled += OnRightLegCanceled;
        playerInputActions.Player.LeftLeg.started += OnLeftLegStarted;
        playerInputActions.Player.LeftLeg.canceled += OnLeftLegCanceled;

       // playerInputActions.Player.HipRotateMouse.performed += OnHipRotateByScroll;
        
        
        
        
        playerInputActions.Enable();
    }

    private void OnDisable()
    {
        
        playerInputActions.Player.RightLeg.started -= OnRightLegStarted;
        playerInputActions.Player.RightLeg.canceled -= OnRightLegCanceled;
        playerInputActions.Player.LeftLeg.started -= OnLeftLegStarted;
        playerInputActions.Player.LeftLeg.canceled -= OnLeftLegCanceled;

        //playerInputActions.Player.HipRotateMouse.performed -= OnHipRotateByScroll;
       
        
        playerInputActions.Disable();
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

        // pressD = Input.GetKey(KeyCode.D);
        // pressA = Input.GetKey(KeyCode.A);
        
        var hipRotateAction = playerInputActions.Player.HipRotate;
        var hipRotateAxisValue = hipRotateAction.ReadValue<Vector2>().y;
        // 获取触发动作的控件
        var control = hipRotateAction.activeControl;

        if (control != null)
        {
            if (control.device is Mouse)
            {
                // 如果是鼠标，处理鼠标滚轮
                hipEulerX += hipRotateAxisValue*scrollMultiplier;
            }
            else if (control.device is Keyboard)
            {
                // 如果是键盘，处理键盘按键
                hipEulerX += hipRotateAxisValue; // 或者你可以有不同的处理逻辑
            }
        }

        hipEulerX = Mathf.Clamp(hipEulerX, rotateXLimit.x, rotateXLimit.y);
        spine.targetRotation=Quaternion.Euler(new Vector3(hipEulerX,0,0));
        
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
        
        // if(running)
        //     hip.targetRotation=Quaternion.Euler(hipRunEuler);
        // else
        // {
        //     hip.targetRotation=Quaternion.Euler(hipIdleEuler);
        // }
        
       

    }

    private void OnGUI()
    {
        string ret=rightLegTargetEuler+"\n" + rightKneeTargetEuler + "\n \n" + leftLegTargetEuler + "\n" +
            leftKneeTargetEuler;
        GUI.Label(new Rect(500,500,300,300),ret);
    }
}
