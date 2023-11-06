// Updated test case

using NUnit.Framework;
using Moq;

namespace FiniteStateMachine.Test 
{
    [TestFixture]
    public class StateMachine_Update_73a5496b2c<TestObject>  //Add a generic type
    {
        private Mock<IState<TestObject>> _mockState; //Specify the generic type here
        private StateMachine<TestObject> _machine; //Specify the generic type here

        [SetUp]
        public void Setup() 
        {
            _mockState = new Mock<IState<TestObject>>(); //Specify the generic type here
            _machine = new StateMachine<TestObject>(); //Specify the generic type here
        }

        [Test]
        public void Update_ValidDelta_CallsUpdateOnCurrentState()
        {
            // Arrange
            _machine.m_currentState = _mockState.Object;

            // Act
            _machine.Update(1.0f);

            // Assert
            _mockState.Verify(x => x._Update(1.0f), Times.Once);
        }

        [Test]
        public void Update_NoCurrentState_DoesNotThrow() 
        {
            // Arrange
            _machine.m_currentState = null;

            // Act and Assert
            Assert.DoesNotThrow(() => _machine.Update(1.0f));
        }

        [Test]
        public void Update_NegativeDelta_ThrowsArgumentException() 
        {
            // Arrange
            _machine.m_currentState = _mockState.Object;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => _machine.Update(-1.0f));
        }

        [Test]
        public void Update_ZeroDelta_CallsUpdateOnCurrentState() 
        {
            // Arrange
            _machine.m_currentState = _mockState.Object;

            // Act
            _machine.Update(0f);

            // Assert
            _mockState.Verify(x => x._Update(0f), Times.Once);
        }
    }
}
