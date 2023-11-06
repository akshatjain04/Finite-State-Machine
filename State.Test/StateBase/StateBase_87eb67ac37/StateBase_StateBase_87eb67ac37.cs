// Test generated by RoostGPT for test MiniPythonProjects using AI Type Azure Open AI and AI Model roost-gpt4-32k

using NUnit.Framework;
using Moq;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateBase_StateBase_87eb67ac37
    {
        private Mock<FiniteStateMachine> _fsm;
        private StateType _stateType;

        [SetUp]
        public void SetUp()
        {
            _fsm = new Mock<FiniteStateMachine>();
            _stateType = StateType.Start;
        }

        [Test]
        public void StateBase_WhenCalledWithCorrectValues_ShouldNotThrowException()
        {
            Assert.DoesNotThrow(() => new StateBase(_fsm.Object, _stateType));
        }


        [Test]
        public void StateBase_WhenCalledWithNullFSM_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new StateBase(null, _stateType));
        }


        [Test]
        public void StateBase_WhenCalledWithInvalidStateType_ShouldThrowArgumentException()
        {
            _stateType = null;
            Assert.Throws<ArgumentException>(() => new StateBase(_fsm.Object, _stateType));
        }
    }
}
