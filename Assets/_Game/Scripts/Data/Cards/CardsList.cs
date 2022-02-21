using System.Collections.Generic;
using Enumerations;
using Sirenix.OdinInspector;
using UnityEngine;

namespace _Game.Scripts.Data.Cards
{
    [CreateAssetMenu(fileName = "CardsList", menuName = "List/Cards")]
    public class CardsList : SerializedScriptableObject
    {
        [SerializeField] private List<EnemyCardData> _enemyes;
        [SerializeField] private List<WeaponCardData> _weapons;
        [SerializeField] private List<BuffCardData> _buffs;
        [SerializeField] private List<DebuffCardData> _debuffs;

        public EnemyCardData TakeRandomEnemy()
        {
            return _enemyes[RandomValue(_enemyes.Count)];
        }

        public WeaponCardData TakeRandomWeapon()
        {
            return _weapons[RandomValue(_weapons.Count)];
        }

        public BuffCardData TakeRandomBuff()
        {
            return _buffs[RandomValue(_buffs.Count)];
        }

        public DebuffCardData TakeRandomDebuff()
        {
            return _debuffs[RandomValue(_debuffs.Count)];
        }

        private int RandomValue(int max) => Random.Range(0, max);
    }
}
