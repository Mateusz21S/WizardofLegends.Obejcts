using WizardOfLegends.Objects.Weapons;

namespace WizardOfLegends.Objects.UnitTests.WeaponsTests
{
    public class KnifeWeaponTests
    {
        private KnifeWeapon _sut;

        public KnifeWeaponTests()
        {
            _sut = new KnifeWeapon();
        }


        [Fact]
        public void KnifeWeapon_WhenCreated_ShouldHaveCorrectValues()
        {
            // Arrange
            var expectedName = "Knife";
            var expectedDamage = 1;

            // Act
            var actualName = _sut.Name;
            var actualDamage = _sut.Damage;

            // Assert
            Assert.Equal(expectedName, actualName);
            Assert.Equal(expectedDamage, actualDamage);
            Assert.False(_sut.IsBroken());
        }

        [Fact]
        public void KnifeWeapon_WhenHit_ShouldReturnCorrectDamage()
        {
            // Arrange
            var expectedDamage = 1;

            // Act
            var actualDamage = _sut.Hit(0);

            // Assert
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Check_Durability_Change()
        {
            // Arrange
            var expectedDurability = 120;

            // Act
            _sut.Hit(0);
            var actualDurability = _sut.Durability;

            // Assert
            Assert.Equal(expectedDurability, actualDurability);
        }
    }
}