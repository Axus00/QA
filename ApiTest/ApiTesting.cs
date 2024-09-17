using Api.App.Controllers.Users;
using Api.Infrastructure.Data;
using Api.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace ApiTest;

public class ApiTesting
{
    private readonly UsersController _controller;
    private readonly Mock<IUserRepository> _serviceMock;
    public ApiTesting()
    {
        var MockContext = new Mock<BaseContext>();
        
        _serviceMock = new Mock<IUserRepository>();
        _controller = new UsersController(_serviceMock.Object);
    }

    [Fact]
    public async Task Get_Ok()
    {
        var result = await _controller.Get();

        Assert.IsType<OkObjectResult>(result);
    }
}