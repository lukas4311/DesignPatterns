internal interface IPrototype{
    IPrototype DoShallowCopy();

    IPrototype DoDeepCopy();
}