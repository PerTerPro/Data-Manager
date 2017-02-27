using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearMVC1.Models
{
    public enum UserStatus
    {
        AuthenticatedAdmin,
        AuthenticatedUser,
        NonAuthenticatedUser
    }
}