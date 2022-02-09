// GENERATED AUTOMATICALLY FROM 'Assets/GameDevHQ/FileBase/Projects/Tutorials/Starter_Files/Input_System_Starter_File/Game/Scripts/Input/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""6968d0ca-356e-4a4f-9be2-4b1c8d9d1ca7"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""47c77a14-ace0-4357-9339-de1f45729f43"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""ff2db2c1-0509-4697-a0af-59fcb6613871"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e4372171-1347-4c85-b55c-109695074bbc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d74dca67-4c56-4663-b11b-64056fbefcf8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eea49031-1ca4-447d-ad88-2fe947d57e38"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d1f94260-abd3-4dba-9765-84a32bdf1580"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""410a7194-a9c5-4f86-81f3-0974117f78bf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0cc39dfb-4adc-4876-bc4d-aa17c61b1dc6"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ed6f5f2b-21d9-479e-a126-1ac8cacd80d9"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""603ca7a6-36b9-413c-bf67-0d2d30c1ca7f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ecb7dcd8-f4ce-4008-bdc6-fbca5bb0fa28"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9afe17d8-fab8-4b45-ab47-73214ad62be6"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3b81d514-73dc-406c-8587-c5cea111417d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drone"",
            ""id"": ""34e64dcf-7fd9-41a3-8f48-a060afdda668"",
            ""actions"": [
                {
                    ""name"": ""HoriMove"",
                    ""type"": ""Value"",
                    ""id"": ""f3ef04a4-3d89-4361-8da1-d45fbd3a4804"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vert"",
                    ""type"": ""Value"",
                    ""id"": ""5c0da6f7-7bba-42f3-b75f-58aa12b78f31"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""Value"",
                    ""id"": ""703204cf-30a2-4b91-8983-720fa26d83ad"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b9465565-29d4-4439-9c2f-a82f50477763"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HoriMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9a709271-8068-491d-8fd8-ec3faa414ad0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HoriMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2e4b2ee7-6b54-453e-a8f5-9677eb830c2f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HoriMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3cefa2e1-adab-4817-941a-d48747b5c1ec"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HoriMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""48307200-e27e-467c-8260-9cb4db3e1e6b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HoriMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""565626a8-a5d1-488d-819d-ec22b45dbdd7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vert"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""626acbe2-5908-4a36-96b7-f62ca1caeca5"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vert"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b45c560f-e807-4a79-abd5-b4789bafe852"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vert"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e1cb496c-503a-47a8-9397-bdd1c1116c5c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""13421c36-df62-4ab9-81ab-f1af78e66bbc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b7d2a6fc-eba0-457c-86fe-88b1a0be0937"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""ForkLift"",
            ""id"": ""43ba9910-4f79-43a4-97e8-f0d37076115a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f7ede573-7d5d-4105-8def-69034379ec94"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lift"",
                    ""type"": ""Button"",
                    ""id"": ""83c3daf9-dc22-4b93-ae2c-049bd81e15a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lower"",
                    ""type"": ""Button"",
                    ""id"": ""4f462175-c782-411b-9201-e169a6ed4999"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9ae50cb8-ea47-47ea-b974-282db536aff8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""123b8ee2-a80c-48bd-b9bc-9a8274edc646"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""063b8eaf-fa7e-4544-8277-87811327e702"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4416cf29-97f0-46e4-84aa-2860e55daeb3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cc6863ba-245f-427a-9789-67d79158e627"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""be8d605e-01df-410a-b659-3e203693410c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""479e9e92-db10-420d-b310-5e1533ee9659"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ec40669b-73f9-47a4-bb19-4b600a43046e"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2f56251-4dd8-4960-86b2-968afb62d9e4"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""68956485-4b5a-412c-aa06-160947fc64a2"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""961a311d-3178-4a9b-bfc1-2984710479b6"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8116f6c-94cf-4b23-8b33-08226a729cea"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""277d102d-593c-4391-aa04-03c3773bb582"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5965dd3a-bf84-44d2-927e-ee393d45f87e"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lower"",
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
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        // Drone
        m_Drone = asset.FindActionMap("Drone", throwIfNotFound: true);
        m_Drone_HoriMove = m_Drone.FindAction("HoriMove", throwIfNotFound: true);
        m_Drone_Vert = m_Drone.FindAction("Vert", throwIfNotFound: true);
        m_Drone_Yaw = m_Drone.FindAction("Yaw", throwIfNotFound: true);
        // ForkLift
        m_ForkLift = asset.FindActionMap("ForkLift", throwIfNotFound: true);
        m_ForkLift_Movement = m_ForkLift.FindAction("Movement", throwIfNotFound: true);
        m_ForkLift_Lift = m_ForkLift.FindAction("Lift", throwIfNotFound: true);
        m_ForkLift_Lower = m_ForkLift.FindAction("Lower", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Interact;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Drone
    private readonly InputActionMap m_Drone;
    private IDroneActions m_DroneActionsCallbackInterface;
    private readonly InputAction m_Drone_HoriMove;
    private readonly InputAction m_Drone_Vert;
    private readonly InputAction m_Drone_Yaw;
    public struct DroneActions
    {
        private @PlayerInputActions m_Wrapper;
        public DroneActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @HoriMove => m_Wrapper.m_Drone_HoriMove;
        public InputAction @Vert => m_Wrapper.m_Drone_Vert;
        public InputAction @Yaw => m_Wrapper.m_Drone_Yaw;
        public InputActionMap Get() { return m_Wrapper.m_Drone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneActions set) { return set.Get(); }
        public void SetCallbacks(IDroneActions instance)
        {
            if (m_Wrapper.m_DroneActionsCallbackInterface != null)
            {
                @HoriMove.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnHoriMove;
                @HoriMove.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnHoriMove;
                @HoriMove.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnHoriMove;
                @Vert.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnVert;
                @Vert.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnVert;
                @Vert.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnVert;
                @Yaw.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnYaw;
                @Yaw.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnYaw;
                @Yaw.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnYaw;
            }
            m_Wrapper.m_DroneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HoriMove.started += instance.OnHoriMove;
                @HoriMove.performed += instance.OnHoriMove;
                @HoriMove.canceled += instance.OnHoriMove;
                @Vert.started += instance.OnVert;
                @Vert.performed += instance.OnVert;
                @Vert.canceled += instance.OnVert;
                @Yaw.started += instance.OnYaw;
                @Yaw.performed += instance.OnYaw;
                @Yaw.canceled += instance.OnYaw;
            }
        }
    }
    public DroneActions @Drone => new DroneActions(this);

    // ForkLift
    private readonly InputActionMap m_ForkLift;
    private IForkLiftActions m_ForkLiftActionsCallbackInterface;
    private readonly InputAction m_ForkLift_Movement;
    private readonly InputAction m_ForkLift_Lift;
    private readonly InputAction m_ForkLift_Lower;
    public struct ForkLiftActions
    {
        private @PlayerInputActions m_Wrapper;
        public ForkLiftActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_ForkLift_Movement;
        public InputAction @Lift => m_Wrapper.m_ForkLift_Lift;
        public InputAction @Lower => m_Wrapper.m_ForkLift_Lower;
        public InputActionMap Get() { return m_Wrapper.m_ForkLift; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ForkLiftActions set) { return set.Get(); }
        public void SetCallbacks(IForkLiftActions instance)
        {
            if (m_Wrapper.m_ForkLiftActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnMovement;
                @Lift.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLift;
                @Lift.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLift;
                @Lift.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLift;
                @Lower.started -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLower;
                @Lower.performed -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLower;
                @Lower.canceled -= m_Wrapper.m_ForkLiftActionsCallbackInterface.OnLower;
            }
            m_Wrapper.m_ForkLiftActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Lift.started += instance.OnLift;
                @Lift.performed += instance.OnLift;
                @Lift.canceled += instance.OnLift;
                @Lower.started += instance.OnLower;
                @Lower.performed += instance.OnLower;
                @Lower.canceled += instance.OnLower;
            }
        }
    }
    public ForkLiftActions @ForkLift => new ForkLiftActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IDroneActions
    {
        void OnHoriMove(InputAction.CallbackContext context);
        void OnVert(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
    }
    public interface IForkLiftActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLift(InputAction.CallbackContext context);
        void OnLower(InputAction.CallbackContext context);
    }
}
