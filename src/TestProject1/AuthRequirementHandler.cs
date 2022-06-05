using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Pro.FileStore.WebApi.Tests;

public class AuthRequirementHandler:AuthorizationHandler<AuthRequirement>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AuthRequirement requirement)
    {
        context.Succeed(requirement);
        return Task.CompletedTask;
    }
}