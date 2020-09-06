using Schmidt.Twitter.Reader.Remote.InputModel;
using Schmidt.Twitter.Reader.Remote.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Schmidt.Twitter.Reader.Remote.Abstraction
{
    public interface ITwitterReaderService
    {
        Task<IEnumerable<SearchViewModel>> GetAllAsync(SearchInputModel input);
    }
}
