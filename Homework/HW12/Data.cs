using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.HW12
{
    public class Data
    {
        public static void MainData(string login, string password, string confirmPassword)
        {
            int countLogin = 0;
            for (int i = 0; i < login.Length; i++)
            {
                if (login[i] == ' ')
                {
                    countLogin++;
                }
            }

            if (login.Length >= 20 || countLogin != 0)
            {
                try
                {
                    throw new WrongLoginException(login);
                }
                catch (WrongLoginException ex)
                {
                    Console.WriteLine("Валидация: " + ex.Message);
                }
                catch(Exception e) 
                {
                    Console.WriteLine($"Другая ошибка {e.Message}");
                }
            }

            int countPassword = 0;
            bool flag = true;
            for (int i = 0; i < password.Length; i++)
            {

                if (password[i] == ' ')
                {
                    countPassword++;
                }
                if (char.IsDigit(password[i]))
                {
                    flag = true;
                }
            }

            if (password.Length >= 20 || countPassword != 0 || flag == false || password != confirmPassword)
            {
                try
                {
                    throw new WrongPasswordException(password);
                }
                catch (WrongPasswordException ex)
                {
                    Console.WriteLine("Валидация: " + ex.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Другая ошибка {e.Message}");
                }
            }

            Console.WriteLine("ЛОГИН");
            Console.WriteLine(login);
            Console.WriteLine("ПАРОЛЬ");
            Console.WriteLine(password);
            
        }
    }
}
