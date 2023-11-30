using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardOfLegends.Objects.Players;

namespace WizardOfLegends.Objects.UnitTests.PlayersTests;

public class WarriorPlayerTests
{
    private WarriorPlayer _sut;

    public WarriorPlayerTests()
    {
        _sut = new WarriorPlayer();
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
        var WarriorPlayer = new WarriorPlayer();

        // Act
        var damageDealt = WarriorPlayer.PhysicalAttack();

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

        throw new NotImplementedException();
    }
}