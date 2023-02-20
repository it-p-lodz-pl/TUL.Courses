# Course name #

> **Technologies of Adaptive Programming**

# Course name in Polish #

> **Technologie Programowania Adaptacyjnego**

# Programme #

Information Technology

# Form of classes and number of teaching hours per semester #

* **Lecture: 30**
* Tut: 0
* Lab: 0
* **Proj.: 30**
* Sem.: 0
 
# Goal #

The aim of the course is to expand students knowledge and improve skills of software development thanks to use selected technology and programming patterns to improve adaptability of the created program against the changing requirements and capabilities of the run-time production environment. This objective includes issues related to the practical knowledge of technology dedicated to postpone the decisions regarding software interoperability with .NET and the external environment. Students learn the selected technologies, design patterns, archetypes and their practical implementation in the .NET with the goal to be used while developing their own programs.

# Learning outcomes #

After completing the course students will:

1. evaluate and use the dynamic programming in .NET,
2. use the technologies enabling the program composition using the independently developed modules,
3. analyze and use the technologies to improve adaptability of the program against different process data repositories,
4. understand the need and apply a consistent configuration mechanism against a program composed of independently created modules,
5. analyze the need to track program activity and select programming technology to guarantee its adaptability at run-time,
6. test the proposed solutions based on the architecture of the program composed using a set of loosely coupled modules.

# Learning outcomes verification methods #

* Presentation on a given topic.
* Active participation in the discussion moderated by the teacher.
* Writing test.
* Assessment of project tasks.

# Prerequisites #

Knowledge of the following topics is required to understand the content:

* Object-oriented programming.
* Software Development Technologies.
* Component Programming.

# Course organization and content #

During the course adaptive programming is presented as a catalog of programming technologies used at the development and deployment stage with the goal to increase adaptability of the program against changing production environment in which it is executed.

## Lecture 

During the lecture the presentation of the selected topics is based on the source code snippets. The presentation is followed by a discussion on the following topics supporting the adaptive programming:

* most often occurring practical scenarios,
* available archetypes and design patterns,
* available libraries supporting discussed solutions,
* syntax and semantics of selected programming language,
* testing methods and tools.

In particular this covers such issues as:

* the dynamic creation of application domains, threads and types according to current needs,
* representation of the process data outside of the application domain,
* dynamic functionality composition of the program,
* program functional expandability using the modules developed independently (plugins)
* flexible selection of communication protocols,
* flexible selection of the process data repositories,
* flexible software configuration,
* customization of the application behavior tracking system,

The lecture is focused on the following topics:

* syntax and semantics of the C# patterns useful for adaptive programming
 * parallel and asynchronous programming;
 * reflection,
 * attributed programming model
 * dynamic programming
* expression representation and their translation as required by the target external system;
* architecture and programming patterns related to access external data based management systems:
	* materialization to save objects state and objects graph relationship using XML, JSON, etc.
	* object relation mapping,
* program composition using independently developed modules:
 * Dependency injection
 * functionality extension using modules developed independently (plug-in)
 * to assure the separation of responsibilities;
 * composition modules versioning,
 * application domain,
*  tracing of the program activities in the production environment:
 * multisource tracing systems,
 * semantic logging,
 * dynamic configuration of the logging,
 * cloud based tracing,
 * modules development reusable patterns promoting separation of concerns,
* systematic approach to configuration development:
 * the program as a one whole,
 * independently developed modules,
 * properties in the context of individual users,
* unit and integration tests:
 * testing environment requirements against the program composed using independently developed modules,
 * processing data simulation for testing purpose,
 * simulation of production environment behavior for testing purpose.    

## Project

Students are tasked to develop independent programs or achieve well defined steps of a project. The aim of this form of the course is to confirm ability to apply in practice the theoretical knowledge discussed during the lecture classes. The tasks are to design and run their own computer programs implementing the selected scenarios and testing the proposed solutions using unit tests. Each task is evaluated independently.

# Form of assessment #

Presentation and activity during discussion, one written test at the end of the semester and the successfully accomplished task of the laboratory classes. The final grade is based on the weighted average of 20% of activity in the tutorial classes (40%) for test and (40%) for the laboratory tasks.

To assess the laboratory tasks the following elements are considered:
* correctness, 
* due time, 
* compulsory presentation of the proposed solution.

# Basic reference materials #

* *C# 6.0. Kompletny przewodnik dla praktyków. Wydanie V*; Mark Michaelis, Eric Lippert; Wydawnictwo: Helion; 2016
* *Współbieżność w języku C#. Receptury*; STEPHEN CLEARY; Wydawnictwo: Helion; 2017
* *Dependency Injection in .NET*; Mark Seemann; Manning Publications; 2011
 
# Other reference materials #

* *Wzorce projektowe. Elementy oprogramowania obiektowego wielokrotnego użytku*; Erich Gamma; Helion; 2017
* *Oprogramowanie łatwe w utrzymaniu. Pisz kod podatny na przyszłe zmiany*; JOOST VISSER; Wydawnictwo: Helion; 2016
* *Reactive Programming for .NET Developers*; Antonio Esposito; Michael Ciceri; Packt Publishing; 2016
* *Entity Framework Core Cookbook - Second Edition*; Ricardo Peres; Packt Publishing; 2016 






