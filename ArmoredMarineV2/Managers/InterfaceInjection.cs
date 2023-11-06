using ArmoredMarineV2.Interfaces;

namespace ArmoredMarineV2.Managers
{
    public class InterfaceInjection
    {
        private readonly IUserInterface _userInterface;
        public InterfaceInjection(IUserInterface userInterface) 
        {
            _userInterface = userInterface;
        }
    }
}
