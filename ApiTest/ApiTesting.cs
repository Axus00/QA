using Api.App.Controllers.Users;
using Api.Infrastructure.Data;
using Api.Models;
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
    public async Task GetOk()
    {
        var result = await _controller.Get();

        Assert.IsType<OkObjectResult>(result);
    }

    /* [Fact]
    public async Task GetOkById()
    {
        //this method validate if the GetById return data

        //Arrange
        var id = 2;

        //Act
        var result = await _controller.GetById(id);

        //Assert
        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public async Task GetById_Exists()
    {
        //Arrange
        var id = 1;
        var moqUser = new User { Id = id, FullName = "Fernando" };

        _serviceMock.Setup(u => u.GetUserById(id)).ReturnsAsync(moqUser);

        //Act
        var result = await _controller.GetById(id);

        //Act
        var objectResult =  Assert.IsType<OkObjectResult>(result);
        var user = Assert.IsType<User>(objectResult.Value);
        Assert.NotNull(user);
        Assert.Equal(id, user.Id);
    }

    [Fact]
    public async Task GetNotFound()
    {
        //Arrange
        var id = 7;

        //Act
        var result = await _controller.GetById(id);

        //Assert
        Assert.IsType<NotFoundResult>(result);
    } */
}