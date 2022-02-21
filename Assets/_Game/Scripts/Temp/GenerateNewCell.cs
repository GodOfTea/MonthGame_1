using Gameplay.Map;
using UnityEngine;

namespace Temp
{
    public class GenerateNewCell : MonoBehaviour
    {
        [SerializeField] private Material[] _colors;
        [SerializeField] private Cell _prefab;

        public Cell Generate(Cell cell)
        {
            Cell newCell = cell;
            cell.MeshRenderer.material = _colors[Random.Range(0, _colors.Length)];

            return newCell;
        }
    }
}
