﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArcApi.Application.Features.Products.Queries.GetAllProducts;

namespace OnionArcApi.API.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IMediator mediator;

    public ProductController(IMediator mediator)
    {
        this.mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var response = await mediator.Send(new GetAllProductsQueryRequest());
        return Ok(response);
    }
}
