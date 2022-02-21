using System;
using _Game.Scripts.Data.Cards;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Gameplay.Map
{
    public class Cell : MonoBehaviour
    {
        [SerializeField, ReadOnly] private int _id;
        [SerializeField, ReadOnly] private int _widthIndex;
        [SerializeField, ReadOnly] private int _heightIndex;

        [Title("Data")]
        [SerializeField] private CardData _cardData;
        
        /* Temp */
        [SerializeField] private MeshRenderer _meshRenderer;
        public MeshRenderer MeshRenderer => _meshRenderer;
        
        public int WidthIndex => _widthIndex;
        public int HeightIndex => _heightIndex;

        private void Start()
        {
            _meshRenderer = GetComponent<MeshRenderer>();
        }

        public void Init(int id, int widthIndex, int heightIndex)
        {
            _id = id;
            _widthIndex = widthIndex;
            _heightIndex = heightIndex;
        }

        public void UpdateData(Cell cell)
        {
            _meshRenderer.material = cell.MeshRenderer.material;
        }
    }
}
