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
                    ""name"": ""VertMove"",
                    ""type"": ""Button"",
                    ""id"": ""591c001e-fcc3-46b7-bee8-c69bc2005597"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Thrust"",
                    ""type"": ""Button"",
                    ""id"": ""1d353454-b44e-40d8-8188-c15832710677"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5e4633e9-8c73-47b1-8dd5-394312e914b6"",
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
                    ""id"": ""3dda32d2-9a26-482e-9f68-ab2aa3bf0cd3"",
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
                    ""id"": ""2bf3d7dd-5c16-4ed9-9eb3-ee8002e6bdef"",
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
                    ""id"": ""f1bd2700-d682-4f25-b21b-f1800a772f9b"",
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
                    ""id"": ""0675524a-edf6-439b-9b56-0be69aac72d6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HoriMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""02e4dd85-b6a3-4678-8e7f-b0a30c3b8586"",
                    ""path"": ""<Keyboard>/leftAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VertMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a614e74-bb78-4bc9-baa3-8cdc170fda1e"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VertMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68ad6af7-4c6d-4efb-953a-b2baa69e29ca"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
                    ""id"": ""277d102d-593c-4391-aa04-03c3773bb582"",
                    ""path"": ""<Keyboard>/t"",
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
        m_Drone_VertMove = m_Drone.FindAction("VertMove", throwIfNotFound: true);
        m_Drone_Thrust = m_Drone.FindAction("Thrust", throwIfNotFound: true);
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
    private readonly InputAction m_Drone_VertMove;
    private readonly InputAction m_Drone_Thrust;
    public struct DroneActions
    {
        private @PlayerInputActions m_Wrapper;
        public DroneActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @HoriMove => m_Wrapper.m_Drone_HoriMove;
        public InputAction @VertMove => m_Wrapper.m_Drone_VertMove;
        public InputAction @Thrust => m_Wrapper.m_Drone_Thrust;
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
                @VertMove.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnVertMove;
                @VertMove.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnVertMove;
                @VertMove.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnVertMove;
                @Thrust.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnThrust;
                @Thrust.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnThrust;
                @Thrust.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnThrust;
            }
            m_Wrapper.m_DroneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HoriMove.started += instance.OnHoriMove;
                @HoriMove.performed += instance.OnHoriMove;
                @HoriMove.canceled += instance.OnHoriMove;
                @VertMove.started += instance.OnVertMove;
                @VertMove.performed += instance.OnVertMove;
                @VertMove.canceled += instance.OnVertMove;
                @Thrust.started += instance.OnThrust;
                @Thrust.performed += instance.OnThrust;
                @Thrust.canceled += instance.OnThrust;
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
        void OnVertMove(InputAction.CallbackContext context);
        void OnThrust(InputAction.CallbackContext context);
    }
    public interface IForkLiftActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLift(InputAction.CallbackContext context);
        void OnLower(InputAction.CallbackContext context);
    }
}
