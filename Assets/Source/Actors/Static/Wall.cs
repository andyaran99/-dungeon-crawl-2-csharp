using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DungeonCrawl.Actors.Characters;
using DungeonCrawl.Core;
using Assets.Source.Core;

namespace DungeonCrawl.Actors.Static
{
    public class Wall : Actor
    {
        public override int DefaultSpriteId => 825;
        public override string DefaultName => "Wall";

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
