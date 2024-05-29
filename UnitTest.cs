using Xunit;
using Moq;

public class UserControllerTests
{
    [Fact]
    public void GetUser_ReturnsCorrectUser()
    {
        // Arrange
        var mockUserService = new Mock<IUserService>();
        var user = new User { Id = 1, Name = "Test User" };
        mockUserService.Setup(service => service.GetUser(1)).Returns(user);
        var userController = new UserController(mockUserService.Object);

        // Act
        var result = userController.GetUser(1);

        // Assert
        Assert.Equal(user, result);
    }
}