﻿
using Mediator;

namespace FluentValidationWebApplication.Application.Commands.ProductCommands.CreateProduct
{
    public class CreateProductCommand : ICommand
    {
        public string ProductTitle { get; set; }

        public string ProductName { get; set; }
    }
}
