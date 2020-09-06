using Schmidt.Twitter.Reader.Remote.Abstraction;
using Schmidt.Twitter.Reader.Remote.InputModel;
using Schmidt.Twitter.Reader.Remote.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Schmidt.Twitter.Reader.Remote.Services
{
    public class TwitterReaderService : ITwitterReaderService
    {
        public TwitterReaderService()
        {

        }
        public Task<IEnumerable<SearchViewModel>> GetAllAsync(SearchInputModel input)
        {
            throw new NotImplementedException();
        }
    }
}
