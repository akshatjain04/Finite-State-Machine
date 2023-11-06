using NUnit.Framework;
using FiniteStateMachine;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateBase_StateBase_87eb67ac37
    {
        [Test]
        public void Constructor_ValidInput_StateBaseIsCreated()
        {
            // Arrange
            FiniteStateMachine fsm = new FiniteStateMachine(); // TODO: initialize as appropriate
            StateType stateKey = new StateType(); // TODO: initialize as appropriate

            // Act
            var stateBase = new ConcreteState(fsm, stateKey);

            // Assert
            Assert.That(stateBase.Fsm, Is.EqualTo(fsm), "FSM not correctly initialized");
            Assert.That(stateBase.StateKey, Is.EqualTo(stateKey), "StateKey not correctly initialized");
        }

        [Test]
        public void Constructor_NullInput_ThrowsException()
        {
            // Arrange
            FiniteStateMachine fsm = null;
            StateType stateKey = new StateType(); // TODO: initialize as appropriate

            // Assert
            Assert.Throws<ArgumentNullException>(() => new ConcreteState(fsm, stateKey));
        }
    }
}
