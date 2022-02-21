// GENERATED AUTOMATICALLY FROM 'Assets/_Game/InputSystem/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerMap"",
            ""id"": ""a3459252-4af8-4304-96d5-6f0ba2f66724"",
            ""actions"": [
                {
                    ""name"": ""Keyboard_MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""73837feb-634b-4ac5-95d1-125f674b034b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Keyboard_MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""bb64f730-fcd3-4522-b1c3-7700694c4d96"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Keyboard_MoveDown"",
                    ""type"": ""Button"",
                    ""id"": ""9b67d156-fe5a-4dbe-abe9-2f4542f028dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Keyboard_MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""374ef7f8-193d-4f3f-a28a-a3d33004d843"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse Click"",
                    ""type"": ""Button"",
                    ""id"": ""8cc7e382-bc1e-42cf-8ee9-5c6ec86297e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""288c5ce1-3ba7-4edf-8775-f146e42497f2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d26f775a-f99d-47ff-86f8-203adb3ac454"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard"",
                    ""action"": ""Keyboard_MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b36102d-bfc5-4921-a75e-0383be6b50ad"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard"",
                    ""action"": ""Keyboard_MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""720bcc5d-8ed8-4642-9250-a8f774e2e8ac"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard"",
                    ""action"": ""Keyboard_MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67bc2c92-d113-46b7-b7a2-e87d235cc712"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard"",
                    ""action"": ""Keyboard_MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30e9db4a-d2a9-44a1-9341-353a0feb5c25"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard"",
                    ""action"": ""Keyboard_MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c860841-0680-468e-a8b9-6f6dbe4291fe"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard"",
                    ""action"": ""Keyboard_MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1df98af2-27db-422e-ae33-4094b5cb832d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard"",
                    ""action"": ""Keyboard_MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b73a17f-2ebe-4024-889f-8e24427aee05"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard"",
                    ""action"": ""Keyboard_MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6170871f-f494-45cd-8419-9ed7fed04b0c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard"",
                    ""action"": ""Mouse Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41c8569e-8077-4d45-a003-c98edb0b4a4c"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse + Keyboard"",
            ""bindingGroup"": ""Mouse + Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerMap
        m_PlayerMap = asset.FindActionMap("PlayerMap", throwIfNotFound: true);
        m_PlayerMap_Keyboard_MoveUp = m_PlayerMap.FindAction("Keyboard_MoveUp", throwIfNotFound: true);
        m_PlayerMap_Keyboard_MoveRight = m_PlayerMap.FindAction("Keyboard_MoveRight", throwIfNotFound: true);
        m_PlayerMap_Keyboard_MoveDown = m_PlayerMap.FindAction("Keyboard_MoveDown", throwIfNotFound: true);
        m_PlayerMap_Keyboard_MoveLeft = m_PlayerMap.FindAction("Keyboard_MoveLeft", throwIfNotFound: true);
        m_PlayerMap_MouseClick = m_PlayerMap.FindAction("Mouse Click", throwIfNotFound: true);
        m_PlayerMap_MousePosition = m_PlayerMap.FindAction("MousePosition", throwIfNotFound: true);
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

    // PlayerMap
    private readonly InputActionMap m_PlayerMap;
    private IPlayerMapActions m_PlayerMapActionsCallbackInterface;
    private readonly InputAction m_PlayerMap_Keyboard_MoveUp;
    private readonly InputAction m_PlayerMap_Keyboard_MoveRight;
    private readonly InputAction m_PlayerMap_Keyboard_MoveDown;
    private readonly InputAction m_PlayerMap_Keyboard_MoveLeft;
    private readonly InputAction m_PlayerMap_MouseClick;
    private readonly InputAction m_PlayerMap_MousePosition;
    public struct PlayerMapActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerMapActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Keyboard_MoveUp => m_Wrapper.m_PlayerMap_Keyboard_MoveUp;
        public InputAction @Keyboard_MoveRight => m_Wrapper.m_PlayerMap_Keyboard_MoveRight;
        public InputAction @Keyboard_MoveDown => m_Wrapper.m_PlayerMap_Keyboard_MoveDown;
        public InputAction @Keyboard_MoveLeft => m_Wrapper.m_PlayerMap_Keyboard_MoveLeft;
        public InputAction @MouseClick => m_Wrapper.m_PlayerMap_MouseClick;
        public InputAction @MousePosition => m_Wrapper.m_PlayerMap_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMapActions instance)
        {
            if (m_Wrapper.m_PlayerMapActionsCallbackInterface != null)
            {
                @Keyboard_MoveUp.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnKeyboard_MoveUp;
                @Keyboard_MoveUp.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnKeyboard_MoveUp;
                @Keyboard_MoveUp.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnKeyboard_MoveUp;
                @Keyboard_MoveRight.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnKeyboard_MoveRight;
                @Keyboard_MoveRight.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnKeyboard_MoveRight;
                @Keyboard_MoveRight.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnKeyboard_MoveRight;
                @Keyboard_MoveDown.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnKeyboard_MoveDown;
                @Keyboard_MoveDown.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnKeyboard_MoveDown;
                @Keyboard_MoveDown.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnKeyboard_MoveDown;
                @Keyboard_MoveLeft.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnKeyboard_MoveLeft;
                @Keyboard_MoveLeft.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnKeyboard_MoveLeft;
                @Keyboard_MoveLeft.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnKeyboard_MoveLeft;
                @MouseClick.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMouseClick;
                @MouseClick.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMouseClick;
                @MouseClick.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMouseClick;
                @MousePosition.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_PlayerMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Keyboard_MoveUp.started += instance.OnKeyboard_MoveUp;
                @Keyboard_MoveUp.performed += instance.OnKeyboard_MoveUp;
                @Keyboard_MoveUp.canceled += instance.OnKeyboard_MoveUp;
                @Keyboard_MoveRight.started += instance.OnKeyboard_MoveRight;
                @Keyboard_MoveRight.performed += instance.OnKeyboard_MoveRight;
                @Keyboard_MoveRight.canceled += instance.OnKeyboard_MoveRight;
                @Keyboard_MoveDown.started += instance.OnKeyboard_MoveDown;
                @Keyboard_MoveDown.performed += instance.OnKeyboard_MoveDown;
                @Keyboard_MoveDown.canceled += instance.OnKeyboard_MoveDown;
                @Keyboard_MoveLeft.started += instance.OnKeyboard_MoveLeft;
                @Keyboard_MoveLeft.performed += instance.OnKeyboard_MoveLeft;
                @Keyboard_MoveLeft.canceled += instance.OnKeyboard_MoveLeft;
                @MouseClick.started += instance.OnMouseClick;
                @MouseClick.performed += instance.OnMouseClick;
                @MouseClick.canceled += instance.OnMouseClick;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public PlayerMapActions @PlayerMap => new PlayerMapActions(this);
    private int m_MouseKeyboardSchemeIndex = -1;
    public InputControlScheme MouseKeyboardScheme
    {
        get
        {
            if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse + Keyboard");
            return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
        }
    }
    public interface IPlayerMapActions
    {
        void OnKeyboard_MoveUp(InputAction.CallbackContext context);
        void OnKeyboard_MoveRight(InputAction.CallbackContext context);
        void OnKeyboard_MoveDown(InputAction.CallbackContext context);
        void OnKeyboard_MoveLeft(InputAction.CallbackContext context);
        void OnMouseClick(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
}
