using System.Collections.Generic;
//
using UnityEngine;

namespace AtmRush
{
    [CreateAssetMenu(fileName = "CD_Level", menuName = "AtmRush/CD_Level", order = 0)]
    public class CD_Level : ScriptableObject
    {
        public List<LevelData> Levels = new List<LevelData>();
    }
}
