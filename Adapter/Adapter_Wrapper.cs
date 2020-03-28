public class Adapter_Wrapper : ITarget
{
    private Adaptee adaptee;

    public Adapter_Wrapper(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Request()
    {
        // some adapter magic
        this.adaptee.SpecialRequest();
    }
}