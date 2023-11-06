// Test generated by RoostGPT for test MiniPythonProjects using AI Type Azure Open AI and AI Model roost-gpt4-32k

using System;
using NUnit.Framework;
using Moq;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class FiniteStateMachine_MoveTo_e3f88cdb76
    {
        private Mock<FiniteStateMachine> _finiteStateMachineMock;
  
        [SetUp]
        public void Setup()
        {
            _finiteStateMachineMock = new Mock<FiniteStateMachine>();
        }

        [Test]
        public void GivenValidTargetStateKey_WhenMoveToCalled_ThenReturnsTargetState()
        {
            // Arrange
            StateType targetStateKey = new StateType();
            FiniteStateChangeEventArgs eventArgs = new FiniteStateChangeEventArgs();

            _finiteStateMachineMock.Setup(fsm => fsm.MoveTo(targetStateKey, eventArgs)).Returns(targetStateKey);

            // Act
            var result = _finiteStateMachineMock.Object.MoveTo(targetStateKey, eventArgs);

            // Assert
            Assert.AreEqual(targetStateKey, result);
        }
  
        [Test]
        public void GivenInvalidTargetStateKey_WhenMoveToCalled_ThenThrowsException()
        {
            // Arrange
            StateType targetStateKey = null;
            FiniteStateChangeEventArgs eventArgs = new FiniteStateChangeEventArgs();

            _finiteStateMachineMock.Setup(fsm => fsm.MoveTo(targetStateKey, eventArgs)).Throws(new ArgumentNullException());

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _finiteStateMachineMock.Object.MoveTo(targetStateKey, eventArgs));
        }
      
        [TearDown]
        public void Teardown()
        {
            _finiteStateMachineMock = null;
        }
    }
}