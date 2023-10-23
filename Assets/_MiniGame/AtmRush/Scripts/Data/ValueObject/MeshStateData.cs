using System;


namespace AtmRush
{
    [Serializable]
    public class MeshStateData
    { public enum MeshTypes 
        { 
            MoneyFilter,
            GoldFilter,
            DiamondFilter
        }
        public MeshTypes meshType=MeshTypes.MoneyFilter;
    }
}
