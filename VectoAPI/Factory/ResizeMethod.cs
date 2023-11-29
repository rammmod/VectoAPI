namespace VectoAPI.Factory
{
    public class ResizeMethod : AbstractMethod
    {
        public ResizeMethod()
        {
        }

        public override async Task<string> Invoke(string content, string value)
        {
            return await Task.FromResult(content + nameof(ResizeMethod));
        }
    }
}
