using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardOfLegends.Objects.Enemies;
using WizardOfLegends.Objects.Players;

namespace WizardOfLegends.Objects
{
    public static class EnemiesFactory
    {
        public static IEnemies BuildEnemies(EnemiesType enemiesType, string name)
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
