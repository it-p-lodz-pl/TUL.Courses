# Task 1 - Collections, Unit Tests, Dependency Injection

## Goal

- Implement selected business process, namely: library, shop, warehouse, etc. using layered application - only logic and data is required.  
- Define data layer using the .NET collection in an example application to:
  - create a catalog, e.g. product catalog, list of clients,
  - register events, e.g. a list of invoices,
  - maintain the state description, e.g. library status, inventory status.
- Define logic layer to implement all relevant operation,
- Defining API for the library (public declarations),
- Using of the Dipendency Injection pattern (testing, various data formats, etc.)
- Using unit test to prove corectness of the proposed solution.

## Description

### `Data` layer

The data layer should be implemented in an library project. This layer must contain the all the classes representing the data relevant for the selected process. The classes name should be meningfull, i.e. represent the contained data. Use references to model the data relationship.

Thefolowing information should be represented:

- Users: collection of all actors relevant for the implemented business process (e.g.: reders, customers, supplayers, etc).
- Catalog: dictionary of the goods descriptions (e.g.: books, good ), przy czym:
- Process state: description of the current process state (e.g: content of the shop, library, etc.).
- Events:  description of all events contributingto the porocess state change in time.

### `Logic` layer

This layer should provide all functionality relevant for the selecte business process.  

### Unit Tests

Use Unit test to to prove corectness of the proposed solution During the preparation phase the test must initialize the data beeing processed. Dipendency Injection is very helpful to implement this functionality. 
 
## Notes

1. There should be provide at least two data generation method.
2. `Logic` and `Data` must be implemented in the library. 
3. Thre is no need to implement presentation layer, but if implemented must be in separte excutable project.  
 
## See also

- [Dependency Injection](https://en.wikipedia.org/wiki/Dependency_injection)
- [TP on GitHub](http://github.com/mpostol)   
- [Martin Fowler, Inversion of Control Containers and the Dependency Injection pattern](http://www.martinfowler.com/articles/injection.html)  
- [ Mark Seemann, Dependency Injection in .NET](https://www.manning.com/books/dependency-injection-in-dot-net)
- [Factories, Service Locators, and Dependency Injection](https://msdn.microsoft.com/en-us/library/dn178469.aspx):


