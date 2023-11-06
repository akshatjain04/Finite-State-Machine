// When writing an abstract class, you can't create an instance of it. Instead, you should create a concrete class that inherits from it. In your case, both StateMachine and State are abstract classes.
// Additionally, methods such as GetStates and AddState are not recognized because they do not exist in the StateMachine class. Let's go ahead and implement these methods.
// Moreover, the constructor of State also requires two arguments instead of one.

using System.Collections.Generic;
using NUnit.Framework;

namespace FiniteStateMachine.Test
{
    [TestFixture]
    public class StateMachineTests
    {
        private MyStateMachine _stateMachine;

        [SetUp]
        public void SetUp()
        {
            _stateMachine = new MyStateMachine();
        }

        [Test]
        public void Constructor_WhenCalled_SetsUpEmptyStatesDictionary()
        {
            // Act
            var states = _stateMachine.GetStates();

            // Assert
            Assert.IsNotNull(states);
            Assert.IsInstanceOf<Dictionary<int, State<int>>>(states);
            Assert.IsEmpty(states);
        }

        [Test]
        public void AddState_WithValidInput_AddsStateToDictionary()
        {
           // Arrange
            var state = new MyState(1, "State Test");
            
            // Act
            _stateMachine.AddState(1, state);
            var states = _stateMachine.GetStates();

            //Assert
            Assert.IsNotEmpty(states);
            Assert.Contains(1, states.Keys);
            Assert.AreEqual(state, states[1]);
        }
    }

    // Create a concrete class that inherits from StateMachine
    public class MyStateMachine : StateMachine<int>
    {
        private Dictionary<int, State<int>> _states;

        public MyStateMachine()
        {
            _states = new Dictionary<int, State<int>>();
        }

        // Implement GetStates method
        public Dictionary<int, State<int>> GetStates()
        {
            return _states;
        }

        // Implement AddState method
        public void AddState(int key, State<int> state)
        {
            _states.Add(key, state);
        }
    }

    // Create a concrete class that inherits from State
    public class MyState : State<int>
    {
        public MyState(int id, string name) : base(id, name) { }
    }
}
