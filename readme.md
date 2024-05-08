# Practical Assessment

### Source: ApiAssessment.sln

In the solution you will find the basic parts of an .NET Web API responsible for processing payments and a repository for fetching payments and saving payments.

The API is publicly accessible.

### Implement the following API methods

Payments Controller:

#### POST:api/Payments

Implement/Complete the API method that will take in the following parameters:

    decimal Amount
    string CardNumber
    string Cvv

These parameters need to be passed to the PaymentService, which will process the payment at the processor via an API, publish a result via the QueueService and save via the repository.

The providers payment API requires an auth header with the key "x-api-key" and the value from the config

#### GET:api/Payments/id

Implement an API method which will fetch the status of a specific Payment

#### GET:api/Payments/from/to

Implement an API method which will fetch the status of multiple Payments in a given time period

#### POST:api/v2/Payments

Add a version 2 of the POST:api/Payment call which takes an int amount instead of decimal

## Overall considerations

* Async Await
* Dependency Injection
* Error Handling
* Input Validation
* Authentication
* Swagger

Discussion:
Explain some options of how you could host this application in a scalable and secure way.
