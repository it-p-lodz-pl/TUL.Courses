# TP IFE

## Course Administration

### Preface

#### Kod: 07 67 5030 17

#### Course title: Programming Technologies

#### Course objective

1. Allow students to become familiar with the syntax of C# programming language and the structure of .NET Framework together with the basics of applications development process using a dedicated programming environment.
2. Allow students to become familiar with known software design patterns and their practical implementations in .NET Framework.
3. Allow students to acquire practical software development skills for .NET Framework while using the Visual Studio development environment.

#### [WIKAMP Content](https://ife.edu.p.lodz.pl/course/view.php?id=224)

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

### Forum

I have been asked by the University Authority to harmonize the schedule with the current situation, and especially the late enrolment of some course members. I agree with that so I decided to postpone the deadline for Task 1 from lesson 5 (10-11-2020) to lesson 6 (17-11-2020). 

During the next laboratory, we will repeat the same agenda as for lesson 4, and as a result, you will have the opportunity to reserve a place in the line to validate your code against my environment and assessment rules. Again, it is your opportunity but not a requirement. Add to the code everything you believe is useful for you. In other words, everything is allowed but only a few things are required.  

**My advice is - keep things as simple as possible to avoid a surprise.**

Contact me directly in any case questions or proposals you may have.

### Task 1 Check list publication

As I did promise today I have just published the file `Task 1 Check list.md` to help you apply self-assessment. Copy the content of this file to a new GitHub issue to get a list of tasks prefixed by checkboxes. You can use them to control the scope and progress of your work. Add an issue like that before the final code assessment. 
BTW; let stress again. To accomplish Task 1 is not required

- to use external data sources, as files, databases, etc.
- to use any additional framework (if someone can do something in the framework we can do it in code for sure).

Anyway, using any external stuff is not required but possible. There is only one rule: if you are using something additional you must be prepared to explain how it works. Let me stress all requirements and all topics on the checklist are invariable.

#### Enrolment message on forum

