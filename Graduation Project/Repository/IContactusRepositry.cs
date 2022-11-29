using El_Tamayez.Models;

namespace Graduation_Project.Repository
{
    public interface IContactusRepositry
    {
        public List<ContactUs> getallcontacts();
        public void Insert(ContactUs contactUs);
    }
}
