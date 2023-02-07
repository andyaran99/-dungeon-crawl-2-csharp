using UnityEngine;
using UnityEngine.UI;
using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Static;
using System.Collections.Generic;
using System;

namespace DungeonCrawl.Core
{
    /// <summary>
    ///     Loads the initial map and can be used for keeping some important game variables
    /// </summary>
    public class GameManager : MonoBehaviour
    {

        public static GameManager Singleton { get; private set; }

        public void Awake()
        {
            if (Singleton == null)
            {
                Singleton = this;
            }
            else
            {
                if (Singleton != this)
                {
                    Destroy(gameObject);
                }
            }

            DontDestroyOnLoad(gameObject);
        }

        private void Start()
        {
            MapLoader.LoadMap(1);
            Inventory.Singleton.DisplayItems();
        }

       
    }
}
