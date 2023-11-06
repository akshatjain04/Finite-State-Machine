namespace FiniteStateMachine.Test
{
    public class StateBase__Update_8c1484250f
    {
        public bool IsUpdateCalled { get; private set; }

        public StateBase__Update_8c1484250f()
        {
            IsUpdateCalled = false;
        }

        public void _Update(float deltaTime)
        {
            // Put your code for _Update here...
            
            IsUpdateCalled = true;
        }
        
    }
}
