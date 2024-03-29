﻿using FluentValidationWebApplication.Domain.Enums;
using Mediator;

namespace FluentValidationWebApplication.Application.Features.Products.Commands.ProductCommands.CreateProduct
{
    public class CreateProductCommand : ICommand
    {
        public int Id { get; set; }

        public string ProductTitle { get; set; }

        public ProductType ProductType { get; set; }

        public List<int> ProductGroups { get; set; }

        public List<ProductPicture> ProductPictures { get; set; }

        public int? ProductStockInStock { get; set; }
    }

    public class ProductPicture
    {
        public int ProductPictureId { get; set; }

        public string Path { get; set; }
    }
}
