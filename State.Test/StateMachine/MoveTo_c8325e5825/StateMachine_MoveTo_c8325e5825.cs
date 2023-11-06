using NUnit.Framework;
using Moq;
using System.Collections.Generic;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateMachine_MoveTo_c8325e5825
    {
        private FiniteStateMachine _finiteStateMachine;
        private Mock<FiniteStateChangeEventArgs> _stateChangeEventArgsMock;

        [SetUp]
        public void SetUp()
        {
            _finiteStateMachine = new FiniteStateMachine();
            _stateChangeEventArgsMock = new Mock<FiniteStateChangeEventArgs>();
        }

        [Test]
        public void MoveTo_StateExist_ReturnsTargetStateKey()
        {
            // Arrange
            var targetStateKey = "S1";
            _finiteStateMachine.AddState(targetStateKey, new State(targetStateKey));

            // Act
            var stateKey = _finiteStateMachine.MoveTo(targetStateKey, _stateChangeEventArgsMock.Object);

            // Assert
            Assert.AreEqual(targetStateKey, stateKey);
        }

        [Test]
        public void MoveTo_StateNotExist_ThrowsException()
        {
            // Arrange
            var targetStateKey = "S2";

            // Act & Assert
            var ex = Assert.Throws<Exception>(() => _finiteStateMachine.MoveTo(targetStateKey, _stateChangeEventArgsMock.Object));
            Assert.That(ex.Message, Is.EqualTo("[FiniteStateMachine::MoveTo()] -> Target state did not exist. Please add the State for key: '" + targetStateKey + "'"));
        }
    }
}
