﻿using Alba;
using Todos.Api.Todos;

namespace Todos.Tests.Todos;
public class GettingTodos
{
    [Fact]
    public async Task GetsAOkStatusCode()
    {
        var host = await AlbaHost.For<Program>();

        await host.Scenario(api =>
        {
            api.Get.Url("/todos");
            api.StatusCodeShouldBeOk(); //200
        });
    }


    [Fact]
    public async Task CanAddAnItemToTheTodoList()
    {
        var host = await AlbaHost.For<Program>();
        var itemToAdd = new TodoListCreateItem
        {
            Description = "Make Tacos " + Guid.NewGuid(),
        };

        await host.Scenario(api =>
        {
            api.Post.Json(itemToAdd).ToUrl("/todos");
            api.StatusCodeShouldBeOk();
        });
        // see if it is on my todo list.
        var getResponse = await host.Scenario(api =>
        {
            api.Get.Url("/todos");
        });

        var listOfTodos = getResponse.ReadAsJson<List<TodoListCreateItem>>();

        Assert.NotNull(listOfTodos);

        var hasMyItem = listOfTodos.Any(item => item.Description == itemToAdd.Description);

        Assert.True(hasMyItem);
    }
}
