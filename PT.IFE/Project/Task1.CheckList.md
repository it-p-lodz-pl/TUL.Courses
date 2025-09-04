# Task 1 Check list

``` TXT
- [ ] **to get started**
  - [ ] create a tag according to the [semantic versioning](https://semver.org/) compliant with the following syntax 1.a.n where: 1: task number (1 for this stage); a: approach number [1..3]; n: any number you like.
  - [ ] The task's completion has been submitted to WIKAMP for grading purposes (it requires grading). The feedback must include the tag identifier and the name of the folder used to clone the repository.
  - [ ] repository contains a program to be used as a starting point - text is in C# and use .NET
  - [ ] build succeeded
  - [ ] The program has layered architecture and contains at least `logic`, and `data` layers
  - [ ] layers are clearly stated **using language terms** only
- [ ] **Data Layer**
  - [ ] layer is clearly stated (no database or file access is required)
  - [ ] layer interface is abstract
  - [ ] layer responsibility is to implement object model representing data of a selected process 
    - [ ] structured data is used to create object model including:
      - [ ] Users: a collection of all actors relevant to the implemented business process (e.g.: readers, customers, suppliers, etc)
      - [ ] Catalog: a dictionary of the goods descriptions (e.g.: books, good )
      - [ ] Process state: description of the current process state (e.g: the current content of the shop, library, etc.)
      - [ ] Events:  description of all events contributing to the process state change in time.
    - [ ] dependency injection is used (additional framework is not required)
- [ ] **Logic Layer**
  - [ ] layer is clearly stated
  - [ ] layer interface is abstract
  - [ ] layer uses only the abstract interface of the `Data` layer
  - [ ] layer responsibility is to implement the main program functionality of a selected process 
- [ ] **Testing**
  - [ ] the main functionality of the program must be unit-tested - all UTs are green
  - [ ] Unit Test - 2+ testing data generation methods for data layer 
  - [ ] layers are tested independently
  - [ ] only code in the solution is tested
```
