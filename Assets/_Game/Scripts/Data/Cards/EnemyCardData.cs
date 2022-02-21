using Sirenix.OdinInspector;
using UnityEngine;

namespace _Game.Scripts.Data.Cards
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "Cards/Enemy")]
    public class EnemyCardData : CardData
    {
        [Title("Enemy")]
        [SerializeField] private int _health;
        [SerializeField] private int _gold;
        [SerializeField, Range(1, 10)] private int _level;
    }
}
