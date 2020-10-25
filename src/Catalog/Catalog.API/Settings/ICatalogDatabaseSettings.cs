using System;
namespace Catalog.API.Settings
{
    public class ICatalogDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string CollectionName { get; set; }
    }
}
