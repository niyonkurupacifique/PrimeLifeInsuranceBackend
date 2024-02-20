using c_.INGENZIModels;
using c_.Dto;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public class ProductBodySelectionMiddleware
{
    private readonly RequestDelegate _next;

    public ProductBodySelectionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var product = context.Request.RouteValues["product"];

        if (!string.IsNullOrEmpty((string)product))
        {
            switch (product)
            {
                case "family":
                    context.Items["RequestBody"] = await context.Request.ReadFromJsonAsync<FamilyProductDto>();
                    break;
                case "education":
                    context.Items["RequestBody"] = await context.Request.ReadFromJsonAsync<ProposalRegister>();
                    break;
            }
        }

        await _next.Invoke(context);
    }
}
