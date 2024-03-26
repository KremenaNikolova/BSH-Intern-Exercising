## Task

There are two GET endpoints in an existing codebase for a store that offers two types of products:  **food and clothing**. According to a new requirement, the results should be **sorted by default as follows:**
1. **Food items** should be ordered by **expiration date in descending order** and then by **name in ascending order**.
2. **Clothing items** should be ordered by **price in descending order** and then by **name in ascending order**.
 <br/>
Thanks to an already existing abstraction, a single method is responsible for retrieving the items of any type of product. The store is expected to offer more product types in the future.
To retain the abstraction and ensure easy addition of new product types, the new sorting functionality should be loosely coupled with the specific type of the products.

**As a result, adding new types of products (e.g. new class “Electronics”, ordered by its “WarrantyEndDate” field) should not require additions or changes to the already existing sorting functionality.**

## Postman
GetListOfAllProducts <br/>
GET ```https://localhost:{{portNumber}}/api/food/list```

GetListOfAllSortedProducts <br/>
GET ```https://localhost:{{portNumber}}/api/food/list/sort```


## Support Resources:
<a href="https://stackoverflow.com/questions/5144344/a-generic-sort-by-string-field-method">Generic sort by String<a/> <br/>
<a href="https://stackoverflow.com/questions/24440074/asp-net-mvc-4-get-value-from-iqueryable">If you want to sort IQueryable<a/> <br/>
<a href="https://learn.microsoft.com/en-us/dotnet/api/system.linq.iorderedenumerable-1?view=net-8.0">How to use IOrderedEnumerable<a/> <br/>
<a href="https://stackoverflow.com/questions/3025795/c-sharp-attribute-isdefined-example">How to check if the property has Specific Attribute<a/> <br/>
