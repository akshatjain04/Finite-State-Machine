using NUnit.Framework;
using Moq;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateBase__End_3643a6cf0d_Test
    {
        private Mock<IFiniteStateMachine> _finiteStateMachineMock;
        private StateUnderTest _stateUnderTest;

        [SetUp]
        public void SetUp()
        {
            _finiteStateMachineMock = new Mock<IFiniteStateMachine>();
            _stateUnderTest = new StateUnderTest(_finiteStateMachineMock.Object);
        }

        [Test]
        public void _End_WhenCalled_ShouldCallEnd()
        {
            _stateUnderTest.End();

            Assert.IsTrue(_stateUnderTest.EndCalled);
        }

        [Test]
        public void _End_WhenCalled_ShouldTriggerOnStateEnded()
        {
            FiniteStateEndedEventArgs endArgs = null;
            _finiteStateMachineMock.Setup(m => m.OnStateEnded += (sender, args) => endArgs = args);

            _stateUnderTest.End();

            Assert.IsNotNull(endArgs);
            Assert.AreEqual(_stateUnderTest.StateKey, endArgs.StateKey);
        }

        public class StateUnderTest : StateBase
        {
            public bool EndCalled { get; private set; } = false;

            public StateUnderTest(IFiniteStateMachine stateMachine) : base(stateMachine) { }

            public override void Begin(FiniteStateChangeEventArgs args, StateType prevState)
            {
                // Implementation here
            }

            public override void End()
            {
                EndCalled = true;
            }

            public override StateType Load()
            {
                // Implementation here
                return new StateType();
            }

            public override void Update(float delta)
            {
                // Implementation here
            }
        }
    }
}
