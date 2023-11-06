// Test generated by RoostGPT for test MiniPythonProjects using AI Type Azure Open AI and AI Model roost-gpt4-32k

using NUnit.Framework;
using NSubstitute;

namespace FiniteStateMachine.Test
{
    public class StateBase__End_3643a6cf0d_Tests
    {
        private StateBase__End_3643a6cf0d _stateBase__End_3643a6cf0d;
        private FiniteStateMachine _finiteStateMachineMock;

        [SetUp]
        public void Setup()
        {
            // Mock FiniteStateMachine and OnStateEnded event handler
            _finiteStateMachineMock = Substitute.For<FiniteStateMachine>();
            FiniteStateMachine.OnStateEnded += () => {}; // subscribe to event with empty delegate to enable invocation
            FiniteStateMachine.Instance = _finiteStateMachineMock;

            _stateBase__End_3643a6cf0d = new StateBase__End_3643a6cf0d();
        }

        [Test]
        public void _End_NormalScenario_CallsEndAndOnStateEnded()
        {
            // Arrange
            _finiteStateMachineMock.When(fsm => fsm.OnStateEnded.Invoke(Arg.Any<FiniteStateEndedEventArgs>())).DoNotCallBase();

            // Act
            _stateBase__End_3643a6cf0d._End();

            // Assert
            _finiteStateMachineMock.Received().OnStateEnded?.Invoke(Arg.Any<FiniteStateEndedEventArgs>());
        }

        [Test]
        public void _End_OnStateEndedNotSubscribed_DoesNotCallOnStateEnded()
        {
            // Arrange
            _finiteStateMachineMock.When(fsm => fsm.OnStateEnded.Invoke(Arg.Any<FiniteStateEndedEventArgs>())).DoNotCallBase();
            FiniteStateMachine.OnStateEnded -= () => {}; // unsubscribe from the event

            // Act
            _stateBase__End_3643a6cf0d._End();

            // Assert
            _finiteStateMachineMock.DidNotReceive().OnStateEnded?.Invoke(Arg.Any<FiniteStateEndedEventArgs>());
        }
    }
}
