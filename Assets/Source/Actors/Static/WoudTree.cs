using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;
using Assets.Source.Core;
namespace DungeonCrawl.Actors.Static
{
    public class WoudTree : Actor
    {
        public override int DefaultSpriteId => 52;
        public override string DefaultName => "Tree";

        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Gost)
            {
                return true;
            }
            // All actors are passable by default
            return false;
        }
    }
}
