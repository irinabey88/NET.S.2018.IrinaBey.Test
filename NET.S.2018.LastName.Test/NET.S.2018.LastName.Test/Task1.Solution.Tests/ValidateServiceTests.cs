using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task1.Solution.Interfaces.Validator;
using Task1.Solution.Services;
using Task1.Solution.Validators;

namespace Task1.Solution.Tests
{
    [TestFixture]
    class ValidateServiceTests
    {
        [TestCase("password1")]
        [TestCase("perytye345nb")]
        public void CheckPassword_Successfull_Test(string arg1)
        {
            var serviceValidator = new PasswordValidationService(new List<IPasswordValidator>()
            {
                new EmptyValidator(),
                new NullValidator(),
                new HasLetterValidator(),
                new HasNumberValidator(),
                new MaxLengthValidator(),
                new MinLengthValidator()
            });

            Assert.IsTrue(serviceValidator.IsValid(arg1));
        }


        [TestCase("pass")]
        [TestCase("perytye345nbwerwerwerwerwerwerwer")]
        [TestCase("rtyiwewew")]
        [TestCase("111111111111")]
        [TestCase(null)]
        [TestCase("")]
        public void CheckPassword_Faild_Test(string arg1)
        {
            var serviceValidator = new PasswordValidationService(new List<IPasswordValidator>()
            {
                new EmptyValidator(),
                new NullValidator(),
                new HasLetterValidator(),
                new HasNumberValidator(),
                new MaxLengthValidator(),
                new MinLengthValidator()
            });

            Assert.IsFalse(serviceValidator.IsValid(arg1));
        }
    }
}
