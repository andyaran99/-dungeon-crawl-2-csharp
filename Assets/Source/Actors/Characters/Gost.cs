using System;
using UnityEngine;
using DungeonCrawl;
namespace DungeonCrawl.Actors.Characters
{
    public class Gost : Character
    {
        public Gost()
        : base(25)
        {

        }

        public Direction direction;
        private float time = 0.0f;
        public float interpolationPeriod = 0.8f;

        public override void OnUpdate(float deltaTime, Actor actor)
        {
            time += Time.deltaTime;

            if (time >= interpolationPeriod)
            {
                time = time - interpolationPeriod;

                // execute block of code here

                direction = (Direction)Utilities.PickRandomNumber(0, 4);

                if (direction == Direction.Up)
                {
                    // Move up
                    TryMove(Direction.Up);
                }

                if (direction == Direction.Down)
                {
                    // Move down
                    TryMove(Direction.Down);
                }

                if (direction == Direction.Left)
                {
                    // Move left
                    TryMove(Direction.Left);
                }

                if (direction == Direction.Right)
                {
                    // Move right
                    TryMove(Direction.Right);
                }
            }
        }

        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {
                this.ApplyDamage(25);
                Player player = (Player)anotherActor;
                player.ApplyDamage(25);
                Debug.Log(this.Health);
            }

            return false;
        }



        protected override void OnDeath()
        {
            Debug.Log("BOOO...HOOOOO...HOOOO");
        }

        public override int DefaultSpriteId => 314;
        public override string DefaultName => "Gost";
    }
}