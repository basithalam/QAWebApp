using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QAWebApp.Data;
using QAWebApp.Models;
using QAWebApp.Services.Implementations;
using Xunit;

namespace QAWebApp.Tests;

public class TagServiceTests
{
    private ApplicationDbContext CreateContext()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;
        return new ApplicationDbContext(options);
    }

    [Fact]
    public async Task GetOrCreateTagsAsync_IgnoresInvalidTags()
    {
        using var context = CreateContext();
        var logger = LoggerFactory.Create(builder => { }).CreateLogger<TagService>();
        var service = new TagService(context, logger);
        var input = "valid-tag,INVALID TAG,aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa,ok";
        var tags = await service.GetOrCreateTagsAsync(input);
        Assert.Contains(tags, t => t.Name == "valid-tag");
        Assert.Contains(tags, t => t.Name == "ok");
        Assert.DoesNotContain(tags, t => t.Name == "invalid tag");
        Assert.DoesNotContain(tags, t => t.Name == "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
    }

    [Fact]
    public async Task GetOrCreateTagsAsync_DeduplicatesTags()
    {
        using var context = CreateContext();
        var logger = LoggerFactory.Create(builder => { }).CreateLogger<TagService>();
        var service = new TagService(context, logger);
        var input = "csharp,csharp,aspnet";
        var tags = await service.GetOrCreateTagsAsync(input);
        Assert.Equal(2, tags.Count);
    }
}
