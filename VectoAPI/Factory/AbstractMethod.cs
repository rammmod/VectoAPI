namespace VectoAPI.Factory
{
    public abstract class AbstractMethod : IMethod
    {
        public abstract Task<string> Invoke(string content, string value);
    }
}
