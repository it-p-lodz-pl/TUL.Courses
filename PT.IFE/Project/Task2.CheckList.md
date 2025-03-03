# Task 2 Check list

``` txt
- [ ] **to get started**
  - [ ] Create a tag identifier according to the [semantic versioning](https://semver.org/) compliant with the following syntax 2.a.n where: 2: task number (2 for this stage); a: approach number [1..3]; n: any number you like.
  - [ ] the task's completion has been reported on the WIKAMP for grading purposes. The feedback must contain the tag identifier.
  - [ ] text is in C# and use .NET
  - [ ] build succeeded
  - [ ] The program has layered architecture and contains at least `presentation`, `logic`, and `data` layers
  - [ ] layers are clearly stated using language terms only
- [ ] **Data Layer**
  - [ ] layer responsibility is to 
  - [ ] Object model representing process data (reuse it from Task1)
  - [ ] `Data` layer is implemented using external SQL database and should be defined using LINQ to SQL (ORM)
  - [ ] LINQ (method and query syntax) is used to fetch data from the database
- [ ] **Logic Layer**
  - [ ] the layer is clearly stated
  - [ ] the layer API is abstract and clearly stated
  - [ ] the layer uses only the abstract `Data` layer API
  - [ ] the layer must be tested independently using 2+ data generation methods
  - [ ] layer responsibility is to implement the main program functionality of a selected process 
- [ ] **Presentation Layer**
  - [ ] the layer must be implemented in accordance with the `Model-View-ViewModel` (`MVVM`) software pattern
  - [ ] `Presentation` - the layer must contain Master-Detail pattern
  - [ ] `View Model` is tested independently
  - [ ] `View Model` use dependency injection for testing purpose (additional framework is not required)
  - [ ] `Model` uses only the abstract `Logic` layer API
  - [ ] layer responsibility is to implement the main program functionality of a selected process 
- [ ] **Testing**
  - [ ] the main functionality of the program must be unit-tested - all UTs are green
  - [ ] Unit Test - 2+ testing data generation methods for data layer 
  - [ ] layers are tested independently
  - [ ] only code in the solution is tested
```
