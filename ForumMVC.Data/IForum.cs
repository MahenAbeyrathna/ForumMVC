using ForumMVC.Data.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ForumMVC.Data
{
    public interface IForum
    {
        Forum GetById(int id);
        IEnumerable<Forum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers();

        Task Create(Forum froum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTiyle);
        Task UpdateFormDescription(int forumId, string newDescription);

    }
}
