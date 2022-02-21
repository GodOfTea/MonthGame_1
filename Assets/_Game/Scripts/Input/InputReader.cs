using System;
using Enumerations;
using Gameplay.Map;
using UnityEngine;

namespace _Game.Scripts.Input
{
    public class InputReader : MonoBehaviour
    {
        public Action<MoveDirection> OnInputRead;
        public Action<(int, int)> OnMouseRead;
     
        [SerializeField] private Camera _mainCamera;
        
        private PlayerInput _input;

        private void Awake()
        {
            _input = new PlayerInput();
        }

        private void OnEnable()
        {
            /* Set Actions */
            _input.PlayerMap.Keyboard_MoveUp.performed += context => OnInputRead?.Invoke(MoveDirection.Up);
            _input.PlayerMap.Keyboard_MoveRight.performed += context => OnInputRead?.Invoke(MoveDirection.Right);
            _input.PlayerMap.Keyboard_MoveDown.performed += context => OnInputRead?.Invoke(MoveDirection.Down);
            _input.PlayerMap.Keyboard_MoveLeft.performed += context => OnInputRead?.Invoke(MoveDirection.Left);
            _input.PlayerMap.MouseClick.performed += context => OnMouseRead?.Invoke(GetClickedCellDirection());
            
            _input.Enable();
        }

        private void OnDisable()
        {
            _input.Disable();
        }

        private (int, int) GetClickedCellDirection()
        {
            Vector2 mousePosition = _input.PlayerMap.MousePosition.ReadValue<Vector2>();
            
            Ray ray = _mainCamera.ScreenPointToRay(mousePosition);
            
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.TryGetComponent(out Cell cell))
                {
                    return (cell.WidthIndex, cell.HeightIndex);
                }
            }

            return (0, 0);
        }
    }
}
