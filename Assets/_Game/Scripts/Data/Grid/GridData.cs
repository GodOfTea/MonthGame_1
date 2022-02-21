using System.Collections.Generic;
using Enumerations;
using Sirenix.OdinInspector;
using UnityEngine;

namespace _Game.Scripts.Data.Grid
{
    [CreateAssetMenu(fileName = "GridData", menuName = "Data/GridData")]
    public class GridData : SerializedScriptableObject
    {
        [Tooltip("Key: MoveDirection. Value: Grid direction to move")] 
        [SerializeField, ReadOnly] private Dictionary<MoveDirection, (int, int)> _gridMoveDirection = new Dictionary<MoveDirection, (int, int)>()
        {
            {MoveDirection.Left, (-1, 0)},
            {MoveDirection.Up, (0, -1)},
            {MoveDirection.Right, (1, 0)},
            {MoveDirection.Down, (0, 1)},
        };
        
        [Tooltip("Key: Width and Height cell. Value: MoveDirection")] 
        [SerializeField, ReadOnly] private Dictionary<(int, int), MoveDirection> _possibleMoveCell = new Dictionary<(int, int), MoveDirection>()
        {
            {(1, 0), MoveDirection.Up},
            {(0, 1), MoveDirection.Left},
            {(2, 1), MoveDirection.Right},
            {(1, 2), MoveDirection.Down},
            
            {(0, 0), MoveDirection.None},
            {(2, 0), MoveDirection.None},
            {(1, 1), MoveDirection.None},
            {(0, 2), MoveDirection.None},
            {(2, 2), MoveDirection.None}
        };

        public (int, int) GetGridMoveDirectionValue(MoveDirection direction)
        {
            return _gridMoveDirection[direction];
        }

        public MoveDirection GetPossibleDirectionToMove((int, int) indexes)
        {
            return _possibleMoveCell[indexes];
        }
    }
}
