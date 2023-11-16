
using UnityEngine;


namespace Commands.Level
{
    public class OnLevelLoaderCommand
    {
        private Transform _levelHolder;

        internal OnLevelLoaderCommand(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }

        internal void Execute(byte levelIndex)
        {
           var levelObject = Object.Instantiate(Resources.Load<GameObject>($"Prefabs/LevelPrefabs/level {levelIndex}"));
            levelObject.transform.SetParent(_levelHolder);
           
        }

    }
}

