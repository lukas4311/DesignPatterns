public abstract class Abstraction{
    protected IBridge bridge;

    public Abstraction(IBridge bridge)
    {
        this.bridge = bridge;
    }

    public abstract void Operation();
}