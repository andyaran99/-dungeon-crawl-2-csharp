using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;
using Assets.Source.Core;

namespace DungeonCrawl.Actors.Static
{
    public class Door : Actor
    {
        public override int DefaultSpriteId => 146;
        public override string DefaultName => "Door";
        public Item key;
        public bool isOpened = false;

        public override bool OnCollision(Actor anotherActor)
        {

            if (anotherActor is Player && DungeonCrawl.Core.GameManager.Singleton.CkeckIfKey())
            {
                UserInterface.Singleton.SetText("Press E to pick up", UserInterface.TextPosition.BottomRight);
                SetSprite(147);
                key = DungeonCrawl.Core.GameManager.Singleton.ReturnKey();
                if (!isOpened)
                {
                    DungeonCrawl.Core.GameManager.Singleton.RemoveItem(key);
                    CameraController.Singleton.Position = (30, -10);
                }
                
                isOpened =true;
                return true;
            }

            if (isOpened)
            {
                return true;
            }

            return false;
        }

    }
}
