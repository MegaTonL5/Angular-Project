using HelpByPros.Api.Model;
using Xunit;
using HelpByPros.BusinessLogic;



namespace HelpByPros.Test
{
   public class ApiModelTest
    {
        [Fact]
        public void UserModelShouldMapTtoProUser()
        {
            //ARRANGE 
            var prof = new Professional();
            prof.FirstName = "nan";
            prof.Email = "sca@gmail.com";
            prof.Summary = "i am not good";
            prof.Credential = "link";
            prof.Category = "Math";
            prof.Email = "username";
            prof.YearsOfExp = 30;
            prof.Phone = "919234922";
            prof.LastName = "lastname";


            //Act
            var model = new RegisterModel();
            model.IsProfessional = true;
            model.FirstName = prof.FirstName;
            model.LastName = prof.LastName;
            model.Phone = prof.Phone;
            model.Summary = prof.Summary;
            model.YearsOfExp = prof.YearsOfExp;
            model.Username = prof.Email;
            model.Credential = prof.Credential;
            model.Category = prof.Category;
            model.Email = prof.Email;

            Assert.Equal(prof.Email, model.RegisterProfessional().Email);
            Assert.Equal(prof.FirstName, model.RegisterProfessional().FirstName);
            Assert.Equal(prof.Email, model.RegisterProfessional().Email);
            Assert.Equal(prof.Credential, model.RegisterProfessional().Credential);
            Assert.Equal(prof.Phone, model.RegisterProfessional().Phone);




        }


        [Fact]
        public void UserModelShouldMapTtoMemberUser()
        {
            //ARRANGE 
            var member = new Member();
            member.FirstName = "nan";
            member.Email = "sca@gmail.com";
            member.Email = "username";
            member.Phone = "919234922";
            member.LastName = "lastname";


            //Act
            var model = new RegisterModel();
            model.IsProfessional = true;
            model.FirstName = member.FirstName;
            model.LastName = member.LastName;
            model.Phone = member.Phone;
            model.Username = member.Email;
            model.Email = member.Email;

            Assert.Equal(member.Email, model.RegisterMember().Email);
            Assert.Equal(member.FirstName, model.RegisterMember().FirstName);
            Assert.Equal(member.Email, model.RegisterMember().Email);
            Assert.Equal(member.Phone, model.RegisterMember().Phone);
            Assert.False(model.IsProfessional = false);



        }


    }
}
