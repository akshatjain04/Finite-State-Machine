// Updated code:

using NUnit.Framework;
using FiniteStateMachine;
using System;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class FiniteStateEndedEventArgsTest
    {
        [Test]
        public void FiniteStateEndedEventArgs_EndedStateIsNull_ReturnsNullException()
        {
            // Arrange
            StateType? endedState = null;

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => new FiniteStateEndedEventArgs(endedState));
        }

        [Test]
        public void FiniteStateEndedEventArgs_ValidEndedState_CorrectlyAssignsEndedState()
        {
            // Arrange
            var endedState = new StateType();

            // Act
            var finiteStateEndedEventArgs = new FiniteStateEndedEventArgs(endedState);

            // Assert
            Assert.AreEqual(endedState, finiteStateEndedEventArgs.Type);
        }

        [Test]
        public void FiniteStateEndedEventArgs_CheckInstanceType_CorrectTypeAssigned()
        {
            // Arrange
            var endedState = new StateType();

            // Act
            var finiteStateEndedEventArgs = new FiniteStateEndedEventArgs(endedState);
            
            // Assert
            Assert.IsInstanceOf(typeof(FiniteStateEndedEventArgs), finiteStateEndedEventArgs);
        }
    }
}
