using CodersAcademy.API.Model;
using System;
using System.Threading.Tasks;

namespace CodersAcademy.API.Repository
{
    public class UserRepository
    {
        private MusicContext Context { get; set; }

        public UserRepository(MusicContext context)
        {
            this.Context = context;
        }

        internal Task CreateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
