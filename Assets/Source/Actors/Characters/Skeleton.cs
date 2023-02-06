using UnityEngine;

namespace DungeonCrawl.Actors.Characters
{
    public class Skeleton : Character
    {

        public Skeleton()
            : base(100)
        {
            
        }

        public override bool OnCollision(Actor anotherActor)
        {
            if (anotherActor is Player)
            {

                this.ApplyDamage(25);
                Player player = (Player)anotherActor;
                if (player.isItem)
                {
                    this.ApplyDamage(50);
                }
                player.ApplyDamage(10);
                Debug.Log(this.Health);
            }
            
            return false;
        }



        protected override void OnDeath()
        {
            Debug.Log("Well, I was already dead anyway...");
        }

        public override int DefaultSpriteId => 316;
        public override string DefaultName => "Skeleton";
    }
}
