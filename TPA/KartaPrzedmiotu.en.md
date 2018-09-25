# Course name #

> **Technologies of Adaptive Programming**

# Course name in Polish #

> **Technologie Programowania Adaptacyjnego**

# Programme #

Information Technology

# Form of classes and number of teaching hours per semester #

* Lecture: 0
* **Tut: 30**
* Lab: 0
* **Proj.: 30**
* Sem.: 0
 
# Goal #

The aim of the course is to expand students knowledge and improve skills of software development thanks to using technology and programming patterns to enable adaptation of the created program against the changing requirements and capabilities of the run-time production environment. This objective includes issues related to the practical knowledge of technology dedicated to postpone the decisions regarding software interoperability with .NET and the external environment. Students learn the selected technologies, design patterns, archetypes and their practical implementation in the .NET with the goal to be used while developing their own programs.

# Learning outcomes #

After completing the course students will:

* know syntax and understand semantics of the selected C# language grammar productions related to the parallel programming, reflection and attribute-based programming,
* understand and practically knew how to take advantage of dynamically created types and representation of expressions,
* know how to use serialization to save the state of objects and their relationships using grammars such as XML, JSON, etc.
* be able to develop a program, which functionality will be composed using dependency injection and search services in a types dictionary,
* use the open architecture of the program ready to be extended by functionality offered by components developed independently (add-on),
* integrate into the program diagnostic mechanisms allowing to track its run-time behavior,
* apply reusable design patterns to promote separation of concerns while developing the program components,
* knew practically available solutions against coherent configuration of the program as a one whole, components, and the properties in the context of individual users,
* effectively test the proposed solutions,

# Learning outcomes verification methods #

* Presentation on a given topic.
* Active participation in the discussion moderated by the teacher.
* Colloquium.
* Assessment of project tasks.

# Prerequisites #

To understand the content requires the knowledge of:

* Object-oriented programming.
* Software Development Technologies.
* Component Programming.

Also helpful is the knowledge and skills acquired on completion of courses:

* Software engineering.
* Design-systems.

# Course organization and content #

The classes are conducted in the form of tutorial and project.

During the tutorial classes students prepare presentations according to the selected subjects. Presentation of the problem is illustrated by an individually developed source code. The code is placed in the repository to allow track changes. The presentation is followed by the discussion with all present students moderated by the teacher. As part of the discussion available scenarios, main goals and the solutions scope applicability are disused. Presentation and active participation in the discussion are independently evaluated.

In the project, students are tasked to develop independent programs or steps of a project. The aim of this form of the course is to confirm ability to apply in practice the theoretical knowledge discussed during the tutorial classes. The students' task is to design and run their own computer programs implementing the selected scenarios and testing the proposed solutions using unit tests. Each task is evaluated independently.

The scope of classes has been selected so that it is a natural continuation of the issues previously discussed in the context of the items listed in the section *Prerequisites*. The subject of the curse is focused on issues related to the development of an adoptable computer program in the context of changing production environment. Discussed issues concern reusable solutions for typical scenarios of environmental changes. The application of such solutions reduces development costs and improve the quality of the software. To avoid indiscriminate use of the available solutions each considered proposal is discussed in details.

To acquire the practical skills by the students in addition to theoretical knowledge the discussed issues are illustrated using selected tools, namely: the programming language C#, MS Visual Studio and .NET. The assumption is that the choice of specific development tools does not limit the general nature of the discussion.

Selected matter of the discussion concerns available artifacts that relate to and support adaptive programming, including but not limited to:

* most often occurring practical scenarios,
* available archetypes and design patterns,
* available libraries supporting discussed solutions,
* syntax and semantics of selected programming language,
* testing methods and tools.

During the course adaptive programming is presented as a set of technologies that can be used to meet the growing need for adaptability of already written computer programs against changing production environment in which it is executed. This concerns in particular such issues as:

* the dynamic creation of application domains, threads and types according to current needs,
* representation of the process data outside of the application domain,
* dynamic functionality composition of the program,
* program functional expandability using the modules developed independently (plugins)
* flexible selection of communication protocols,
* flexible selection of the process data repositories,
* flexible software configuration,
* customization of the application behavior tracking system,

Today, computers are equipped with a number of multi-core processors. Another topic of the discussion, therefore, is related to the provisioning of appropriate mechanisms for controlling the execution of the program in a parallel processing environment. Selected C# language grammar productions related to parallel programming, reflection, attribute-based programming and integrated declarative programming are analyzed in detail in the context of their applicability for adaptive programming.

The serialization is recognized as the technology particularly useful for the solutions enabling dynamic adaptation of a computer program to a changing environment. Serialization is used to save the state of objects and their relationships using grammars such as XML, JSON, etc. During the discussion related to this topic students analyze selected implementations of this technology and evaluate their advantages and disadvantages in context of adaptive programming. Being aware these advantages and disadvantages is helpful to properly select specific implementation against requirements of the dynamically changing production environment.

Run-time adaptation of the already developed program in a production environment can be supported by the following technologies:

* configuration,
* attribute-based programming,
* dependency injection,
* independently developed add-on modules.

Each of these solutions has its drawbacks and advantages, which are discussed in detail in class. There are also different implementations supporting these scenarios. They are analyzed in terms of applicability for the selected scenarios and in the context of well-known design patterns.

The implementation of any algorithm requires a computer program. Its execution often requires access to the meta-data to control the program and the environment run-time behavior. Parameters of the selected grammar productions, such as classes, methods, formal parameters of methods, etc. can be defined using attributes. Access to data defined by attributes are implemented using the concept of reflection, that is, the ability to read the meta-data of the program, including details of the type definitions and created objects.

A major problem related to deployment of adaptive programming is necessity to postpone relevant for reliability decisions up to run-time and the need to compose the program using independently developed modules. These requirements significantly affect the methods of testing of the computer program at design-time. These issues are only indirectly related to adaptive programming, but due to its importance for the final quality of the product they are also the subject of detailed analysis in terms of the requirements definitions and solutions selection with the goal to improve the quality and assure the separation of responsibilities.

There are many scenarios where tracing of the program activities is essential. There are also variety of solutions  addressed to this problem in a particular environment. Discussion  related to this topic is focused on the possibility to adapt the built-in program tracking mechanism against the current needs and capabilities of the production environment.

# Form of assessment #

Presentation and activity during discussion, one written test at the end of the semester and the successfully accomplished task of the laboratory classes. The final grade is based on the weighted average of 20% of activity in the tutorial classes (40%) for test and (40%) for the laboratory tasks.

To assess the the laboratory tasks the following elements are considered:
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






