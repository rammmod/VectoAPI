using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using VectoAPI.Models;
using VectoAPI.Services;
using VectoAPI.Settings;

namespace VectoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageProcessorController : ControllerBase
    {
        readonly IProcessor _processor;
        readonly ApplicationSettings _settings;

        public ImageProcessorController(
            IProcessor processor,
            ApplicationSettings settings)
        {
            _processor = processor;
            _settings = settings;
        }

        [HttpPost(nameof(ProcessImages))]
        public async Task<ActionResult<ICollection<ProcessImageResponse>>> ProcessImages(ICollection<ProcessImageRequest> request)
        {
            return Ok(await _processor.ProcessAsync(request));
        }

        [HttpGet(nameof(GetPlugins))]
        public ActionResult<ICollection<PluginSettings>> GetPlugins()
        {
            return Ok(_settings.PluginSettings);
        }
    }
}