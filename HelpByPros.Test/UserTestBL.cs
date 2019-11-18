using System;
using Xunit;
using HelpByPros.BusinessLogic;

namespace HelpByPros.Test
{
    public class UserTestBL
    {
        //
        /// 1. test the names // check for nulls, formats, length ..etc. 
        /// 2. test the email  // check for nulls, formats,  length ..etc. 
        /// 3. username & password // check for nulls, formats,  length , the uniqueness of the username 


        // Test each part of the business logic in seperate method. 

        [Fact]
        public void UserNameShouldFomatCorrectly_Test()
        {

        }
        [Fact]

        public void UserEmailShouldFormat_Test()
        {

        }
        [Fact]

        public void UserLogin_Test()
        {

        }



        [Fact]

        public void USerDataCreatedSuccessful_Test()
        {

            //Arrange

            string fname = "John";
            string lname = "Smith";

            string email = "john.smith@gmail.com";

            //Act
            IUser user = new User()
            {
                FirstName = fname,
                LastName = lname,
                Email = email,

            };

            //Assert
            Assert.Equal(fname, user.FirstName);
            Assert.Equal(lname, user.LastName);
            Assert.Equal(email, user.Email);


        }

        
        [Theory]
        [ InlineData( "Jane", "Doe", "jane.doe@yahoo.com", "janey", "12345") ] //arrange

        public void CreateMultipleUsers_Test(string value1, string value2, string value3, string value4, string value5)
        {

            //Act

            //We need a constructor so we can simply write this...
            //IUser user = new User(fname, lname, email, login, password);

            //instead of this
            //Act
            IUser user = new User() { FirstName = value1, LastName = value2,  Email = value4 };


            //Assert
            Assert.Equal(value1, user.FirstName);
            Assert.Equal(value2, user.LastName);
            Assert.Equal(value4, user.Email);

        }
    }
}
