using System.Collections.Generic;
using System.Threading.Tasks;
using KnowledgeUberization.Models;

namespace KnowledgeUberization.Providers
{
    public interface IUserProvider : IWriterBase<UserAddExt, UserExt, UserRemoveExt>
    {
        IList<User> List(UserFilter filter);

        Task<IList<User>> ListAsync(UserFilter filter);
    }
}