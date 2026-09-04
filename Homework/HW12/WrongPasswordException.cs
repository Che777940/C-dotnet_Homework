using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.HW12
{
    internal class WrongPasswordException : Exception
    {
        public string Password { get; }
        public WrongPasswordException() : base() { }

        public WrongPasswordException(string password) : base($"Некорректный пароль:{password}")
        {
            Password = password;
        }
    }
}
