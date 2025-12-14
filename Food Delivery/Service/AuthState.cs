namespace Food_Delivery.Services
{
    public class AuthState
    {
        public bool IsLoggedIn { get; private set; } = false;

        public void Login()
        {
            IsLoggedIn = true;
        }

        public void Logout()
        {
            IsLoggedIn = false;
        }
    }
}
