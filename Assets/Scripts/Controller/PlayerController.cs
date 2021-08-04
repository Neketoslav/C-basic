using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public sealed class PlayerController: IExecute
    {
        private readonly PlayerBase playerBase;
        private readonly SaveDataRepository saveDataRepository;
        private readonly KeyCode savePlayer = KeyCode.C;
        private readonly KeyCode loadPlayer = KeyCode.V;

        private PlayerBall playerBall;
        public PlayerBall PlayerBall
        {
            get
            {
                if (playerBall == null)
                {
                    var gameObject = Resources.Load<PlayerBall>("Player");
                    playerBall = Object.Instantiate(gameObject);
                }
                return playerBall;
            }
        }
        public PlayerController(PlayerBase player)
        {
            playerBase = player;
            saveDataRepository = new SaveDataRepository();
        }

        public void Execute()
        {
            playerBase.Move(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            if (Input.GetKeyDown(savePlayer))
            {
                saveDataRepository.SavePlayer(playerBase);
            }
            if (Input.GetKeyDown(loadPlayer))
            {
                saveDataRepository.LoadPlayer(playerBase);
            }
        }
    }

}