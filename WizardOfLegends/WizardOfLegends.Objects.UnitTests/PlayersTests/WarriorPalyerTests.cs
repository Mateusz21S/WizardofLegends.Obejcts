using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardOfLegends.Objects.Players;

namespace WizardOfLegends.Objects.UnitTests.PlayersTests
{
    public class WarriorPlayerTests
    {
        private WarriorPlayer _sut;

        public WarriorPlayerTests()
        {
            _sut = new WarriorPlayer();
        }

        [Fact]
        public void Add_Dmg_Should_Lower_Health() {
            // Arrange
            var expectedHealth = 99;

            // Act
            _sut.AddDamage(1);
            var actualHealth = _sut.Health;

            // Assert
            Assert.Equal(expectedHealth, actualHealth);
        }
    }
}
