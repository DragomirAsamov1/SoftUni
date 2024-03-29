﻿namespace P02._Identity_Before
{
    using Contracts;

    public class AccountController : IAccountManager
    {
        private readonly IAccountManager manager;

        public AccountController(IAccountManager manager)
        {
            this.manager = manager;
        }

        public void ChangePassword(string oldPass, string newPass)
        {
            this.manager.ChangePassword(oldPass, newPass);
        }
    }
}
