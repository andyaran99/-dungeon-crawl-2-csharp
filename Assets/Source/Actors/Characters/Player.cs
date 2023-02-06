using UnityEngine;
using DungeonCrawl.Core;
using Assets.Source.Core;
using System;

namespace DungeonCrawl.Actors.Characters
{
    public class Player : Character
    {

        public Player()
        :base(200)
        {

        }

        //public bool hadMooved=false;
        public bool isItem = false;
        public override void OnUpdate(float deltaTime,Actor actor)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                // Move up
                TryMove(Direction.Up);
                Debug.Log(this.Health);
                //hadMooved=true;
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                // Move down
                TryMove(Direction.Down);
                Debug.Log(this.Health);
               // hadMooved=true;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                // Move left
                TryMove(Direction.Left);
                Debug.Log(this.Health);
                //hadMooved=true;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                // Move right
                TryMove(Direction.Right);
                Debug.Log(this.Health);
                //hadMooved=true;
            }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            return true;
        }

        protected override void OnDeath()
        {
            Debug.Log("Oh no, I'm dead!");
        }

        public override int DefaultSpriteId => 24;
        public override string DefaultName => "Player";
    }
}
