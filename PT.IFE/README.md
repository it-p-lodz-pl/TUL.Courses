# TP IFE

## Table of Content

- [TP IFE](#tp-ife)
  - [Table of Content](#table-of-content)
  - [Preface](#preface)
    - [WIKAMP Content URL](#wikamp-content-url)
  - [Course Administration](#course-administration)
    - [Course Settings](#course-settings)
      - [Course full name](#course-full-name)
      - [Course short name](#course-short-name)
      - [Course category](#course-category)
      - [Course start date](#course-start-date)
      - [Course ID number](#course-id-number)
  - [Course Summary](#course-summary)


## Preface

### WIKAMP Content URL

- [URL](https://ife.edu.p.lodz.pl/course/view.php?id=224)

## Course Administration

### Course Settings

#### Course full name

- Programming Technologies

#### Course short name

- PT

#### Course category

- III year

#### Course start date

- 2024-02-26

#### Course ID number

- 07 67 4040 30

## Course Summary

### Self enrollment

To enroll in this course use the key: `PT`. After enrolling, you must select a project group. Ask the course supervisor in case of any questions or problems you may have.

### Subject

Computer science in general, and especially the development of computer programs, is a field of knowledge that deals with the automation of information processing. Programs can be recognized as a driving force of that automated behavior. To accomplish information processing goals programs have to manage external data engaged to control the graphical user interface (graphical data), stored by database management systems (structure data) and file systems (streaming data).  Hence, external data management - apart from implementing the algorithms – is a key issue for automation of the entire information processing and computer science in general. The external data is recognized as a process information representation handled outside of the program execution realm.

Let's review selected language constructs, design patterns, and frameworks targeting programming in practice discipline in the context of eternal data processing.

### Goal

The course aims are to extend knowledge and skills related to object-oriented programming focusing on interoperability between the computing process and data visualization, archiving, and networking environment. Particular emphasis is placed on the identification of solutions that can serve as a certain design pattern with the widest possible use over a long-term horizon.

To ensure the practical context of the discussion and provide sound examples, all topics are illustrated using the C# language and the Visual Studio design environment. The source code used during the course is publicly available in a GitHub repository. I believe that the proposed principles, design patterns, and scenarios are generic and may be seamlessly ported to other environments. The language and tools mentioned above have been used only to embed the discussion in a particular environment and to ensure that the course is very practical.

The course discusses solutions for practical scenarios regarding various aspects of process data management, i.e. those that are input or output for the business logic of the program. In general, external data is recognized as the data we must pull to or push from outside of a boundary of the process hosting the computer program. In general, the external data may be grouped as follows:

- **streaming** - bitstreams managed using content of files, or network payload
- **structural** - data fetched/pushed from/to external database management systems using queries
- **graphical** - data rendered on Graphical User Interface (GUI)

### Learning Effects

1. The student knows and understands in practice the syntax of C# programming language and the structure of the .NET Framework together with the basics of the applications development process using a dedicated programming environment including but not limited to unit tests.
1. The student knows and understands in practice selected software design patterns (including but not limited to the program layered architecture, and dependency injection) and their practical implementations in the .NET Framework.
1. The student knows and understands in practice programming rules related to collections, database access, and developing graphical user interfaces.

### Subject Detailed Content

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
  - Inter-layer communication
    - delegates
    - events
    - Inversion of control
    - Dependency injection
    - Reactive programming
  - Presentation layer
    - MVVM
    - the View layer; xaml

### Preliminary Requirements

- Basics of Programming
  - C# constructs (syntax and semantics) fundamentals
  - Object-oriented Programming concept basics
  - XML fundamentals
  - XAML constructs (syntax and semantics) fundamentals
  - program development architecture basics
- MS Visual Studio development environment fundamentals
  - create solution
  - create project
  - unit testing  fundamentals
- Operating System functionality fundamentals
- Algorithms and Data Structures
