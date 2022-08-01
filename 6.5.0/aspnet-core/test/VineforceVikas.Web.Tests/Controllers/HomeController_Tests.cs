using System.Threading.Tasks;
using VineforceVikas.Models.TokenAuth;
using VineforceVikas.Web.Controllers;
using Shouldly;
using Xunit;

namespace VineforceVikas.Web.Tests.Controllers
{
    public class HomeController_Tests: VineforceVikasWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}