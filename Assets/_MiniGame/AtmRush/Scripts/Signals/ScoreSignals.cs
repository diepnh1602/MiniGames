//
using UnityEngine.Events;

namespace AtmRush
{
    public class ScoreSignals : MonoSingleton<ScoreSignals>
    {
        public UnityAction<int> onScoreDown = delegate{  };
    }
}
