using System.Collections.Generic;
using UnityEngine;
using Data.ValuesObjects;


namespace Data.UnityObjects
{
    [CreateAssetMenu(fileName = "CD_Input", menuName = "Picker3D/CD_Input", order = 0)]

    public class CD_Input : ScriptableObject
    {
        public InputData Data;
    }

}

