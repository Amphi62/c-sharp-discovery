using Xunit;
using ApplicationCsharp.entity;
using ApplicationCsharp.builder;

namespace ApplicationCsharp.tests.builder
{
    public class UserBuilderTest
    {
        [Fact]
        public void CreateListOfUsersTest()
        {
            List<User> users = UserBuilder.CreateListOfUsers();
            Assert.NotNull(users);
            Assert.Equal(2, users.Count());

            Assert.Equal("user1", users[0].Username);
            Assert.Equal("user1@test.fr", users[0].Email);

            Assert.Equal("user2", users[1].Username);
            Assert.Equal("user2@test.fr", users[1].Email);
        }
    }
}
