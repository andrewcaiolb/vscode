[Test]
public async Task CreateUser_WithValidData_ShouldReturnCreatedUser()
{
    // Arrange
    var user = new User { Name = "Test User", Email = "test@test.com" };
    _userServiceMock.Setup(x => x.AddUser(It.IsAny<User>())).ReturnsAsync(user);

    // Act
    var result = await _userController.CreateUser(user);

    // Assert
    Assert.IsInstanceOf<CreatedAtActionResult>(result);
}