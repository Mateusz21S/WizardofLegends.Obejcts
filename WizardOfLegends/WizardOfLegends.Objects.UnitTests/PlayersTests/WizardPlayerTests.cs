﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardOfLegends.Objects.Players;

namespace WizardOfLegends.Objects.UnitTests.PlayersTests
{
    public class WizardPlayerTests
    {
        private WizardPlayer _sut;

        public WizardPlayerTests()
        {
            _sut = new WizardPlayer();
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
            var WizardPlayer = new WarriorPlayer();

            // Act
            var damageDealt = WizardPlayer.PhysicalAttack();

            // Assert
            Assert.True(damageDealt >= 0, "Damage should not be negative.");
        }
    }
}