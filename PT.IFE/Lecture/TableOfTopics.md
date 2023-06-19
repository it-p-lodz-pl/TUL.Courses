# Table of topics

## Lesson 1: Introduction

1. About the course,
2. Information Technology - Executive Summary
   - information versus data, type concept,
   - algorithm versus program,
   - Program Layered Design Pattern
3. Useful assets: C# language, Visual Studio, GitHub
4. Program robustness
   - exception,
   - unit tests,

## Lesson 2, 3: Data semantics

1. Type concept
1. Anonymous type
1. Partial types and methods
1. Generics

## Lesson 4, 5: Data streams

1. File and Stream Concepts
1. Reflection
1. Attributes
1. Serialization

## Lesson 6, 7: Functional programming basics

1. Anonymous function and lambda expression
1. Extension method

## Lesson 8: Structural Data - LINQ to object (Part 1)

1. LINQ query syntax
   - TP.StructuralData.LINQQueryAndMethodsSyntax.LinqQuerySyntaxExamples
   - LinqQuerySyntaxExamples.AnonymousType()

## Lesson 9: Structural Data - LINQ to object (Part 2)

1. LINQ methods syntax
   - TP.StructuralData.LINQQueryAndMethodsSyntax.LinqMethodSyntaxExamples
   - LinqMethodSyntaxExamples.AnonymousType()
1. LINQ to object
   - TP.StructuralData.LINQ_to_object.Catalog
   - DataSet
   - Catalog.PersonDataTable.FilterPersonsByLastName_ForEach(string)
   - Catalog.PersonDataTable.FilterPersonsByLastName_QuerySyntax(string)
   - Catalog.PersonDataTable.FilterPersonsByLastName_MethodSyntax(string)

## Lesson 10. Structural Data - LINQ to SQL (Part 1)

- Database
  - Server Explorer
- Structure data
- Object relation Model
- LINQ to SQL - introduction

## Lesson 11: Structural Data - LINQ to SQL (Part 2)

- LINQ to SQL - introduction (Catalog.dbml)
- Object relation Model (Catalog.designer.cs)
- LINQ query syntax, methods syntax (Catalog.cs, LINQ_to_SQLDataServiceUnitTests.cs)

## Lesson 12 Graphical data (Part 1)

1. Graphical data - preface
   - interactive, reactive user interface
   - computer/user interactions
2. MVVM - Inter-layer communication - delegates, events, commands
   - `INotifyPropertyChanged`, `ViewModelBase`
   - `ICommand`, RelayCommand

## Lesson 13 Graphical data (Part 2)

1. MVVM (Model, View, ViewModel) layered design pattern
   - View
     - Example: `TP.GraphicalData.View`
     - xaml details: [xaml](https://docs.microsoft.com/dotnet/framework/xaml-services/)
     - Communication: View => ViewModel: DataContext, events, ICommand, `Binding`, reflection, RelayCommand
     - Testing
   - ViewModel
     - Example: `TP.GraphicalData.ViewModel`
     - Communication: ViewModel => View : events, `INotifyPropertyChanged`, `ViewModelBase`
     - Testing: MVVMLightUnitTest, MainViewModel, independent testing
   - Model
     - `TP.GraphicalData.Model`,
     - independent testing, DataLayerTestMethod
2. Application bootstrapping
   - GraphicalData.View - project settings
   - App - application
   - MainWindow
   - Application configuration

## Lesson 14 Review

- Information versus data
- Object Oriented Programming (inheritance, polymorphism, abstraction)
- Language selected constructs
  - Anonymous type
  - Delegate, Event
  - Generics
  - Extension method
  - Partial types and methods
- Streaming data
  - File, Stream
  - using statement and IDisposable
  - Serialization
- Structural data
  - LINQ to SQL
  - LINQ query and methods syntax
  - Database connection
- Program architecture
  - Layered Design Pattern
  - Inter layer communication
    - delegates
    - events
    - Inversion of control
    - Dependency injection
    - Reactive programming
  - Presentation layer
    - mvvm
    - the View layer; xaml

## Lesson 15 Test
