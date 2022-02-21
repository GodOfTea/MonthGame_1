using System;
using _Game.Scripts.Input;
using Gameplay.Map;
using UnityEngine;
using Grid = Gameplay.Map.Grid;

namespace Gameplay.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Settings")] 
        [SerializeField] private float _timeToInfo = 1.5f;

        [Header("Links")] 
        [SerializeField] private Grid _grid;
        [SerializeField] private InputReader _inputReader;

        private Vector2 _touchPosition;
        private Vector2 _swipeDelta;

        private (int, int) _defaultPlayerPosition = (1, 1);

        private Cell _currentCell;

        private float _timer = 0f;

        private bool _isStartTouching = false;

        private void OnEnable()
        {
            _inputReader.OnInputRead += direction => _grid.Renew(direction);
            _inputReader.OnMouseRead += indexes => _grid.Renew(indexes.Item1, indexes.Item2);
        }

        private void OnDisable()
        {
            _inputReader.OnInputRead -= direction => _grid.Renew(direction);
            _inputReader.OnMouseRead -= indexes => _grid.Renew(indexes.Item1, indexes.Item2);

        }
    }
}
