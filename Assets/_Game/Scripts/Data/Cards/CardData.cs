using Enumerations;
using Sirenix.OdinInspector;
using UnityEngine;

namespace _Game.Scripts.Data.Cards
{
    public class CardData : SerializedScriptableObject
    {
        [Title("General")]
        [SerializeField] private string _id;
        [SerializeField] private string _name;
        [SerializeField] private string _description;

        [SerializeField] private CardType _cardType;
        
        /* Добавить данные по модельке */
    }
}
