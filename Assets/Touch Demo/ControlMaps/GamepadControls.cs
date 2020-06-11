// GENERATED AUTOMATICALLY FROM 'Assets/Touch Demo/ControlMaps/GamepadControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace InputSamples.Controls
{
    public class @GamepadControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GamepadControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GamepadControls"",
    ""maps"": [
        {
            ""name"": ""gameplay"",
            ""id"": ""d037cf2c-5453-4c50-8506-b66efdbbf3e1"",
            ""actions"": [
                {
                    ""name"": ""movement"",
                    ""type"": ""Value"",
                    ""id"": ""dc21bb32-67fb-48db-9646-5dd93115cdf2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""button1Action"",
                    ""type"": ""Button"",
                    ""id"": ""2b9eb09b-8a1c-443e-8c7a-16b3cea62dcf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""button2Action"",
                    ""type"": ""Button"",
                    ""id"": ""69948a22-635b-456f-8308-9700d9c9c1d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a00b2419-b5d5-423f-ac30-ae4d7df7a5fc"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""ea686c37-6bac-4b88-b876-a441b70e299b"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""93f8e940-87f5-4305-bb2b-42dce0f9aa68"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e3b29276-dd63-4303-8f77-64f32e5156ac"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""29d6c791-2321-424c-a8a3-57c9afb87d95"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""273abca6-a19a-47cd-80d4-a4d2440d057c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0177e0b5-bc53-42d0-9af9-6e82dca18b38"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""button1Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c50392dc-0955-4371-b721-7324fd8a05d1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""button1Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ef499da-b8b4-4653-bbab-d294c56a7174"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""button1Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d216d29d-4a44-4ef1-ae05-774a9ae130ba"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""button2Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc0fb5a7-e3f9-4f5f-9dcd-a77a0d06ec39"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""button2Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // gameplay
            m_gameplay = asset.FindActionMap("gameplay", throwIfNotFound: true);
            m_gameplay_movement = m_gameplay.FindAction("movement", throwIfNotFound: true);
            m_gameplay_button1Action = m_gameplay.FindAction("button1Action", throwIfNotFound: true);
            m_gameplay_button2Action = m_gameplay.FindAction("button2Action", throwIfNotFound: true);
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

        // gameplay
        private readonly InputActionMap m_gameplay;
        private IGameplayActions m_GameplayActionsCallbackInterface;
        private readonly InputAction m_gameplay_movement;
        private readonly InputAction m_gameplay_button1Action;
        private readonly InputAction m_gameplay_button2Action;
        public struct GameplayActions
        {
            private @GamepadControls m_Wrapper;
            public GameplayActions(@GamepadControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @movement => m_Wrapper.m_gameplay_movement;
            public InputAction @button1Action => m_Wrapper.m_gameplay_button1Action;
            public InputAction @button2Action => m_Wrapper.m_gameplay_button2Action;
            public InputActionMap Get() { return m_Wrapper.m_gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
            public void SetCallbacks(IGameplayActions instance)
            {
                if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
                {
                    @movement.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                    @movement.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                    @movement.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                    @button1Action.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton1Action;
                    @button1Action.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton1Action;
                    @button1Action.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton1Action;
                    @button2Action.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton2Action;
                    @button2Action.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton2Action;
                    @button2Action.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnButton2Action;
                }
                m_Wrapper.m_GameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @movement.started += instance.OnMovement;
                    @movement.performed += instance.OnMovement;
                    @movement.canceled += instance.OnMovement;
                    @button1Action.started += instance.OnButton1Action;
                    @button1Action.performed += instance.OnButton1Action;
                    @button1Action.canceled += instance.OnButton1Action;
                    @button2Action.started += instance.OnButton2Action;
                    @button2Action.performed += instance.OnButton2Action;
                    @button2Action.canceled += instance.OnButton2Action;
                }
            }
        }
        public GameplayActions @gameplay => new GameplayActions(this);
        public interface IGameplayActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnButton1Action(InputAction.CallbackContext context);
            void OnButton2Action(InputAction.CallbackContext context);
        }
    }
}
