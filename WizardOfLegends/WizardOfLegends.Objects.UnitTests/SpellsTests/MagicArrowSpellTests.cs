using WizardOfLegends.Objects.Spells;

namespace WizardOfLegends.Objects.UnitTests.SpellsTests;

    public class MagicArrowSpellTests
    {
        private readonly MagicArrowSpell _sut;

        public MagicArrowSpellTests()
        {
            _sut = new MagicArrowSpell();
        }

        [Fact]
        public void MagicArrowSpell_Constructor_SetsCorrectValues()
        {
            // Arrange
            const string expectedName = "Magic Arrow";
            int expectedMagicDamage = 0;

            // Act
            var actualName = _sut.Name;
            var actualMagicDamage = _sut.MagicDamage;

        // Assert
        Assert.Equal(expectedName, actualName);
            Assert.Equal(actualMagicDamage, expectedMagicDamage);
        }

        [Fact]
        public void MagicArrowSpell_Hit_WithZeroPower_ReturnsMinimumDamage()
        {
            // Arrange
            var expectedMagicDamage = 20;

            // Act
            var actualMagicDamage = _sut.Hit(0);

            // Assert
            Assert.Equal(expectedMagicDamage, actualMagicDamage);
        }

        [Fact]
        public void MagicArrowSpell_Hit_WithPositivePower_ReturnsScaledDamage()
        {
            // Arrange
            var power = 20;
            var expectedMagicDamage = 60;

            // Act
            var actualMagicDamage = _sut.Hit(power);

            // Assert
            Assert.Equal(expectedMagicDamage, actualMagicDamage);
        }

        [Fact]
        public void MagicArrowSpell_Hit_MaxPower_ReturnsMaximumDamage()
        {
            // Arrange
            var maxPower = int.MaxValue;
            var expectedMagicDamage = 18;

            // Act
            var actualMagicDamage = _sut.Hit(maxPower);

            // Assert
            Assert.Equal(expectedMagicDamage, actualMagicDamage);
        }
    }



