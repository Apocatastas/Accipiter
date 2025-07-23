using Accipiter.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accipiter.ViewModels.Account
{
    public class UserWithFriendExt: User
    {
        public bool IsFriendWithCurrent { get; set; }
    }
}
