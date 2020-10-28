# TP IFE

## Introduction

### Kod: 07 67 5030 17

### Course title: Programming Technologies

### Course objective

1. Allow students to become familiar with the syntax of C# programming language and the structure of .NET Framework together with the basics of applications development process using a dedicated programming environment.
2. Allow students to become familiar with known software design patterns and their practical implementations in .NET Framework.
3. Allow students to acquire practical software development skills for .NET Framework while using the Visual Studio development environment.

### [WIKAMP Content](https://ife.edu.p.lodz.pl/course/view.php?id=224)

## Administration

### Edit Settings

### Course summary

#### Self enrollment

To enroll use the key: `PT`. After enrolling, you must select a laboratory group.

#### Subject

Computer science in general, and especially programming activities, is a field of knowledge that deals with the automation of information processing. Programs can be recognized as a driving force of that automated behavior. To achieve information processing goals programs have to implement algorithms required by the application concerned. In other words, the programs describe how to process data, which represent information relevant to the application. Data management - apart from the implementation of the algorithms – is, therefore, a key issue for automation of the entire information processing and computer science in general.

Let's review selected language constructs, patterns, and frameworks targeting data-intensive programming.

#### Goal

The aim of the course is to extend knowledge and skills related to object-oriented programming focusing on interoperability between the computing process and data visualization, archiving, and networking environment. Particular emphasis is placed on the identification of solutions that can serve as a certain pattern with the widest possible use over a long-term horizon. Providing a long-term horizon is extremely difficult for such a dynamically developing field. Here, the experience of the author comes to the rescue, who has been employing similar solutions for years using constantly changing programming tools.

To ensure the practical context of the discussion and provide sound examples, all topics are illustrated using the C# language and the Visual Studio design environment. The source code used during the course is publicly available in a GitHub repository. I believe that the proposed principles, design patterns, and scenarios are generic and may be seamlessly ported to other environments. The language and tools mentioned above have been used only to embed the discussion in a particular environment and to ensure that the course is very practical.

The course discusses solutions for practical scenarios regarding various aspects of process data management, i.e. those that are input or output for the business logic of the program. In general, three classes of data have been distinguished:

- streaming (i.e. files, network packets)
- structural (i.e. databases)
- graphical: (i.e. Graphical User Interface)

### Self enrollment settings

#### Custom welcome message

Welcome to the Programming Technologies course! We are excited to have you as part of our membership. After enrolling, you must select a laboratory group.

#### Enrolment message on forum

Welcome to the Programming Technologies course! We are excited to have you as part of our membership. After enrolling, you must select a group using the [module Laboratory group selection](https://ife.edu.p.lodz.pl/mod/choicegroup/view.php?id=11193).

The laboratory classes will be conducted using the Microsoft Teams platform. You must register to the [team 21-Programming Technology](https://teams.microsoft.com/l/team/19%3a37d33599bd774b1dbd926850bc224665%40thread.tacv2/conversations?groupId=3c895cdd-60dd-474e-af38-74ca916dd49f&tenantId=67ea5955-9b5c-4693-a8f9-960f2a3b49bb).

You have been enrolled as you are on the students' list I have got. Unenroll from PT, and contact me immediately if you have been enrolled in this group by mistake.

## General

## Lecture

## Lecture Schedule

### Lesson 1: Introduction

1. About the course, information versus data, algorithm versus program, type - what does it mean
1. Useful assets: C# language, Visual Studio, GitHub
1. Program robustness: exception, unit tests, environment simulation

### Lesson 2: Data semantics

1. Type concept
1. Anonymous type
1. Partial types and methods
1. Generics

### Lesson 3: Data streams

1. File and Stream Concepts
1. Attributes
1. Reflection
1. Serialization

### Lesson 4: Functional programming basics

1. Anonymous function and lambda expression
1. Extension method

### Lesson 5: Structural Data

1. LINQ query and methods syntax
1. LINQ to object

### Lesson 6: Structural Data

1. LINQ to SQL

### Lesson 7 Graphical data

1. Delegates and events
1. [xaml](https://docs.microsoft.com/dotnet/framework/xaml-services/)
1. MVVM (Model, View, ViewModel) pattern

## Laboratory

### Laboratory Schedule

- Week \#01
  - About the curse
  - Prerequisites
- Week \#02 (help needed - there will be a reward !!)
  - Introduction to development environment
  - Programming in pairs, Test Driven Development, Dependency Injection
- Week \#03 - Q/A: Task 1 and Task 2 detailed description
- Week \#04 - Environment compatibility
- Week \#05..09 - Task 1
- Week \#10..15 - Task 2

Laboratory classes are conducted on the Teams platform. Join the team [21-Programming Technology](https://teams.microsoft.com/l/team/19%3a37d33599bd774b1dbd926850bc224665%40thread.tacv2/conversations?groupId=3c895cdd-60dd-474e-af38-74ca916dd49f&tenantId=67ea5955-9b5c-4693-a8f9-960f2a3b49bb)

### Tasks deadline

The task completion must be reported up to 24:00 the day before the date enumerated in the following table.

|  Task  | Deadline [week (date)] |
| :----: | :--------------------: |
| Task 1 |    05 (10.11.2020)     |
| Task 2 |    10 (15.12.2020)     |

#### **Notes:**

- Scores for one task 10..20
- The task completion must be reported up to 24:00 the day before. To report completion you must create a release in the GitHub repository and press the submit button of the appropriate task.
  
#### **NOTE: Late report decreases the max score by 2.5 a week.**

### Laboratory group selection

All participants must be a member of one laboratory group. Use this module to select the group you prefer. The number of members is limited.

Table: List of available groups
|  Name   | Description                                        |
| :-----: | -------------------------------------------------- |
| 2020.10 | Laboratory class starting at **Tuesday at 10:15**. |
| 2020.12 | Laboratory class starting at **Tuesday at 12:15**. |

## Lab - Alternative Path

Referring to my promise regarding the possibility of implementing a more ambitious project, instead of task 2, I have a question:

Is there anyone willing to follow the alternative path to pass the lab?

I will ask for information as soon as possible because the task needs to be prepared in advance. The project must be carried out in three stages.

Contact me by email or on the Teams platform.

## References

### Online

- [csharp (C#) Teaching of Programming (TP)](https://github.com/mpostol/TP#csharp-c-teaching-of-programming-tp-)
- [C# programming guide](https://docs.microsoft.com/dotnet/csharp/programming-guide/)
- [What is .NET? [1 of 8]](https://channel9.msdn.com/Series/NET-Core-101/What-is-NET)
- [C# documentation](https://docs.microsoft.com/dotnet/csharp/)
- [Welcome to .NET](https://docs.microsoft.com/dotnet/welcome)

## Books examples

- [Język C# w praktyce. Kurs video. Przetwarzanie danych zewnętrznych](https://videopoint.pl/kurs/jezyk-c-w-praktyce-kurs-video-przetwarzanie-danych-zewnetrznych-mariusz-postol,vjcprv.htm#format/w) in polish.
- Ch. Nagel, Professional C# 6 and .NET Core 1.0, 2016.
- M. Michaelis, E. Lippert, Essential C# 6.0, 2015.
- J. Hilyard, S. Teilhet, C# 6.0 Cookbook, 2015.

## Internal
