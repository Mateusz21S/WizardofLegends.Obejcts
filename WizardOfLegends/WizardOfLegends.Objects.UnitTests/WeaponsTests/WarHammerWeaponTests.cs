using WizardOfLegends.Objects.Weapons;

namespace WizardOfLegends.Objects.UnitTests.WeaponsTests
{
    public class WarHammerWeaponTests
    {
        private WarHammerWeapon _sut;

        public WarHammerWeaponTests()
        {
            _sut = new WarHammerWeapon();
        }


        [Fact]
        public void WarHammerWeapon_WhenCreated_ShouldHaveCorrectValues()
        {
            // Arrange
            var expectedName = "War Hammer";
            var expectedDamage = 20;

            // Act
            var actualName = _sut.Name;
            var actualDamage = _sut.Damage;

            // Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedDamage, actualDamage);
            Assert.False(_sut.IsBroken());
        }

        [Fact]
        public void WarHammerWeapon_WhenHit_ShouldReturnCorrectDamage()
        {
            // Arrange
            var expectedDamage = 20;

            // Act
            var actualDamage = _sut.Hit(0);

            // Assert
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Check_Durability_Change()
        {
            // Arrange
            var expectedDurability = 99;

            // Act
            _sut.Hit(0);
            var actualDurability = _sut.Durability;

            // Assert
            Assert.Equal(expectedDurability, actualDurability);
        }
    }
}
