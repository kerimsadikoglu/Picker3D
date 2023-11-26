
using System.Collections.Generic;
using UnityEngine;

using Runtime.Data.ValuesObjects;

namespace Runtime.Data.UnityObjects
{
    [CreateAssetMenu(fileName = "CD_Level", menuName = "Picker3D/CD_Level", order = 0)]

    public class CD_Level : ScriptableObject
    {
        public List<LevelData> Levels;
    }

}

