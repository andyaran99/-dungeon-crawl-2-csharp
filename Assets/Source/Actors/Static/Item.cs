using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Static;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;



namespace DungeonCrawl.Actors.Static
{
    
    public class Item : Actor
    {
        public override int DefaultSpriteId => 1;
        public override string DefaultName => "Item";

        
        public override bool OnCollision(Actor anotherActor)
        {
            // All actors are passable by default
            return true;
        }

    }

}



