using System;
//
//
//
using UnityEngine.Events;

namespace AtmRush
{
    public class CoreGameSignals : MonoSingleton<CoreGameSignals>
    {
        public UnityAction<GameStates> onChangeGameState = delegate { };
        public UnityAction<SaveGameDataParams> onSaveGameData = delegate { };
        public UnityAction onLevelInitialize = delegate { };
        public UnityAction onClearActiveLevel = delegate { };
        public UnityAction onLevelFailed = delegate { };
        public UnityAction onLevelSuccessful = delegate { };
        public UnityAction onNextLevel = delegate { };
        public UnityAction onRestartLevel = delegate { };
        public UnityAction onPlay = delegate { };
        public UnityAction onReset = delegate { };

        
        public UnityAction onSetCameraTarget = delegate { };
        public UnityAction<CameraStatesType> onSetCameraState = delegate { };
        public UnityAction onStageAreaReached = delegate { };
        public UnityAction onStageSuccessful = delegate { };
        public UnityAction<int> OnMiniGame =delegate {  }; 

        public Func<int> onGetLevelID = delegate { return 0; };
    }
}
