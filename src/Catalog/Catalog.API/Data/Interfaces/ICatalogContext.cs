using System;
using MongoDB.Driver;
using Catalog.API.Entities;
namespace Catalog.API.Data.Interfaces
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
