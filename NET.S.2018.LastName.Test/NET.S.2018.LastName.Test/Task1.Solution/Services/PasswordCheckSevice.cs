using System;
using System.Linq;
using Task1.Solution.Interfaces.Repository;
using Task1.Solution.Interfaces.Service;

namespace Task1.Solution.Services
{
    public class PasswordCheckSevice : IPasswordCheckService
    {
        private const int MIN_PASSWORD_LENGTH = 7;

        private const int MAX_PASSWORD_LENGTH = 15;

        public Tuple<bool, string> VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            if (password == string.Empty)
                return Tuple.Create(false, $"{password} is empty ");

            // check if length more than 7 chars 
            if (password.Length <= MIN_PASSWORD_LENGTH)
                return Tuple.Create(false, $"{password} length too short");

            // check if length more than 10 chars for admins
            if (password.Length >= MAX_PASSWORD_LENGTH)
                return Tuple.Create(false, $"{password} length too long");

            // check if password conatins at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");

            // check if password conatins at least one digit character 
            if (!password.Any(char.IsNumber))
                return Tuple.Create(false, $"{password} hasn't digits");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}