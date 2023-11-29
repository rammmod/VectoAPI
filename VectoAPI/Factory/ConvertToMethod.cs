namespace VectoAPI.Factory
{
    public class ConvertToMethod : AbstractMethod
    {
        public override async Task<string> Invoke(string content, string value)
        {
            return await Task.FromResult(content + nameof(ConvertToMethod));
        }
    }
}
