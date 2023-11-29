using VectoAPI.Models;

namespace VectoAPI.Services
{
    public interface IProcessor
    {
        public Task<ICollection<ProcessImageResponse>> ProcessAsync(ICollection<ProcessImageRequest> request);
    }
}
