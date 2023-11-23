using WizardOfLegends.Objects.Weapons;

namespace WizardOfLegends.Objects.UnitTests.WeaponsTests
{
    public class SwordWeaponTests
    {
        private SwordWeapon _sut;

        public SwordWeaponTests()
        {
            _sut = new SwordWeapon();
        }


        [Fact]
        public void SwordWeapon_WhenCreated_ShouldHaveCorrectValues()
        {
            // Arrange
            var expectedName = "Sword";
            var expectedDamage = 10;

            // Act
            var actualName = _sut.Name;
            var actualDamage = _sut.Damage;

            // Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedDamage, actualDamage);
            Assert.False(_sut.IsBroken());
        }

        [Fact]
        public void SwordWeapon_WhenHit_ShouldReturnCorrectDamage()
        {
            // Arrange
            var expectedDamage = 10;

            // Act
            var actualDamage = _sut.Hit(2);

            // Assert
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Check_Durability_Change()
        {
            // Arrange
            var expectedDurability = 100;

            // Act
            _sut.Hit(0);
            var actualDurability = _sut.Durability;

            // Assert
            Assert.Equal(expectedDurability, actualDurability);
        }
    }
}
