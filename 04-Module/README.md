## Task

Use ASP.Net Core to create a web page for a customer which should contain the following fields: **first name, last name, email, gender, country, city, phone, birth date**.

1. **First name**, **last name** and **email** field are mandatory.
2. The **email** field should be automatically validated and would notify the user if the email is invalid.
3. The **phone number** field should expect a user input in the following format: XXX-XXX-XXXX
4. The **gende**r field should allow the user to select one between two values.
5. The **city** and **country** fields should contain a list of items (please use hardcoded values) and should allow the user to select one value per field.
6. The **birth date** field should display a simple **calendar** control and shouldn’t allow the user to input invalid dates.
7. After setting up your page, please insert data into the table from **Lab 3**.
8. Create additional database tables from previous <a href="https://github.com/KremenaNikolova/BSH-Intern-Exercising/tree/main/03-Module">Modul(3)</a> and seed Database
9. Add Cascade Delete

## Solution:

![Screenshot 2024-03-17 121802](https://github.com/KremenaNikolova/BSH-Intern-Exercising/assets/106489962/740d70a0-aabd-477f-8e20-2818c522f867)
<br/>

I have added an additional page where all registered users are displayed and functionality that checks if a user with that email already exists.

![All Customers](https://github.com/KremenaNikolova/BSH-Intern-Exercising/assets/106489962/8e14e6ed-bc22-41b4-a2ae-bc3a7bb3cfa1)

![Cusromer Products](https://github.com/KremenaNikolova/BSH-Intern-Exercising/assets/106489962/7aa66eae-cb6c-4369-bb6f-7507bb6e11ad)


## Additional Resources:

<a href="https://www.youtube.com/watch?v=0JDxnjcH_v0">How to create dropdown using Enum</a> <br/>
<a href="https://stackoverflow.com/questions/41517359/pagedlist-core-mvc-pagedlistpager-html-extension-in-net-core-is-not-there">How to create pagination using X.PagedList</a> <br/>
<a href="https://stackoverflow.com/questions/35770277/how-to-use-toshortdatestring-on-nullable-datetime-column">How to use ToShortDateString() on nullable datetime column</a>
