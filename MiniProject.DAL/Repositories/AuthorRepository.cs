using MiniProject.DAL.Database;
using MiniProject.DAL.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.DAL.Repositories
{
    public interface IAuthorRepository
    {
        List<Author> GetAuthors();
    }
    public class AuthorRepository : IAuthorRepository
    {
        // her skal vi injecte vores database ind
        private readonly AbContext context;
        public AuthorRepository(AbContext _context) // Dependency Injection DI
        {
            context = _context;
        }
        public List<Author> GetAuthors()
        {
            // kan skrives i en linje!!
            List<Author> list = new List<Author>();
            // benytter LINQ til at query vores database...
            // Når vi benytter LINQ benytter vi osse en teknologi der hedder lambda
            //list = context.Author // her har jeg fat i en tabel med navnet Author
            list = context.Author.ToList();
            return list;
        }
    }
}
