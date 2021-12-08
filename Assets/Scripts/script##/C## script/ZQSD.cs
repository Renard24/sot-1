// GENERATED AUTOMATICALLY FROM 'Assets/ZQSD.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ZQSD : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ZQSD()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ZQSD"",
    ""maps"": [
        {
            ""name"": ""PlayerSolo"",
            ""id"": ""251fbfd2-dac6-477f-ab3b-6e9f465bb772"",
            ""actions"": [
                {
                    ""name"": ""Mouv"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8c740860-e8c2-4359-be90-a7832e7b1fea"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ZQSD"",
                    ""id"": ""fb511657-800e-4fe2-a541-826faf0e45f1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouv"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""47a8d4f3-a87d-42a6-be4e-51a6afb6eace"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouv"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""240ee58c-3cea-47ba-bde7-2bccf7328776"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouv"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""53d8e26d-70a0-4222-bc66-3748e9c066e4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouv"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2db0a64a-c9b5-4c7d-9c45-ca4ffd54632f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouv"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player1"",
            ""id"": ""0ebbe748-c5e6-4899-9355-7a35759510a0"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""3dcbc0f0-6bb6-40b6-acd8-a40985b18b37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0a2336a0-a0e9-4ad2-a767-2845422dd944"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerSolo
        m_PlayerSolo = asset.FindActionMap("PlayerSolo", throwIfNotFound: true);
        m_PlayerSolo_Mouv = m_PlayerSolo.FindAction("Mouv", throwIfNotFound: true);
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Newaction = m_Player1.FindAction("New action", throwIfNotFound: true);
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

    // PlayerSolo
    private readonly InputActionMap m_PlayerSolo;
    private IPlayerSoloActions m_PlayerSoloActionsCallbackInterface;
    private readonly InputAction m_PlayerSolo_Mouv;
    public struct PlayerSoloActions
    {
        private @ZQSD m_Wrapper;
        public PlayerSoloActions(@ZQSD wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mouv => m_Wrapper.m_PlayerSolo_Mouv;
        public InputActionMap Get() { return m_Wrapper.m_PlayerSolo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerSoloActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerSoloActions instance)
        {
            if (m_Wrapper.m_PlayerSoloActionsCallbackInterface != null)
            {
                @Mouv.started -= m_Wrapper.m_PlayerSoloActionsCallbackInterface.OnMouv;
                @Mouv.performed -= m_Wrapper.m_PlayerSoloActionsCallbackInterface.OnMouv;
                @Mouv.canceled -= m_Wrapper.m_PlayerSoloActionsCallbackInterface.OnMouv;
            }
            m_Wrapper.m_PlayerSoloActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mouv.started += instance.OnMouv;
                @Mouv.performed += instance.OnMouv;
                @Mouv.canceled += instance.OnMouv;
            }
        }
    }
    public PlayerSoloActions @PlayerSolo => new PlayerSoloActions(this);

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Newaction;
    public struct Player1Actions
    {
        private @ZQSD m_Wrapper;
        public Player1Actions(@ZQSD wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Player1_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);
    public interface IPlayerSoloActions
    {
        void OnMouv(InputAction.CallbackContext context);
    }
    public interface IPlayer1Actions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
