using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
// Each class and module should focus on a single task at a time
// Everything in the class should be related to that single purpose
// There can be many members in the class as long as they related to the single responsibility
// With SRP, classes become smaller and cleaner
// Code is less fragile
    interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username,
            string password, string email);
    }
    interface ILogger
    {
        void LogError(string error);
    }

    interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
