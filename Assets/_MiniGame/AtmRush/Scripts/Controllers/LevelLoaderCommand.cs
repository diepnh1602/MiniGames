using UnityEngine;

namespace AtmRush
{
    public class LevelLoaderCommand : MonoBehaviour
    { 
        public void InitializeLevel(int _levelID, Transform levelHolder)
        {
            Instantiate(Resources.Load<GameObject>($"Prefabs/LevelPrefabs/level {_levelID}"), levelHolder);
        }
    }
}
