using System;
using System.Collections.Generic;
using System.Text;

namespace P02._Identity_Before.Contracts {
    public interface IAccountFinder {
        IEnumerable<IUser> GetAllUsersOnline();

        IEnumerable<IUser> GetAllUsers();

        IUser GetUserByName(string name);
    }
}
