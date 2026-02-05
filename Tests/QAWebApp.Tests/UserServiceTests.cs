using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QAWebApp.Data;
using QAWebApp.DTOs;
using QAWebApp.Services.Implementations;
using Xunit;

namespace QAWebApp.Tests;

public class UserServiceTests
{
    private ApplicationDbContext CreateContext()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;
        return new ApplicationDbContext(options);
    }

    [Fact]
    public async Task Register_And_Login_Workflow_Succeeds()
    {
        using var context = CreateContext();
        var logger = LoggerFactory.Create(builder => { }).CreateLogger<UserService>();
        var service = new UserService(context, logger);
        var reg = await service.RegisterAsync(new RegisterDto { Username = "alice", Email = "a@x.com", Password = "Secret123!" });
        Assert.True(reg.Success);
        var login = await service.LoginAsync(new LoginDto { UsernameOrEmail = "alice", Password = "Secret123!" });
        Assert.True(login.Success);
    }

    [Fact]
    public async Task Login_Fails_For_Wrong_Password()
    {
        using var context = CreateContext();
        var logger = LoggerFactory.Create(builder => { }).CreateLogger<UserService>();
        var service = new UserService(context, logger);
        var reg = await service.RegisterAsync(new RegisterDto { Username = "bob", Email = "b@x.com", Password = "Secret123!" });
        Assert.True(reg.Success);
        var login = await service.LoginAsync(new LoginDto { UsernameOrEmail = "bob", Password = "WrongPass" });
        Assert.False(login.Success);
    }
}
