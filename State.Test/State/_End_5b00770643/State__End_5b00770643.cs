using NUnit.Framework;
using Moq;
using FiniteStateMachine;

namespace FiniteStateMachine.Test
{
    public interface IEndState
    {
		void _End();
	}
	
	public class State__End_5b00770643 : IEndState
	{
		public void _End()
		{
			// Method implementation
		}
	}

    public class State__End_5b00770643_Test // adding '_Test' to differentiate between main class and test class name
    {
        private Mock<IEndState> _mockState;

        [SetUp]
        public void Setup()
        {
            _mockState = new Mock<IEndState>();
        }

        [Test]
        public void Test_End_Success()
        {
            // Arrange
            _mockState.Setup(m => m._End());

            // Act
            _mockState.Object._End();

            // Assert
            _mockState.Verify(m => m._End(), Times.Once);
        }

        [Test]
        public void Test_End_Failure()
        {
            // Arrange
            _mockState.Setup(m => m._End()).Throws(new System.Exception("Simulated exception"));

            // Act & Assert
            Assert.Throws<System.Exception>(() => _mockState.Object._End());
        }
    }
}