Welcome to the Programming Technologies course! We are excited to have you as part of our membership. After enrolling, you must select a group using the [module Laboratory group selection](https://ife.edu.p.lodz.pl/mod/choicegroup/view.php?id=11193).

The laboratory classes will be conducted using the Microsoft Teams platform. You must register to the [team 21-Programming Technology](https://teams.microsoft.com/l/team/19%3a37d33599bd774b1dbd926850bc224665%40thread.tacv2/conversations?groupId=3c895cdd-60dd-474e-af38-74ca916dd49f&tenantId=67ea5955-9b5c-4693-a8f9-960f2a3b49bb).

You have been enrolled as you are on the students' list I have got. Unenroll from PT, and contact me immediately if you have been enrolled in this group by mistake.

## Section `General`

## Section `Lecture`

### Table of topics

#### Lesson 1: Introduction

1. About the course, information versus data, algorithm versus program, type - what does it mean
1. Useful assets: C# language, Visual Studio, GitHub
1. Program robustness: exception, unit tests, environment simulation

#### Lesson 2: Data semantics

1. Type concept
1. Anonymous type
1. Partial types and methods
1. Generics

#### Lesson 3: Data streams

1. File and Stream Concepts
1. Attributes
1. Reflection
1. Serialization

#### Lesson 4: Functional programming basics

1. Anonymous function and lambda expression
1. Extension method

#### Lesson 5: Structural Data

1. LINQ query and methods syntax
1. LINQ to object

#### Lesson 6: Structural Data

1. LINQ to SQL

#### Lesson 7 Graphical data

1. Delegates and events
1. [xaml](https://docs.microsoft.com/dotnet/framework/xaml-services/)
1. MVVM (Model, View, ViewModel) pattern

## Section `Laboratory`

### Laboratory Schedule

- Week \#01
  - About the curse
  - Prerequisites
- Week \#02 (help needed - there will be a reward !!)
  - Introduction to development environment
  - Programming in pairs, Test Driven Development, Dependency Injection
- Week \#03 - Q/A: Task 1 and Task 2 detailed description
- Week \#04..05 - Environment compatibility
- Week \#06..09 - Task 1
- Week \#10..15 - Task 2

Laboratory classes are conducted on the Teams platform. Join the team [21-Programming Technology](https://teams.microsoft.com/l/team/19%3a37d33599bd774b1dbd926850bc224665%40thread.tacv2/conversations?groupId=3c895cdd-60dd-474e-af38-74ca916dd49f&tenantId=67ea5955-9b5c-4693-a8f9-960f2a3b49bb)

#### Tasks deadline

The task completion must be reported up to 24:00 the day before the date enumerated in the following table.

|  Task  | Deadline [week (date)] |
| :----: | :--------------------: |
| Task 1 |    06 (17.11.2020)     |
| Task 2 |    10 (15.12.2020)     |

##### **Notes:**

- Scores for one task 10..20
- The task completion must be reported up to 24:00 the day before. To report completion you must create a release in the GitHub repository and press the submit button of the appropriate task.
- **Late report decreases the max score by 2.5 a week.**

### Laboratory group selection

All participants must be a member of one laboratory group. Use this module to select the group you prefer. The number of members is limited.

Table: List of available groups
|  Name   | Description                                        |
| :-----: | -------------------------------------------------- |
| 2020.10 | Laboratory class starting at **Tuesday at 10:15**. |
| 2020.12 | Laboratory class starting at **Tuesday at 12:15**. |

### Task 1

#### UMLDiagram

#### CheckList

- Title:  Task 1 Check list
- Copy the content of the file to a new GitHub issue to get a list of tasks prefixed by checkboxes you can use to control the scope and progress of your work.

### Lab - Alternative Path

Referring to my promise regarding the possibility of implementing a more ambitious project, instead of task 2, I have a question:

Is there anyone willing to follow the alternative path to pass the lab?

I will ask for information as soon as possible because the task needs to be prepared in advance. The project must be carried out in three stages.

Contact me by email or on the Teams platform.

### GitHub README.md template file

Your repository must have the `README.md` file prepared according to this template. Place the README.md file in the main directory of the repository. A GUID is required for identification. This GUID can be generated using `VS \ Tools \ Create GUID`. Don't use example GUIDs embedded in the template.

### Lab \04 Reservation

#### Message

I would like to invite you to a remote Laboratory class as part of the course **Programming Technologies**. Laboratory classes are conducted on the Teams platform.

Please book a time-slot for the classes using the appropriate module ` Lab 04 Reservation`. Our goal is to check the progress of your work and the compatibility of the design environments. In the comment field, please enter the URL of your GitHub repository, which will be used to carry out the tasks included in the course program. In the same field, you should also put the GUIDs previously placed in the README.md file of the repository. The GUID can be generated using `VS\Tools\Create GUID`.

Let me stress, your repository must have the `README.md` file prepared according to the template `GitHub README.md template file` published on WIKAMP. Place the README.md file in the main directory of the repository. A GUID is required for identification. This GUID can be generated using `VS \ Tools \ Create GUID`. Don't use example GUIDs embedded in the template.

#### Reservation module

- \<data\> Lab \04 Reservation

Please book a time-slot for # 4 laboratory using this module to check the progress of your work and compatibility of design environments. In the comment field, please enter the URL of your GitHub repository, which will be used to carry out the tasks included in the course program. In the same field, you should also put the GUIDs previously placed in the README.md file of the repository. The GUID can be generated using `VS \ Tools \ Create GUID`.

## Section `Recordings`

### Recording page

```txt
This section contains:

- Video recordings of the selected classes.
- activity - files with the corrected Q/A dialog on chat
```

> File name: `<Date> [LectureRecording|LaboratoryRecording] #<numer> <title>|LectureActivity`

### WIKAMP Forum

### I have just published the last lecture recording and activity 

Let me inform you that I have just published the last lecture outcomes. They are available in the section [Recordings](https://ife.edu.p.lodz.pl/course/view.php?id=224#section-3). This section contains a lecture recording and also file with the corrected Q/A dialog on chat. Review the file and report your result using `Seminar activity` - each answer = 1 pts. Report your scores using comments. Your achievement must be reported before the next lecture.

#### NOTE

1. The list contains just acceptable answers. Most of them are not suitable to pass the final test. The list reflects your activity but not the correctness of your answers.
1. During your workout assessment, you will have to prove that something is true without any doubts using only terms defined by the programming language (usually any programming language).
1. Sometimes I may be wrong, so if you believe that your answer was correct but it has been removed from the list don't hesitate and schedule a meeting with me to get more and review your answers.

#### How to improve your correctness

1. Use only terms defined by the language (usually any programming language), e.g. set of classes versus set of functionality. 
2. Use an unambiguous ("measurable" ) description that allows the creation of a condition to distinguish if something is true or not, e.g. how to distinguish if two items are tightly or loosely coupled.
3. Take care to distinguish the software life cycle, i.e. talk about classes in the context of software development, talk about objects (instances of the classes) in the context of program execution.

## Section `References`

### Online

- [csharp (C#) Teaching of Programming (TP)](https://github.com/mpostol/TP#csharp-c-teaching-of-programming-tp-)
- [C# programming guide](https://docs.microsoft.com/dotnet/csharp/programming-guide/)
- [What is .NET? [1 of 8]](https://channel9.msdn.com/Series/NET-Core-101/What-is-NET)
- [C# documentation](https://docs.microsoft.com/dotnet/csharp/)
- [Welcome to .NET](https://docs.microsoft.com/dotnet/welcome)

### Books examples

- [Język C# w praktyce. Kurs video. Przetwarzanie danych zewnętrznych](https://videopoint.pl/kurs/jezyk-c-w-praktyce-kurs-video-przetwarzanie-danych-zewnetrznych-mariusz-postol,vjcprv.htm#format/w) in polish.
- Ch. Nagel, Professional C# 6 and .NET Core 1.0, 2016.
- M. Michaelis, E. Lippert, Essential C# 6.0, 2015.
- J. Hilyard, S. Teilhet, C# 6.0 Cookbook, 2015.

## Internal
