// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControl/PlayerInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAction"",
    ""maps"": [
        {
            ""name"": ""PlayerR"",
            ""id"": ""d1e4e811-6fd0-4b5c-bb30-91d3167c4e1c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7bdcb711-061c-4c35-a94d-28b4c9495052"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootDir"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5f121f89-1342-4cd6-a016-50339cfc1b1a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""5751895b-626d-4175-bdb9-bc58e8f7042e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""33de5263-2ef8-48b8-8771-7dc907b6b6b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""752b7cf2-4ffb-4f15-869a-0e05d825bdfd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""35a297b6-417d-4ed6-a392-5beafe0e381c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""17f00e48-05e4-46b3-92d1-ee7095c954b0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b21da1b5-e6da-442f-be72-0c469afacd0f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7b68f1c9-1ac5-4798-b35e-22d2f1c6ed6a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""fc17f768-f038-47aa-b3b4-c2befe4950fb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootDir"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4859d9c6-ef31-4da5-bb07-db6e20acfc00"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""77335156-9ef9-45d1-a23d-2ed8d57b508a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ababd741-51c8-418c-89ac-a09ac9f46c7d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d6dd668f-1050-42de-82c4-a77194ab43c7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fb3aa286-0757-498a-954f-41a5a8cf3c80"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33118b63-292f-4d85-8d7c-c090df490d5f"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerL"",
            ""id"": ""55fe1684-bab1-4460-bc64-dae122d5285c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1e84c253-2f18-466d-a6ad-5404c9bd6ab5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootDir"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dc21dab9-718e-4744-9ba5-b36558a7a1c0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""3c2438e3-1501-4a3a-aef4-67852ebff1a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""08aa6c80-b401-400e-a11b-9440a960e161"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1eb226f0-5a96-459e-adae-4c875557db1b"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""ece33384-4668-48d9-8b23-7db3237a19cf"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d991da4c-e0c1-4fdc-b56a-5b82740f30d8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""132d8d23-8f4e-41ea-8e66-54c76870d3be"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cf2203b4-2438-49e4-a9a0-2781bd8ef6af"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""395efeca-50f5-4725-bac8-2b81d28a3e1b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""9d8636d4-a91c-49c5-a38e-f1498e6a0791"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootDir"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f9b5d088-719a-43ca-aee0-ca274de985c5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e570cf34-fbef-4dfd-a4c2-a0d9aa53e018"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5d4b3ca4-ee4c-41fa-9d58-8fc5b35bbec4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c5633996-a957-42bc-9504-46611863b021"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootDir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3fec8f2c-2e23-4816-86a5-f149b164345f"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameControls"",
            ""id"": ""0ca5c296-3dd4-4e19-b5f4-81b2db5a74e0"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""83b838d7-d43e-43de-a6be-a8f8a17ca51a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""01974fac-fb0a-47b6-8ea7-46406eeafe09"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerR
        m_PlayerR = asset.FindActionMap("PlayerR", throwIfNotFound: true);
        m_PlayerR_Move = m_PlayerR.FindAction("Move", throwIfNotFound: true);
        m_PlayerR_ShootDir = m_PlayerR.FindAction("ShootDir", throwIfNotFound: true);
        m_PlayerR_Shoot = m_PlayerR.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerR_Dash = m_PlayerR.FindAction("Dash", throwIfNotFound: true);
        // PlayerL
        m_PlayerL = asset.FindActionMap("PlayerL", throwIfNotFound: true);
        m_PlayerL_Move = m_PlayerL.FindAction("Move", throwIfNotFound: true);
        m_PlayerL_ShootDir = m_PlayerL.FindAction("ShootDir", throwIfNotFound: true);
        m_PlayerL_Shoot = m_PlayerL.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerL_Dash = m_PlayerL.FindAction("Dash", throwIfNotFound: true);
        // GameControls
        m_GameControls = asset.FindActionMap("GameControls", throwIfNotFound: true);
        m_GameControls_Pause = m_GameControls.FindAction("Pause", throwIfNotFound: true);
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

    // PlayerR
    private readonly InputActionMap m_PlayerR;
    private IPlayerRActions m_PlayerRActionsCallbackInterface;
    private readonly InputAction m_PlayerR_Move;
    private readonly InputAction m_PlayerR_ShootDir;
    private readonly InputAction m_PlayerR_Shoot;
    private readonly InputAction m_PlayerR_Dash;
    public struct PlayerRActions
    {
        private @PlayerInputAction m_Wrapper;
        public PlayerRActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerR_Move;
        public InputAction @ShootDir => m_Wrapper.m_PlayerR_ShootDir;
        public InputAction @Shoot => m_Wrapper.m_PlayerR_Shoot;
        public InputAction @Dash => m_Wrapper.m_PlayerR_Dash;
        public InputActionMap Get() { return m_Wrapper.m_PlayerR; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerRActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerRActions instance)
        {
            if (m_Wrapper.m_PlayerRActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerRActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerRActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerRActionsCallbackInterface.OnMove;
                @ShootDir.started -= m_Wrapper.m_PlayerRActionsCallbackInterface.OnShootDir;
                @ShootDir.performed -= m_Wrapper.m_PlayerRActionsCallbackInterface.OnShootDir;
                @ShootDir.canceled -= m_Wrapper.m_PlayerRActionsCallbackInterface.OnShootDir;
                @Shoot.started -= m_Wrapper.m_PlayerRActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerRActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerRActionsCallbackInterface.OnShoot;
                @Dash.started -= m_Wrapper.m_PlayerRActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerRActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerRActionsCallbackInterface.OnDash;
            }
            m_Wrapper.m_PlayerRActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @ShootDir.started += instance.OnShootDir;
                @ShootDir.performed += instance.OnShootDir;
                @ShootDir.canceled += instance.OnShootDir;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
            }
        }
    }
    public PlayerRActions @PlayerR => new PlayerRActions(this);

    // PlayerL
    private readonly InputActionMap m_PlayerL;
    private IPlayerLActions m_PlayerLActionsCallbackInterface;
    private readonly InputAction m_PlayerL_Move;
    private readonly InputAction m_PlayerL_ShootDir;
    private readonly InputAction m_PlayerL_Shoot;
    private readonly InputAction m_PlayerL_Dash;
    public struct PlayerLActions
    {
        private @PlayerInputAction m_Wrapper;
        public PlayerLActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerL_Move;
        public InputAction @ShootDir => m_Wrapper.m_PlayerL_ShootDir;
        public InputAction @Shoot => m_Wrapper.m_PlayerL_Shoot;
        public InputAction @Dash => m_Wrapper.m_PlayerL_Dash;
        public InputActionMap Get() { return m_Wrapper.m_PlayerL; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerLActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerLActions instance)
        {
            if (m_Wrapper.m_PlayerLActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerLActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerLActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerLActionsCallbackInterface.OnMove;
                @ShootDir.started -= m_Wrapper.m_PlayerLActionsCallbackInterface.OnShootDir;
                @ShootDir.performed -= m_Wrapper.m_PlayerLActionsCallbackInterface.OnShootDir;
                @ShootDir.canceled -= m_Wrapper.m_PlayerLActionsCallbackInterface.OnShootDir;
                @Shoot.started -= m_Wrapper.m_PlayerLActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerLActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerLActionsCallbackInterface.OnShoot;
                @Dash.started -= m_Wrapper.m_PlayerLActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerLActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerLActionsCallbackInterface.OnDash;
            }
            m_Wrapper.m_PlayerLActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @ShootDir.started += instance.OnShootDir;
                @ShootDir.performed += instance.OnShootDir;
                @ShootDir.canceled += instance.OnShootDir;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
            }
        }
    }
    public PlayerLActions @PlayerL => new PlayerLActions(this);

    // GameControls
    private readonly InputActionMap m_GameControls;
    private IGameControlsActions m_GameControlsActionsCallbackInterface;
    private readonly InputAction m_GameControls_Pause;
    public struct GameControlsActions
    {
        private @PlayerInputAction m_Wrapper;
        public GameControlsActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_GameControls_Pause;
        public InputActionMap Get() { return m_Wrapper.m_GameControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGameControlsActions instance)
        {
            if (m_Wrapper.m_GameControlsActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GameControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public GameControlsActions @GameControls => new GameControlsActions(this);
    public interface IPlayerRActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShootDir(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
    public interface IPlayerLActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShootDir(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
    public interface IGameControlsActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
}
