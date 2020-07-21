using BlazorInputFile;
using System.Threading.Tasks;

namespace NextRoundUI.Services
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry fileEntry);
        Task VideoUploadAsync(IFileListEntry fileEntry);
    }
}