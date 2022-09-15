namespace P02._Identity_Before.Contracts
{
    using System.Collections.Generic;

    public interface IAccountAuthenticator
    {
        

        void Register(string username, string password);

        void Login(string username, string password);


        
    }
}
