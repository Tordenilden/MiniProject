using MiniProject.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// dette svarer til services i pdf side 21
// BusinessLogicLayer - calculations, data transformations etc.
namespace MiniProject.BLL 
{
    public interface IAuthorService
    {
        public List<Author> getAllAuthors();
    }
    public class AuthorService : IAuthorService
    {
        // hvad skal jeg her nu er jeg lost??
        public List<Author> getAllAuthors()
        {
            return new List<Author>
           {
               new Author(){AuthorId=1,age=12,isAlive=true,name="Castle",password="1234"},
               new Author(){AuthorId=2,age=89,isAlive=true,name="Signe et eller andet",
                   password="5678"}
           };
            //throw new NotImplementedException();
        }
    }
}
