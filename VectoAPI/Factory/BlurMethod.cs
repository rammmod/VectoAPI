namespace VectoAPI.Factory
{
    public class BlurMethod : AbstractMethod
    {
        public override async Task<string> Invoke(string content, string value)
        {
            return await Task.FromResult(content + nameof(BlurMethod));
        }
    }
}
