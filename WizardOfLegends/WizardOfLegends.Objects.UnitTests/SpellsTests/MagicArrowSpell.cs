using WizardOfLegends.Objects.Spells;

namespace WizardOfLegends.Objects.UnitTests.SpellsTests
{
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
            const string expectedName = "MagicArrow";
            int expectedMagicDamage = 10;

            // Act
            var actualName = _sut.Name;
            var actualMagicDamage = _sut.MagicDamage;

            // Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedMagicDamage);
        }

        [Fact]
        public void MagicArrowSpell_Hit_WithZeroPower_ReturnsMinimumDamage()
        {
            // Arrange
            var expectedMagicDamage = 25;

            // Act
            var actualMagicDamage = _sut.Hit(2);

            // Assert
            Assert.Equal(expectedMagicDamage, actualMagicDamage);
        }

        [Fact]
        public void MagicArrowSpell_Hit_WithPositivePower_ReturnsScaledDamage()
        {
            // Arrange
            var power = 25;
            var expectedMagicDamage = 25;

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
            var expectedMagicDamage = FireBallSpell.MaxDamage;

            // Act
            var actualMagicDamage = _sut.Hit(maxPower);

            // Assert
            Assert.Equal(expectedMagicDamage, actualMagicDamage);
        }
    }
}

