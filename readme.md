# Api Request Validation

### C# example of how to separate the validation logic from the business logic in an Asp.Net Web API

<br>

# Build and execute

Run the following commands after cloning:
* dotnet restore
* dotnet build
* dotnet run

# How to call the APIs
### Post Product Endpoint 

* `
curl --location --request POST 'https://localhost:7073/Product' \
--header 'Content-Type: application/json' \
--data-raw '{
    "Name": "Playstation 5",
    "Description": "New generation Sony game console",
    "Price": "499.99",
    "Category": "Game Console"
}'
`

<br>

### Post Person Endpoint 

* `curl --location --request POST 'https://localhost:7073/Person' \
--header 'Content-Type: application/json' \
--data-raw '{
    "Name": "Name",
    "Email": "a@b.com",
    "BirthDate": "1986-01-01",
    "Vat": "111",
    "Address1": "My full address"
}'` 