using Graduation_Project.Models;
 
namespace Graduation_Project.Repository
{
    public class RegisterRepositry : IRegisterRepositry
    {
        CenterDBContext _centerDBContext;
        public RegisterRepositry(CenterDBContext context)
        {
            _centerDBContext = context;

        }
        public void Insert(Register newRegister)
        {
           _centerDBContext.Registers.Add(newRegister);
            _centerDBContext.SaveChanges();
        }
    }
}
