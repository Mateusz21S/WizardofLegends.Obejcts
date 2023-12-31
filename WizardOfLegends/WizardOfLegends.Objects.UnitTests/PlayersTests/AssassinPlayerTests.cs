﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardOfLegends.Objects.Players;

namespace WizardOfLegends.Objects.UnitTests.PlayersTests
{
    public class AssassinPlayerTests
    {
        private AssassinPlayer _sut;

        public AssassinPlayerTests()
        {
            _sut = new AssassinPlayer();
        }

        [Fact]
        public void AddDamage_ValidDamage_ReducedHealth()
        {
            // Arrange
            var expectedHealth = 99;

            // Act
            _sut.AddDamage(1);
            var actualHealth = _sut.Health;

            // Assert
            Assert.Equal(expectedHealth, actualHealth);
        }

        [Fact]
        public void PhysicalAttack_Should_Return_Positive_Damage()
        {
            // Arrange
            var AssassinPlayer = new AssassinPlayer();

            // Act
            var damageDealt = AssassinPlayer.PhysicalAttack();

            // Assert
            Assert.True(damageDealt >= 0, "Damage should not be negative.");
        }

        public static int MagicAttack(string spellName)
        {
            int damage = 10;

            switch (spellName)
            {
                case "Fireball":
                    damage = 10;
                    break;

            }   

            return 0;
        }
    }
}
