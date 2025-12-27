public sealed class Singleton
{
    private int executions;
    private static Singleton? instance = null;
    private static readonly object padlock = new object();

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    return instance = new Singleton();
                }

                return instance;
            }
        }
    }

    public int GetExecutions()
    {
        return ++executions;
    }
}
