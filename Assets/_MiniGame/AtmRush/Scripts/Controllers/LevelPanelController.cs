using TMPro;
using UnityEngine;

namespace AtmRush
{
    public class LevelPanelController : MonoBehaviour
    {
        #region Self Variables

        #region Public Variables

        #endregion

        #region Serialized Variables

        [SerializeField] private TextMeshProUGUI levelText;

        #endregion

        #region Private Variables

        #endregion

        #endregion
        public void SetLevelText(int value)
        {
            levelText.text = "Level :" + (value + 1).ToString();
        }
    }
}
