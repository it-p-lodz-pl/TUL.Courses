# Test question bank  <!-- omit from toc -->

## Table of content <!-- omit from toc -->

- [1. Inheritance](#1-inheritance)
  - [1.1. question text](#11-question-text)
  - [1.2. Grading](#12-grading)
- [2. LINQ – source variable](#2-linq--source-variable)
  - [2.1. Question Text](#21-question-text)
  - [2.2. Grading](#22-grading)
- [3. Information versus date](#3-information-versus-date)
  - [3.1. Question text](#31-question-text)
  - [3.2. Grading](#32-grading)
- [4. Events](#4-events)
  - [4.1. Question text](#41-question-text)
  - [4.2. Grading](#42-grading)
- [5. Generic class](#5-generic-class)
  - [5.1. Question text](#51-question-text)
- [6. LINQ to SQL](#6-linq-to-sql)
  - [6.1. Question text](#61-question-text)
  - [6.2. Grading](#62-grading)
- [7. Program architecture](#7-program-architecture)
  - [7.1. Question text](#71-question-text)
  - [7.2. Grading](#72-grading)
- [8. Using statement](#8-using-statement)
  - [8.1. Question text](#81-question-text)
  - [8.2. Grading](#82-grading)
- [9. Polymorphism](#9-polymorphism)
  - [9.1. Question text](#91-question-text)
  - [9.2. Grading](#92-grading)
- [10. Delegate variable](#10-delegate-variable)
  - [10.1. Question text](#101-question-text)
  - [10.2. Grading](#102-grading)
- [11. Extension Method vs Inheritance](#11-extension-method-vs-inheritance)
  - [11.1. Question text](#111-question-text)
  - [11.2. Grading](#112-grading)
- [12. Implementation of an abstract method](#12-implementation-of-an-abstract-method)
  - [12.1. Question text](#121-question-text)
  - [12.2. Grading](#122-grading)
- [13. Lambda expression](#13-lambda-expression)
  - [13.1. Question text](#131-question-text)
  - [13.2. Grading](#132-grading)
- [14. LINQ extension](#14-linq-extension)
  - [14.1. Question text](#141-question-text)
  - [14.2. Grading](#142-grading)
- [15. Partial classes and methods](#15-partial-classes-and-methods)
  - [15.1. Question text](#151-question-text)
  - [15.2. Grading](#152-grading)

## 1. Inheritance

### 1.1. question text

In object-oriented programming, the [Term 1] is a mechanism that allows a new classes creation based on existing ones. A new class is called the [Term 2] class, a subclass or a child class, and the class on the basis of which we create the [Term 2] class, we call the [Term 3] class or a superclass. As a result of [Term 1], the [Term 2] class receives ([Term 1]) all fields and methods of the [Term 3] class.

| Entry  |      Text      |
| :----: | :------------: |
| Term 1 |  inheritance   |
| Term 2 |    derived     |
| Term 3 |      base      |
|        |  polymorphism  |
|        |  abstraction   |
|        | implementation |
|        |    variant     |
|        |    generic     |
|        |    primary     |
|        |     source     |

### 1.2. Grading

| Column A      | Column B  |
| ------------- | --------- |
| defaultgrade  | 8.0       |
| penalty       | 0.3333333 |
| question type | matching  |

## 2. LINQ – source variable

### 2.1. Question Text

LINQ is a technology that allows selection and access to a data source, which is represented in the form of an object in the computer program. What conditions must be met by the object class - a data source representation in the LINQ expression. Which of the following statements meets the requirements of the necessary condition?

- It must implement IQueryable or IEnumerable
  - Yes, it must implement IEnumerable. IQuerable is derived from IEnumerable, so in all cases the source object implements IEnumerable.
- It must implement IQueryable
  - It is an incorrect answer because it is not necessary in the general case.
- It must implement IEnumerable.
  - Yes, it must always implement IEnumerable.
- It must implement IDisposable.
  - This is a wrong answer, the IDisposable implementation is not required.
- To be able to represent external data, it must implement IQueryable or IEnumerable.
  - It must implement IQueryable, so it is not enough to implement IEnumerable.
- To be able to represent external data, I must implement IQueryable.
  - Yes, it must implement IQuerable so that you may be able to implement an access mechanism to an external source.
- To be able to represent external data, it must implement IEnumerable
  - This is not enough because it prevents the implementation of mechanisms to access an external source.
- To be able to represent external data, it must implement IDisposable.
  - This is a wrong answer, the IDisposable implementation does not matter, although often this interface is implemented to make easier object lifetime management.

### 2.2. Grading

| Element       | Value       |
| ------------- | ----------- |
| defaultgrade  | 8.0         |
| penalty       | 0.3333333   |
| question type | multichoice |

## 3. Information versus date

### 3.1. Question text

Computer science is a discipline dealing with the automation of the [Term 1] processing. To describe the [Term 1] processing, a [Term 2] is necessary, which specifies the sequence of operations to be performed in order to process the [Term 1] input set into the [Term 1] result set. The problem is that [Term 17] are abstract - it's a kind of knowledge about what and how to process. Consequently, they can not be directly used by machines built around known physical laws. To materialize it, a [Term 4] is used to represent [Term 17]. [Term 4] allows for the formal description of [Term 17] in the form of a text. The basis for materialization is the alphabet, which is a set of alphanumeric characters represented in the modern processing machine environment as a finite sequence of bits. After compilation of the program text, a result can be executed using the selected runtime environment, which means creating [Term 5]. [Term 5] is a set of threads, each of which is responsible for implementing the sequence of instructions described in the program, and [Term3], which are created during the thread's execution. The condition for creating [Term 5] is to give it [Term 6], which is inherited after the session if the program is running by the user within an existing session or configured if the program (service) is run by the operating system or on behalf of another user. [Term 6] associated with the [Term 5] is used to authorize operations whose [Term 5] execution can be requested from the environment, for example, an operating system. The lack of possibility to perform such an operation will be the occurrence of an exception, which must be handled, otherwise, the thread action will be interrupted, which in turn may cause the [Term 5] termination.

### 3.2. Grading

| Element       | Value       |
| ------------- | ----------- |
| defaultgrade  | 10.00       |
| penalty       | 0.3333333   |
| question type | multichoice |

## 4. Events

### 4.1. Question text

An event is a dedicated kind of variable (value holder) of delegate type that we use to signal the occurrence of selected conditions. Which of the following statements are true considering the definition where it is defined as a publisher.

> Note: Incorrect responses are punished with negative points.

- Subscriber methods are called immediately when the condition to be signaled is met
  - Wrong, an additional instruction is required to call the subscribed methods, and the statement that the necessary condition is met only enables to use of the event in the method call statement (invocation).
- Calling an event requires a method invocation syntax that runs all subscriber methods with the current arguments.
  - This is the correct answer, all methods with current parameters according to the delegation type declaration are called in an unpredictable sequence by the caller.
- The correctness of the event call is possible because the event has the type of value returned by the subscribing methods.
  - This is the wrong answer, for all methods must be given current arguments strongly typed against the definition of the delegate type.
- After the event has been raised (invoked), all subscribed methods are executed independently of the publisher, i.e. the instructions following the event invocation are carried out **asynchronously** with the published.
  - It is the wrong answer. All methods are executed in the sequence (synchronously) of the even invoking statement, so they must end before the next publisher's instruction begins.

### 4.2. Grading

| Element       | Value       |
| ------------- | ----------- |
| defaultgrade  | 10.00       |
| penalty       | 0.3333333   |
| question type | multichoice |

## 5. Generic class

### 5.1. Question text

The generic type allows parameterization of the types that are used in it, eg. argument types, types of returned values, etc. Parameterization introduces, however, the problem that the definition is undefined, i.e. only on its basis cannot be inferred about the semantic code correctness - you cannot always check type compatibility. Select which of the statements are true:

> **Note**: Incorrect responses are punished with negative points.

- Always usage of a class must contain enough information to specify a parameter so that strict type checking is possible at the design time.
  - Well, the class at the time of instantiating the object or inheritance must be concrete by specifying a selected type or a derived class parameter, and therefore full control of the compatibility of the type is possible at the design time by the compiler.
- By introducing restrictions on the class parameter type, you can eliminate the problem of the lack of specification.
  - It is the wrong answer, constraints on the type of parameter are not related to type compliance control, but only define additional features of the parameter that can be used in the implementation of the class.
- If it is not possible to check the compatibility of generic types at the design time, this control is carried out at the program execution stage.
  - It is the wrong answer. To create a generic class object, you must define its type parameters, so it is always possible to check the compatibility of the generic types at the design time. During the program execution, type control is performed only when the selected value is cast on and is performed in the same way as for non-energy types.
- For a generic class to become a concrete class, for example, you can create a derived class (inheriting from it) and specify a type parameter.
  - Wrong, during the inheritance a new type is created, so it can not be said that Inheritance is a method of defining a parameter. Although it is true that inheriting from the generic class, we must define its type parameter, which may be a specific type or its own type parameter, if the derived class is also generic.
-The introduction of restrictions on the generic class parameter type limits the applicability scope of this class but instead gives the author of the class the possibility of using certain features resulting from the restrictions
  - Well, all restrictions on the generic parameter type are intended to indicate additional features but it reduces the set of compliant types that may be used, which, of course, allows you to take advantage of the features resulting from the limitation.

## 6. LINQ to SQL

### 6.1. Question text

LINQ (Language Integrated Query) is an expandable (adaptable to individual needs, e.g. enabling access to own data sources) technology. To expand the usage capability the  IEnumerable and IQuerable interfaces have to be implemented. One such extension is LINQ to SQL. Choose the correct statement in the context of this technology.

- The extension was implemented by adding new methods to extend the IEnumerable interface.
  - No, this is impossible because the only way to extend the LINQ technology is to implement the IQuerable interface.
- The extension was implemented by adding new methods for extending the IQueryable interface.
  - No, this is impossible because the only way to extend the LINQ technology is to implement the IQuerable interface.
- The extension is achieved by implementing the IEnumerable interface.
  - No, this is impossible because this interface has no members allowing access to external data sources.
- The extension is achieved by implementing the IQueryable interface.
  - It is a correct answer.  The only possibility of extending LINQ technology is a custom implementation of the IQuerable interface.
- The extension is achieved by adding new classes implementing the IQueryable interface.
  - This is the correct answer because the only possibility to extend the LINQ technology is a custom implementation of the IQuerable interface.
- The extension has to be implemented by adding new classes to the System.Data.Linq namespace.
  - This is not true, because the only possibility to extend the LINQ usage is a custom implementation of the IQuerable interface, and placing classes in the selected namespace is not equivalent to this condition. But it is true that this namespace contains classes responsible for the proper implementation of the IQuerable interface for LINQ to SQL.

### 6.2. Grading

| Element       | Value       |
| ------------- | ----------- |
| defaultgrade  | 10.00       |
| penalty       | 0.3333333   |
| question type | multichoice |

## 7. Program architecture

### 7.1. Question text

In order to allow reusability, and facilitate teamwork and testing, usually, the program architecture is based on a layered pattern that implements a selected set of functions depending on the chosen model. During the classes, we referred to the following layered models:

- Presentation, logic, data
- View, Model View, and Model (MVVM)

What concepts, language constructs, and technologies can be used to implement such an approach:

### 7.2. Grading

| Element       | Value       |
| ------------- | ----------- |
| defaultgrade  | 10.00       |
| penalty       | 0.3333333   |
| question type | multichoice |

- Abstraction (Interface, abstract class) allows you to hide irrelevant implementation details in front of users and allows you to work simultaneously on a foundation of a common contract.
  - This is a good answer, in fact, abstraction facilitates the use of layered architecture.
- LINQ (Language Integrated Query) technology that allows you to standardize access to data from the layer.
  - This is an incorrect answer - LINQ allows you to create expressions that are intended to select a subset of entities from a data source.
- No specialized concepts, constructions, and technologies are necessary to apply the selected layered architecture in practice.
  - This is also the correct answer, but in practice, you have to signal the existence of layers by a set of definitions with a top-down relationship.
- Separate compilation units that allow you to create independently developed and tested components.
  - This is, of course, the right answer, separate compilation is the basic tool for implementing layers and ensuring the independence of the layer from its user.
- The reflection that allows access to the program's metadata (layer) and the use of a layer without direct access to the definition of functionality offered by its API (application program interface).
  - While the reflection may be useful in some specific cases to implement layers, this is not the underlying technology for this concept. Therefore, this answer cannot be considered correct.
- The abstraction allows the user layer to implement the selected functionality in several different ways.
  - This is the wrong answer. Abstraction, as noted in the answer, affects the implementation of functionality, but not what is offered in terms of functionality.

## 8. Using statement

### 8.1. Question text

In the .NET environment, the lifecycle of instantiated objects is automated, i.e. it does not usually require a developer to handle directly the object end of life stage. However, there are exceptions to this rule and sometimes appropriate action is needed. Choose correct sentences. 

> Note: incorrect answers have a penalty factor.

### 8.2. Grading

| Element       | Value       |
| ------------- | ----------- |
| defaultgrade  | 10.00       |
| penalty       | 0.3333333   |
| question type | multichoice |

- If no program variable has references to it the object is immediately deleted and resources associated with it are released.

> This is not a correct answer, because the object is automatically handled by the Garbage Collector in this case, but the destructor could be called with a delay that is practically unpredictable.

- The object's end of life is immediately handled by calling the Dispose method if it:
  - implements the `IDisposable` interface,  and
  - is created by the `using` statement, and
  - and the block of the instruction has ended.

> Of course, this is a correct answer. `using` calls `Dispose` method just after the last statement in its block or as a result of an exception.

- The object end of life is immediately handled and the resources released if it:
  - implements the interface `IDisposable`
  - and the method `Dispose` is called in the program

> Of course, this is a good answer. It is not necessary and sometimes impossible to use the `using` statement, in which case you have to call the `Dispose` method manually.

- The object does not have to be manually deleted using the `IDisposable.Dispose` method or by using the `using` statement if we release external resources via other methods of this object, eg `Stream.Close`

> Of course, this is a good answer. It is essential to release external resources so that the object doesn't block them, and the release of memory can be implemented on general principles.

- If one object wraps (creates) another object inheriting from the `IDisposable` interface, it must implement the `IDisposable` interface, as in the example below:

```C#

class UsingIDisposable: IDisposable
{
   private Stream m_Stream;
   //
   // ...
   //
}
```

> This is an incorrect answer, although there are cases when this approach is correct. Again, if the object referred by m_Stream is disposed of in the object creating it, the `IDisposable` implementation is not needed.

## 9. Polymorphism

### 9.1. Question text

- Different behavior when calling a method, depending on the type of object against which the method is called, we call:
  - Polymor*: This is a polymorphism that allows you to implement the same method in a variety of ways and override the abstract definition.

### 9.2. Grading

| Element       | Value       |
| ------------- | ----------- |
| defaultgrade  | 4.0         |
| penalty       | 0.3333333   |
| question type | shortanswer |

## 10. Delegate variable

### 10.1. Question text

- The delegate variable stores the reference to an expression, which is to be used to calculate its value.
  - _true_: Yes, this sentence is incorrect. Its value is the reference to the methods collection, not the expression.
  - **false**: Unfortunately, this sentence is incorrect. Its value is the reference to the methods collection, not the expression.

>NOTE: wrong association of comments

### 10.2. Grading

| Element       | Value     |
| ------------- | --------- |
| defaultgrade  | 4.0       |
| penalty       | 1.0000000 |
| question type | truefalse |

## 11. Extension Method vs Inheritance

### 11.1. Question text

- Extension methods are especially useful in situations when you need to implement abstract methods in a type that we do not have access to, for example, the type is defined in the .NET library.
  - _true_: Extension methods cannot be used to implement abstract methods defined in abstract classes or interfaces.
  - **false**: Yes, that's a good answer. Extension methods cannot be used to implement abstract methods defined in abstract classes or interfaces.

### 11.2. Grading

| Element       | Value     |
| ------------- | --------- |
| defaultgrade  | 4.0       |
| penalty       | 1.0000000 |
| question type | truefalse |

## 12. Implementation of an abstract method

### 12.1. Question text

- The implementation of properties and methods in derived classes is the basis for the polymorphic programming approach. So the only way to implement an abstract property or method is Inheritance and override the definition in the inheriting class.
  - **true**: That's a good answer.  To implement an abstract property or method the block must be defined. This can only be done by overring in the derived class.
  - _false_: Unfortunately, this sentence is correct. To implement an abstract property or method the block must be defined. This can only be done by overring in the derived class.

### 12.2. Grading

| Element       | Value     |
| ------------- | --------- |
| defaultgrade  | 4.0       |
| penalty       | 1.0000000 |
| question type | truefalse |

## 13. Lambda expression

### 13.1. Question text

- The lambda expression is a construct that allows the definition of an anonymous method and specifies a reference to it. This reference can then be added to the delegate or event variables.
  - true: That's a good answer.
  - false: Unfortunately, this sentence is correct.

### 13.2. Grading

| Element       | Value     |
| ------------- | --------- |
| defaultgrade  | 4.0       |
| penalty       | 1.0000000 |
| question type | truefalse |

## 14. LINQ extension

### 14.1. Question text

- `LINQ` is an expandable (adaptable to individual needs, e.g. providing access to own data sources) technology, in which the methods for extending `IEnumerable` and `IQuerable` interfaces have been defined. To expand it you have to define your additional extension methods to expand these interfaces.
  - _true_: Yes, this sentence is incorrect, because the only possibility of extending this technology is a custom implementation of the IQuerable interface.
  - **false**: Unfortunately, this sentence is incorrect, because the only possibility of extending this technology is a custom implementation of the IQuerable interface.

### 14.2. Grading

| Element       | Value     |
| ------------- | --------- |
| defaultgrade  | 4.0       |
| penalty       | 1.0000000 |
| question type | truefalse |

## 15. Partial classes and methods

### 15.1. Question text

- Similar to the abstract class, in the partial class, all partial methods (only the header defined for them) must be implemented so that the class can be used to create objects.
  - _true_: Unfortunately, this sentence is incorrect. The partial methods for which block of statements are not defined are removed from the code, so they do not have to be implemented.
  - **false**: Yes, this sentence is incorrect. The partial methods for which a block of statements is not defined are removed from the code, so they do not have to be implemented.

### 15.2. Grading

| Element       | Value     |
| ------------- | --------- |
| defaultgrade  | 4.0       |
| penalty       | 1.0000000 |
| question type | truefalse |