// GENERATED AUTOMATICALLY FROM 'Assets/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""PlayerOneControls"",
            ""id"": ""85b836a0-78ba-4c95-b7ab-5935f1ba1e98"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7b00e02c-3b63-479f-bad0-1d551098aa09"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""f53a2bcb-bcf9-4bc5-b0dd-0ef446bca0af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""edc28849-be05-48a9-8c30-d07ec8a4c6de"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""867a79cc-6f7e-41cb-8d4e-79640a17db1d"",
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
                    ""id"": ""15493925-ee40-4fc1-95f3-e54c6b098174"",
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
                    ""id"": ""54ff6576-c289-47fd-ac2c-a6ee38b7e222"",
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
                    ""id"": ""1f62760f-37c2-457e-83a4-75be5d3357db"",
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
                    ""id"": ""a3c346ab-758f-4a0b-ab2d-f0a51c4ed354"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""799c8320-3599-4427-b315-698cad7efab2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerTwoControls"",
            ""id"": ""b95f5f54-60d8-4a37-85e5-455a88f8881c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2a09d84c-34d4-4a38-95f6-cbaff1bc4539"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""0dfc305d-e60c-4721-a910-8918429cd520"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""232313df-9011-4c7c-bf65-a5b2f58ad3ac"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""ccd2ee8c-ea4c-49f8-b894-83b8ea1edef5"",
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
                    ""id"": ""366a42ea-3938-4a47-b9d6-39ebf0cfbd1b"",
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
                    ""id"": ""9f48f6f3-9c94-4103-b967-6f3d84415992"",
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
                    ""id"": ""a195f14c-b05c-4a0c-9e7f-9807f646131d"",
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
                    ""id"": ""e2001f7a-a797-4715-b754-0b12b5ace23e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ade29ec4-0b7f-4236-afad-74b0fb115aa8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerOneControls
        m_PlayerOneControls = asset.FindActionMap("PlayerOneControls", throwIfNotFound: true);
        m_PlayerOneControls_Move = m_PlayerOneControls.FindAction("Move", throwIfNotFound: true);
        m_PlayerOneControls_Attack = m_PlayerOneControls.FindAction("Attack", throwIfNotFound: true);
        // PlayerTwoControls
        m_PlayerTwoControls = asset.FindActionMap("PlayerTwoControls", throwIfNotFound: true);
        m_PlayerTwoControls_Move = m_PlayerTwoControls.FindAction("Move", throwIfNotFound: true);
        m_PlayerTwoControls_Attack = m_PlayerTwoControls.FindAction("Attack", throwIfNotFound: true);
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

    // PlayerOneControls
    private readonly InputActionMap m_PlayerOneControls;
    private IPlayerOneControlsActions m_PlayerOneControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerOneControls_Move;
    private readonly InputAction m_PlayerOneControls_Attack;
    public struct PlayerOneControlsActions
    {
        private @InputManager m_Wrapper;
        public PlayerOneControlsActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerOneControls_Move;
        public InputAction @Attack => m_Wrapper.m_PlayerOneControls_Attack;
        public InputActionMap Get() { return m_Wrapper.m_PlayerOneControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerOneControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerOneControlsActions instance)
        {
            if (m_Wrapper.m_PlayerOneControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnMove;
                @Attack.started -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_PlayerOneControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public PlayerOneControlsActions @PlayerOneControls => new PlayerOneControlsActions(this);

    // PlayerTwoControls
    private readonly InputActionMap m_PlayerTwoControls;
    private IPlayerTwoControlsActions m_PlayerTwoControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerTwoControls_Move;
    private readonly InputAction m_PlayerTwoControls_Attack;
    public struct PlayerTwoControlsActions
    {
        private @InputManager m_Wrapper;
        public PlayerTwoControlsActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerTwoControls_Move;
        public InputAction @Attack => m_Wrapper.m_PlayerTwoControls_Attack;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTwoControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTwoControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerTwoControlsActions instance)
        {
            if (m_Wrapper.m_PlayerTwoControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerTwoControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerTwoControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerTwoControlsActionsCallbackInterface.OnMove;
                @Attack.started -= m_Wrapper.m_PlayerTwoControlsActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerTwoControlsActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerTwoControlsActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_PlayerTwoControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public PlayerTwoControlsActions @PlayerTwoControls => new PlayerTwoControlsActions(this);
    public interface IPlayerOneControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface IPlayerTwoControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}
