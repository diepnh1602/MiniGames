//
using UnityEngine;

namespace AtmRush
{
    [CreateAssetMenu(fileName = "CD_Collectable", menuName = "AtmRush/CD_Collectable", order = 0)]
    public class CD_Collectable : ScriptableObject
    {
        public CollectableData CollectableData;
    }
}
