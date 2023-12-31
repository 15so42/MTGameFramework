//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/GameMain/Configs/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""a9c65d35-4126-46ba-b8a6-5dd586d70e38"",
            ""actions"": [
                {
                    ""name"": ""RightLeg"",
                    ""type"": ""Button"",
                    ""id"": ""82ab67cd-dd8c-4bf7-af72-0190ff271265"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftLeg"",
                    ""type"": ""Button"",
                    ""id"": ""a8b16f9c-ca62-4a96-b082-a080efd81082"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HipRotate"",
                    ""type"": ""Value"",
                    ""id"": ""39fbc8b0-25f8-44d6-8e2d-3825dcbe5c01"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MouseLeft"",
                    ""type"": ""Button"",
                    ""id"": ""b787fcbd-55b7-4750-8ec4-fc5569863395"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseRight"",
                    ""type"": ""Button"",
                    ""id"": ""4b5677eb-ed98-4c2d-b33a-35543b8299de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""15d01ab7-93bb-4010-831e-a5af015d3edd"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightLeg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2df63868-37a4-4f3c-be77-e2352eb387bf"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightLeg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0ea988a-b585-4a4b-9c4d-a04484c4cc37"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftLeg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9acfda31-d69a-4628-ab86-0cae9416ae12"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftLeg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17128e42-1507-4ac6-889b-945069eff3ba"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HipRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fd3865b5-1352-4ad1-91fc-3c9fe2827bda"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HipRotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""93fc03be-1438-40ce-9ebb-5153ce9b4703"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HipRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a9a4745e-380a-45b8-8c32-eb376323c40c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HipRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""81eb386e-2ede-487d-83f5-76ddff29089b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HipRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""95996417-49e1-42ed-9a32-905359d2645c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HipRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dbe8b05b-1d7a-451b-aa22-f65550dde3b1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8fea99e-9a2b-4f56-89f2-06dd30e674ef"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_RightLeg = m_Player.FindAction("RightLeg", throwIfNotFound: true);
        m_Player_LeftLeg = m_Player.FindAction("LeftLeg", throwIfNotFound: true);
        m_Player_HipRotate = m_Player.FindAction("HipRotate", throwIfNotFound: true);
        m_Player_MouseLeft = m_Player.FindAction("MouseLeft", throwIfNotFound: true);
        m_Player_MouseRight = m_Player.FindAction("MouseRight", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_RightLeg;
    private readonly InputAction m_Player_LeftLeg;
    private readonly InputAction m_Player_HipRotate;
    private readonly InputAction m_Player_MouseLeft;
    private readonly InputAction m_Player_MouseRight;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @RightLeg => m_Wrapper.m_Player_RightLeg;
        public InputAction @LeftLeg => m_Wrapper.m_Player_LeftLeg;
        public InputAction @HipRotate => m_Wrapper.m_Player_HipRotate;
        public InputAction @MouseLeft => m_Wrapper.m_Player_MouseLeft;
        public InputAction @MouseRight => m_Wrapper.m_Player_MouseRight;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @RightLeg.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightLeg;
                @RightLeg.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightLeg;
                @RightLeg.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightLeg;
                @LeftLeg.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftLeg;
                @LeftLeg.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftLeg;
                @LeftLeg.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftLeg;
                @HipRotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHipRotate;
                @HipRotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHipRotate;
                @HipRotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHipRotate;
                @MouseLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseLeft;
                @MouseLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseLeft;
                @MouseLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseLeft;
                @MouseRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseRight;
                @MouseRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseRight;
                @MouseRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouseRight;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RightLeg.started += instance.OnRightLeg;
                @RightLeg.performed += instance.OnRightLeg;
                @RightLeg.canceled += instance.OnRightLeg;
                @LeftLeg.started += instance.OnLeftLeg;
                @LeftLeg.performed += instance.OnLeftLeg;
                @LeftLeg.canceled += instance.OnLeftLeg;
                @HipRotate.started += instance.OnHipRotate;
                @HipRotate.performed += instance.OnHipRotate;
                @HipRotate.canceled += instance.OnHipRotate;
                @MouseLeft.started += instance.OnMouseLeft;
                @MouseLeft.performed += instance.OnMouseLeft;
                @MouseLeft.canceled += instance.OnMouseLeft;
                @MouseRight.started += instance.OnMouseRight;
                @MouseRight.performed += instance.OnMouseRight;
                @MouseRight.canceled += instance.OnMouseRight;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnRightLeg(InputAction.CallbackContext context);
        void OnLeftLeg(InputAction.CallbackContext context);
        void OnHipRotate(InputAction.CallbackContext context);
        void OnMouseLeft(InputAction.CallbackContext context);
        void OnMouseRight(InputAction.CallbackContext context);
    }
}
