using VectoAPI.Factory;
using VectoAPI.Models;

namespace VectoAPI.Services
{
    public class Processor : IProcessor
    {
        private IMethod _method { get; set; }

        public async Task<ICollection<ProcessImageResponse>> ProcessAsync(ICollection<ProcessImageRequest> request)
        {
            foreach (var oneImage in request)
            {
                foreach (var oneOperation in oneImage.Operations)
                {
                    _method = MethodFactory.Create(oneOperation.Key);
                    oneImage.Content = await _method.Invoke(oneImage.Content, oneOperation.Value);
                }
            }

            var response = new List<ProcessImageResponse>();

            foreach (var image in request)
            {
                response.Add(new ProcessImageResponse() { Id = image.Id, Content = image.Content });
            }

            return response;
        }
    }
}
