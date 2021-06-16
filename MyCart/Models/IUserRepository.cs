namespace MyCart_ClientLayer.Models
{
    public interface IUserRepository
    {

        public User Login(User user);
        public User Register(User user);


    }
}