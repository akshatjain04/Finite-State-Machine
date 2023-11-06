using NUnit.Framework;
using FiniteStateMachine;
using System;
using System.Collections.Generic;

namespace FiniteStateMachine.Test 
{
    [TestFixture]
    public class StateMachine_AddState_95a50d88c6 
    {
        private StateMachine<int> fsm;
        private State<int> validState;
        private State<int> invalidState;

        [SetUp]
        public void SetUp() 
        {
            this.fsm = new ConcreteStateMachine<int>();
            this.validState = new ConcreteState<int>(fsm, "Valid State", 1);
            this.invalidState = new ConcreteState<int>(new ConcreteStateMachine<int>(), "Invalid State", 2);
        }

        [Test]
        public void AddState_ValidState_AddsSuccessfully() 
        {
            this.fsm.AddState(this.validState);
            State<int> retrievedState;
            Assert.That(fsm.TryGetState(validState.StateKey, out retrievedState), Is.True);
            Assert.That(retrievedState, Is.EqualTo(validState));
        }

        [Test]
        public void AddState_InvalidState_ThrowsException() 
        {
            Assert.That(() => this.fsm.AddState(this.invalidState), Throws.TypeOf<Exception>()
                .With.Message.EqualTo("[FiniteStateMachine::AddState()] -> The State can only be added to the State Machine that was used to create it."));
        }
    }
}

// You would also need to define ConcreteStateMachine and ConcreteState
public class ConcreteStateMachine<T> : StateMachine<T>
{
    // override all abstract methods and properties here
}

public class ConcreteState<T> : State<T>
{
    public ConcreteState(StateMachine<T> stateMachine, string name, T stateKey)
        : base(stateMachine, name, stateKey)
    {
        // initialize state
    }

    // override all abstract methods and properties here
}
