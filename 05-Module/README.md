## Task

Create ASP.NET Core web APIs which should interact with the database from Lab 4 by the following actions:

1. Get a **customer** with a **specific ID**.
2. Get all **customers** from a **specific country**. 
   - Implement **paging** for that API and **include paging metadata**.
3. **Create a new record** in the Customers table.
4. **Update** the phone number of a customer.

## Postman
GetCustomerById <br/>
```https://localhost:{{portNumber}}/api/customer?id=252```

GetCustomerByCountry <br/>
```https://localhost:{{portNumber}}/api/customer/France?pageNumber=1&pageSize=12```

CreateNewCustomer <br/>
```https://localhost:{{portNumber}}/api/customer/new```

GetCustomerPhoneNumber <br/>
```https://localhost::{{portNumber}}/api/customer/udate?id=1```

UpdateCustomerPhoneNumber <br/>
```https://localhost:{{portNumber}}/api/customer/update```

