using NUnit.Framework;

namespace FiniteStateMachine.Test
{
    public interface IState<T>
    {
        int StateKey { get; }
    }

    public interface IStateMachine<T>
    {
    }

    public class ConcreteState<T> : IState<T>
    {
        public IStateMachine<T> StateMachine { get; }
        public int StateKey { get; }

        public ConcreteState(IStateMachine<T> stateMachine, int key)
        {
            StateMachine = stateMachine;
            StateKey = key;
        }
    }

    public class ConcreteStateMachine<T> : IStateMachine<T>
    {
    }

    [TestFixture]
    public class State_State_f11a4f0491
    {
        [Test]
        public void Constructor_CorrectStateMachine_Successful()
        {
            var stateMachine = new ConcreteStateMachine<int>();
            var state = new ConcreteState<int>(stateMachine, 1);

            Assert.That(state.StateMachine, Is.EqualTo(stateMachine));
            Assert.That(state.StateKey, Is.EqualTo(1));
        }

        [Test]
        public void Constructor_NullStateMachine_ThrowsArgumentNullException()
        {
            Assert.Throws<System.ArgumentNullException>(() => new ConcreteState<int>(null, 1));
        }

        [Test]
        public void Constructor_StateKeyAtBoundary_Successful()
        {
            var stateMachine = new ConcreteStateMachine<int>();
            var state = new ConcreteState<int>(stateMachine, int.MaxValue);

            Assert.That(state.StateMachine, Is.EqualTo(stateMachine));
            Assert.That(state.StateKey, Is.EqualTo(int.MaxValue));
        }
    }
}
