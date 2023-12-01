using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardOfLegends.Objects.Players;
using WizardOfLegends.Objects.Players.Enemies.Enemies;

namespace WizardOfLegends.Objects
{
    public  class EnemiesFactory
    {
        public  IPlayer BuildEnemies(EnemiesType enemiesType, string name)
        {
            switch (enemiesType)
            {
                case EnemiesType.Spider:
                    return new SpiderEnemies(name);
                case EnemiesType.Zombie:
                    return new ZombieEnemies(name);
                case EnemiesType.Skeleton:
                    return new SkeletonEnemies(name);
                default:
                    throw new ArgumentException("Invalid enemy type.", nameof(enemiesType));
            }
        }
    }

    public enum EnemiesType
    {
        Spider,
        Zombie,
        Skeleton
    }
}
