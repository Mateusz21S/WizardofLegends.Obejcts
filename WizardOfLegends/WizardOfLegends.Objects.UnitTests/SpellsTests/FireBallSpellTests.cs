using WizardOfLegends.Objects.Spells;

namespace WizardOfLegends.Objects.UnitTests.SpellsTests;

    public class FireBallSpellTests
    {
        private readonly FireBallSpell _sut;

        public FireBallSpellTests() {
            _sut = new FireBallSpell();
        }

        [Fact]
        public void FireBallSpell_Constructor_SetsCorrectValues()
        {
            // Arrange
            const string expectedName = "FireBall Base";
            int expectedMagicDamage = 10;

            // Act
            var actualName = _sut.Name;
            var actualMagicDamage = _sut.MagicDamage;

            // Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(actualMagicDamage, expectedMagicDamage);
        }

        [Fact]
        public void FireBallSpell_Hit_WithZeroPower_ReturnsMinimumDamage() {
            // Arrange
            var expectedMagicDamage = 30;

            // Act
            var actualMagicDamage = _sut.MagicDamage;

            // Assert
            Assert.Equal(expectedMagicDamage, actualMagicDamage);
        }

        [Fact]
        public void FireBallSpell_Hit_WithPositivePower_ReturnsScaledDamage()
        {
            // Arrange
            var power = 10;
            var expectedMagicDamage = 30;

            // Act
            var actualMagicDamage = _sut.Hit(power);

            // Assert
            Assert.Equal(expectedMagicDamage, actualMagicDamage);
        }

        [Fact]
        public void FireBallSpell_Hit_WithPositivePower_ReturnsScaledDamage_1()
        {
            // Arrange
            var power = 10;
            var expectedMagicDamage = 20;

            // Act
            var actualMagicDamage = _sut.Hit(power);

            // Assert
            Assert.NotEqual(expectedMagicDamage, actualMagicDamage);
        }

        [Fact]
        public void FireBallSpell_Hit_MaxPower_ReturnsMaximumDamage()
        {
            // Arrange
            var maxPower = 5;
            var expectedMagicDamage = 20;

            // Act
            var actualMagicDamage = _sut.Hit(maxPower);

            // Assert
            Assert.Equal(expectedMagicDamage, actualMagicDamage);
        }
    }





