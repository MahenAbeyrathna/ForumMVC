using System.Collections.Generic;
using System.Threading.Tasks;
using ForumMVC.Data;
using ForumMVC.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumMVC.Service
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _context;

        public ForumService(ApplicationDbContext context)
        {
            _context =  context;
        }
        public Task Create(Forum froum)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int forumId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Forum> GetAll()
        {
            return _context.Forums
                           .Include(f => f.Posts); 
        }

        public IEnumerable<ApplicationUser> GetAllActiveUsers()
        {
            throw new System.NotImplementedException();
        }

        public Forum GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateFormDescription(int forumId, string newDescription)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateForumTitle(int forumId, string newTiyle)
        {
            throw new System.NotImplementedException();
        }
    }
}
