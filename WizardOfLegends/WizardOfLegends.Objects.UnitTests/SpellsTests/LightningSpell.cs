﻿using WizardOfLegends.Objects.Spells;

namespace WizardOfLegends.Objects.UnitTests.SpellsTests
{
    public class LightningSpellTests
    {
        private readonly LightningSpell _sut;

        public LightningSpellTests()
        {
            _sut = new LightningSpell();
        }

        [Fact]
        public void LightningSpell_Constructor_SetsCorrectValues()
        {
            // Arrange
            const string expectedName = "Lightning";
            int expectedMagicDamage = 35;

            // Act
            var actualName = _sut.Name;
            var actualMagicDamage = _sut.MagicDamage;

            // Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedMagicDamage);
        }

        [Fact]
        public void LightningSpell_Hit_WithZeroPower_ReturnsMinimumDamage()
        {
            // Arrange
            var expectedMagicDamage = 35;

            // Act
            var actualMagicDamage = _sut.Hit(2);

            // Assert
            Assert.Equal(expectedMagicDamage, actualMagicDamage);
        }

        [Fact]
        public void LightningSpell_Hit_WithPositivePower_ReturnsScaledDamage()
        {
            // Arrange
            var power = 35;
            var expectedMagicDamage = 35;

            // Act
            var actualMagicDamage = _sut.Hit(power);

            // Assert
            Assert.Equal(expectedMagicDamage, actualMagicDamage);
        }

        [Fact]
        public void LIghtningSpell_Hit_MaxPower_ReturnsMaximumDamage()
        {
            // Arrange
            var maxPower = int.MaxValue;
            var expectedMagicDamage = LightningSpell.MaxDamage;

            // Act
            var actualMagicDamage = _sut.Hit(maxPower);

            // Assert
            Assert.Equal(expectedMagicDamage, actualMagicDamage);
        }
    }
}

