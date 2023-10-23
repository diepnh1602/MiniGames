using System;
using System.Collections.Generic;

namespace AtmRush
{
    [Serializable]
    public class LevelData
    {
        public List<FinalAtmData> AtmList = new List<FinalAtmData>(3);
    }
}
