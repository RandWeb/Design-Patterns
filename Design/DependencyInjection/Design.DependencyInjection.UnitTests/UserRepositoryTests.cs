using Design.DependencyInjection.Data;
using NSubstitute;

namespace Design.DependencyInjection.UnitTests;

public class UserRepositoryTests
{
    private readonly IUserRepository _userRepositoryMock;
    private readonly UserService _userService;
    public UserRepositoryTests()
    {
        _userRepositoryMock = Substitute.For<IUserRepository>();
        _userService = new UserService(_userRepositoryMock);
 }

    [Fact]
    public async Task CreateAsync_ReturnsTrue_WhenUserIsCreated()
    {
        // Arrange
        var user = new User { Id = Guid.NewGuid(), FullName = "User 1" };

        _userRepositoryMock.CreateAsync(user).Returns<bool>(true);

        // Act
        var result = await _userService.CreateAsync(user);

        // Assert
        Assert.True(result);

    }

    [Fact]
    public async Task CreateAsync_ReturnsFalse_WhenUserIsNotCreated()
    {
        // Arrange
        var user = new User { Id = Guid.NewGuid(), FullName = "User 1" };

        _userRepositoryMock.CreateAsync(user).Returns<bool>(false);

        // Act
        var result = await _userService.CreateAsync(user);

        // Assert
        Assert.False(result);

    }

    [Fact]
    public async Task GetByIdAsync_ShouldReturnNull_WhenUserNotExists()
    {
        // Arrange
        var userId = Guid.NewGuid();

        _userRepositoryMock.GetByIdAsync(userId);

        // Act
        var result = await _userService.GetByIdAsync(userId);

        // Assert
        Assert.Null(result);

    }

    [Fact]
    public async Task GetByIdAsync_ShouldReturnUser_WhenUserExits()
    {
        // Arrange 
        var userId = Guid.NewGuid();
        var expectedUser = new User { Id = userId, FullName = "mehrtab" };

        // تنظیم رفتار QuerySingleOrDefaultAsync برای بازگرداندن کاربر منتظره
        _userRepositoryMock.GetByIdAsync(userId)
            .Returns(Task.FromResult(expectedUser));

        // Act

        var result = await _userService.GetByIdAsync(userId);

        //Assert
        Assert.NotNull(result);
        Assert.Equal(expectedUser.Id, result.Id);
        Assert.Equal(expectedUser.FullName, result.FullName);
    }

    [Fact]
    public async Task GetAllAsync_ShouldReturnUsers_WhenUsersExsits()
    {
        // Arrange
        User[] users = [
            new User() {Id = Guid.NewGuid(),FullName = "mehrtab" },
            new User() {Id = Guid.NewGuid(),FullName = "mehrtab 1" },
            new User() {Id = Guid.NewGuid(),FullName = "mehrtab 3" },
            ];

        _userRepositoryMock.GetAllAsync().Returns(users);

        // Act

        var result = await _userService.GetAllAsync();

        // Assert

        Assert.NotNull(result);
        Assert.Equal(result.Count(), users.Length);
        Assert.True(result.First() == users.First());
        Assert.Equal(result.ToArray()[1], users[1]);
        Assert.True(result.Last() == users.Last());
    }

    [Fact]
    public async Task GetAllAsync_ShouldReturnEmptyCollection_WhenUsersNotExsits()
    {
        // Arrange

        _userRepositoryMock.GetAllAsync().Returns(Enumerable.Empty<User>());

        // Act

        var result = await _userService.GetAllAsync();

        // Assert
        Assert.True(result.Count() == 0);
    }
}
