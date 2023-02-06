using System;
using UnityEngine;
using DungeonCrawl;
namespace DungeonCrawl.Actors.Characters
{
    public class Zombie:Character
    {
        public Zombie()
        :base(150)
        {

        }

        
        
        public Direction direction;
        private float time = 0.0f;
        public float interpolationPeriod = 0.6f;

        public override void OnUpdate(float deltaTime,Actor actor)
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
                this.ApplyDamage(30);
                Player player = (Player)anotherActor;
                if (player.isItem == true)
                {
                    this.ApplyDamage(30);
                }
                player.ApplyDamage(15);
                Debug.Log(this.Health);
            }

            return false;
        }



        protected override void OnDeath()
        {
            Debug.Log("NOOOOO...My brain");
        }

        public override int DefaultSpriteId => 222;
        public override string DefaultName => "Zombie";
    }
}
