using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace RollABall
{
    public class SaveDataRepository
    {
        private readonly IData<SavedData> data;
        private const string folderName = "dataSave";
        private const string fileName = "data.bat";
        private readonly string path;

        public SaveDataRepository()
        {
            data = new Json<SavedData>();
            path = Path.Combine(Application.dataPath, folderName);
        }
        public void SavePlayer(PlayerBase player)
        {
            if (!Directory.Exists(Path.Combine(path)))
            {
                Directory.CreateDirectory(path);
            }
            var savePlayer = new SavedData
            {
                Position = player.transform.position,
            };
            data.Save(savePlayer, Path.Combine(path, fileName));
        }

        //public void SaveBonus(bool bonus)
        //{
        //    if (!Directory.Exists(Path.Combine(path)))
        //    {
        //        Directory.CreateDirectory(path);
        //    }
        //    var saveBonus = new SavedData
        //    {
        //        isEnabled = bonus
        //    };
        //    data.Save(saveBonus, Path.Combine(path, fileName));
        //}
        public void LoadPlayer(PlayerBase player)
        {
            var file = Path.Combine(path, fileName);
            if (!File.Exists(file)) return;
            var newPlayer = data.Load(file);
            player.transform.position = newPlayer.Position;
            Debug.Log(newPlayer);
        }
        //public void LoadBonus(bool bonus)
        //{
        //    var file = Path.Combine(path, fileName);
        //    if (!File.Exists(file)) return;
        //    var newBonus = data.Load(file);
        //    bonus.gameObject.SetActive(newBonus.isEnabled);
        //    Debug.Log(newBonus);
        //}
    }
}

