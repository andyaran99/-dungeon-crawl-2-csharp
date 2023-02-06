using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;
using Assets.Source.Core;

namespace DungeonCrawl.Actors.Static
{
    public class Item_Potion : Item
    {
        public override int DefaultSpriteId => 521;
        public override string DefaultName => "HP potion";

        public override void OnUpdate(float deltaTime, Actor actor)
        {
            if (Input.GetKeyDown(KeyCode.E) && OnCollision(actor))
            {
                //DungeonCrawl.Core.GameManager.Singleton.AddItem(this);
                Player player = (Player)actor;
                player.RestoreLife(25);
                UserInterface.Singleton.SetText("Life was restored!", UserInterface.TextPosition.BottomRight);
                SetSprite(0);
                
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                DungeonCrawl.Core.GameManager.Singleton.RemoveItem(this);
            }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {
                UserInterface.Singleton.SetText("Press E to pick up", UserInterface.TextPosition.BottomRight);
                return true;
            }

            return false;
        }

        
        
    }   
       
    
}
    

