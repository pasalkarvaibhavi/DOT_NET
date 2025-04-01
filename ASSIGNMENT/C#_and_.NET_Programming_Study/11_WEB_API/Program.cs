using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add Swagger for API documentation (optional)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// In-memory storage for products
List<Product> products = new List<Product>
{
    new Product { Id = 1, Name = "Laptop", Price = 1000 },
    new Product { Id = 2, Name = "Smartphone", Price = 600 }
};

// GET endpoint to retrieve all products
app.MapGet("/api/products", () =>
{
    return Results.Json(products);
});

// POST endpoint to create a new product
app.MapPost("/api/products", (Product newProduct) =>
{
    newProduct.Id = products.Count + 1;
    products.Add(newProduct);
    return Results.Created($"/api/products/{newProduct.Id}", newProduct);
});

// Run the application
app.Run();

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
