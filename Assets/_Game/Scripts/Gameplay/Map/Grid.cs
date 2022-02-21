using System;
using System.Collections.Generic;
using _Game.Scripts.Data;
using _Game.Scripts.Data.Grid;
using Enumerations;
using Sirenix.OdinInspector;
using Temp;
using UnityEngine;

namespace Gameplay.Map
{
    public class Grid : SerializedMonoBehaviour
    {
        private const int ROWS = 3;
        private const int COLUMNS = 3;

        [Title("Links")] 
        [SerializeField] private GenerateNewCell _generateNewCell;
        
        [Title("Grid")]
        [SerializeField] private Cell[,] _grid = new Cell[3,3];

        [Title("Data")]
        [SerializeField] private GridData _gridData;

        private void Awake()
        { 
            Init();   
        }

        private void Init()
        {
            int cellId = 0;
            
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    _grid[i,j].Init(cellId++, i, j);    
                }
            }
        }

        /* For keyboard */
        public void Renew(MoveDirection variant) 
        {
            UpdateGrid(variant);
        }
        
        /* For mouse */
        public void Renew(int widthIndex, int heightIndex) 
        {
            MoveDirection variant = _gridData.GetPossibleDirectionToMove((widthIndex, heightIndex));
            
            if (variant == MoveDirection.None)
                return;
            
            Renew(variant);
        }

        private void UpdateGrid(MoveDirection variant)
        {
            if (variant == MoveDirection.Left || variant == MoveDirection.Right)
                HorizontalShift(_gridData.GetGridMoveDirectionValue(variant).Item1);
            else
                VerticalShift(_gridData.GetGridMoveDirectionValue(variant).Item2);
        }

        /* Left || Right */ /* i */
        private void HorizontalShift(int index)
        {
            int iStart = 1;
            int jStart = 0;
            
            int iTo = CalculateTo(index);
            int iFrom = CalculateFrom(index);

            for (int j = jStart; j < ROWS; j++)
            {
                _grid[iTo, j].UpdateData(_grid[iStart, j]);
                _grid[iStart, j].UpdateData(_grid[iFrom, j]);
                _grid[iFrom, j] = _generateNewCell.Generate(_grid[iFrom, j]);
            }
        }

        /* Up || Down */ /* j */
        private void VerticalShift(int index)
        {
            int iStart = 0;
            int jStart = 1;
            
            int jTo = CalculateTo(index);
            int jFrom = CalculateFrom(index);
            
            for (int i = iStart; i < ROWS; i++)
            {
                _grid[i, jTo].UpdateData(_grid[i, jStart]);
                _grid[i, jStart].UpdateData(_grid[i, jFrom]);
                _grid[i, jFrom] = _generateNewCell.Generate(_grid[i, jFrom]);
            }
        }

        private int CalculateTo(int value) => 1 - value;
        private int CalculateFrom(int value) => 1 + value;
    }
}
