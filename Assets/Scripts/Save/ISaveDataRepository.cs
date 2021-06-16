using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public interface ISaveDataRepository
    {
        void Save(PlayerBase player, InteractiveObject bonus);
        void Load(PlayerBase player, InteractiveObject bonus);
    }
}
