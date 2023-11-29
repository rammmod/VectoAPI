namespace VectoAPI.Factory
{
    public interface IMethod
    {
        public Task<string> Invoke(string content, string value);
    }
}
