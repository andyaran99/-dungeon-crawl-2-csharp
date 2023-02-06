using DungeonCrawl.Core;
using DungeonCrawl.Actors.Static;

namespace DungeonCrawl.Actors.Characters
{
    public abstract class Character : Actor
    {
        
        
        protected int health;
        protected int Health
        {
            get { return health; }
            set { health = value; }
        }

        public Character(int health)
        {
            Health=health;
        }

        public void ApplyDamage(int Damage)
        {
            Health -= Damage;
            if (Health <= 0)
            {
                // Die
                OnDeath();

                ActorManager.Singleton.DestroyActor(this);
            }
        }

        public void RestoreLife(int HP)
        {
            Health += HP;
        }

        protected abstract void OnDeath();

        /// <summary>
        ///     All characters are drawn "above" floor etc
        /// </summary>
        public override int Z => -1;
    }
}
