using FluentValidationWebApplication.Application.Commands.ProductCommands.CreateProduct;
using FluentValidationWebApplication.Application.Queries.Products.GetProduct;
using Mediator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationWebApplication.Controllers.v1
{
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;

        }

        /// <summary>
        /// CreateProduct
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost("/api/v1/product")]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }

        /// <summary>
        /// GetProduct
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("/api/v1/product/{productId:int}")]
        public async Task<IActionResult> GetProduct(int productId)
        {
            var productVMs = await _mediator.Send(new GetProductQuery() { ProductId = productId });

            return Ok(productVMs);
        }
    }
}
