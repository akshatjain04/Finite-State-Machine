// Test generated by RoostGPT for test MiniPythonProjects using AI Type Azure Open AI and AI Model roost-gpt4-32k

using NUnit.Framework;
using Moq;
using FiniteStateMachine;


namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateMachine_Update_73a5496b2c
    {
        private Mock<IState> _mockState;
        private StateMachine _stateMachine;

        [SetUp]
        public void Setup()
        {
            _mockState = new Mock<IState>();
            _stateMachine = new StateMachine();
        }

        [Test]
        public void Update_WhenCalled_CurrentStateIsUpdated()
        {
            _stateMachine.SetState(_mockState.Object);
            _stateMachine.Update(It.IsAny<float>());
            _mockState.Verify(state => state._Update(It.IsAny<float>()), Times.Once);
        }

        [Test]
        public void Update_WhenCalled_CurrentStateIsNull()
        {
            _stateMachine.SetState(null);
            Assert.DoesNotThrow(() => _stateMachine.Update(0));
        }
    }
}
