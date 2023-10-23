using System;
using System.Collections.Generic;
//

namespace AtmRush
{
    [Serializable]
    public class CollectableData
    {
        public CollectableType CollectableType = CollectableType.Money;
        public List<CollectableParticleData> CollectableParticleSpriteList;
    }
}
