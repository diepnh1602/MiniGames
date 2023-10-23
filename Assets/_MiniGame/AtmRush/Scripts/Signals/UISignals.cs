//
//
using UnityEngine.Events;

namespace AtmRush
{
    public class UISignals : MonoSingleton<UISignals>
    {
        public UnityAction<UIPanels> onOpenPanel;
        public UnityAction<UIPanels> onClosePanel;
        public UnityAction<int> onUpdateStageData;
        public UnityAction<int> onSetLevelText;
    }
}
