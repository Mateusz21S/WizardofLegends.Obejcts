using WizardOfLegends.Objects.Weapons;

namespace WizardOfLegends.Objects.UnitTests.WeaponsTests;

public class FistWeaponTests{
    private FistWeapon _sut;

    public FistWeaponTests()
    {
        _sut = new FistWeapon();
    }


    [Fact]
    public void FistWeapon_WhenCreated_ShouldHaveCorrectValues() {
        // Arrange
        var expectedName = "Fist";
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
    public void FistWeapon_WhenHit_ShouldReturnCorrectDamage() {
        // Arrange
        var expectedDamage = 1;

        // Act
        var actualDamage = _sut.Hit(0);

        // Assert
        Assert.Equal(expectedDamage, actualDamage);
    }

    [Fact]
    public void Check_Durability_Change() {
        // Arrange
        var expectedDurability = 99;

        // Act
        _sut.Hit(0);
        var actualDurability = _sut.Durability;

        // Assert
        Assert.NotEqual(expectedDurability, actualDurability);
    }
}