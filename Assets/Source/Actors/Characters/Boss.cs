using System;
using UnityEngine;
using DungeonCrawl;

namespace DungeonCrawl.Actors.Characters
{
    public class Boss : Character
    {
        public Boss()
            : base(400)
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
                    TryMove(Direction.Right);
                }

                if (direction == Direction.Down)
                {
                    // Move down
                    TryMove(Direction.Left);
                }

                if (direction == Direction.Left)
                {
                    // Move left
                    TryMove(Direction.Up);
                }

                if (direction == Direction.Right)
                {
                    // Move right
                    TryMove(Direction.Down);
                }

            }
        }
        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {
                this.ApplyDamage(30);
                Player player = (Player)anotherActor;
                if (player.isItem == true)
                {
                    this.ApplyDamage(120);
                }
                player.ApplyDamage(40);
                Debug.Log(this.Health);
            }

            return false;
        }



        protected override void OnDeath()
        {
            Debug.Log("ROOOOOOAAAAAAAARRRRRR");
            
        }

        public override int DefaultSpriteId => 413;
        public override string DefaultName => "Boss";
    }
}
