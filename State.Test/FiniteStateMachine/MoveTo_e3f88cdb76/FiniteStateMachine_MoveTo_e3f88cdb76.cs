// Test generated by RoostGPT for test MiniPythonProjects using AI Type Azure Open AI and AI Model roost-gpt4-32k

using System;
using NUnit.Framework;
using Moq;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class FiniteStateMachine_MoveTo_e3f88cdb76
    {
        private FiniteStateMachine _finiteStateMachine;

        [SetUp]
        public void Setup()
        {
            _finiteStateMachine = new FiniteStateMachine(); // assuming an acceptable constructor
        }

        [Test]
        public void MoveTo_Invokes_OnStateChange()
        {
            var eventTriggered = false;
            _finiteStateMachine.OnStateChange += (args) => eventTriggered = true;

            var mockEventArgs = new Mock<FiniteStateChangeEventArgs>();

            _finiteStateMachine.MoveTo(StateType.SampleState, mockEventArgs.Object);

            Assert.IsTrue(eventTriggered);
        }

        [Test]
        public void MoveTo_ThrowsException_WhenInvalidTargetStateKeyProvided()
        {
            var invalidStateType = StateType.NonExistingState; // Assuming an invalid state
            var mockEventArgs = new Mock<FiniteStateChangeEventArgs>();

            Assert.Throws<InvalidStateTypeException>(() => _finiteStateMachine.MoveTo(invalidStateType, mockEventArgs.Object));
        }

        [Test]
        public void MoveTo_SetsNewState_WhenValidStateKeyProvided()
        {
            var newState = StateType.SampleState; // Assuming a valid state
            var mockEventArgs = new Mock<FiniteStateChangeEventArgs>();

            var actualState = _finiteStateMachine.MoveTo(newState, mockEventArgs.Object);

            Assert.AreEqual(newState, actualState);
        }

        [Test]
        public void MoveTo_ReturnsInitialState_WhenNoEventArgProvided()
        {
            var initialState = _finiteStateMachine.CurrentState; // Assuming to capture initial state
            var newState = StateType.SampleState; // Assuming a valid state

            var actualState = _finiteStateMachine.MoveTo(newState, null);

            Assert.AreEqual(initialState, actualState);
        }
    }
}
