using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.HW12
{
    public class WrongLoginException : Exception
    {
        public string Login {  get; }
        public WrongLoginException() : base() { }

        public WrongLoginException(string login) : base($"Некорректный логин:{login}"){
            Login = login;
        }
    }
}
