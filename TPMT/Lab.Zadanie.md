# Zadanie

## Cel

Głównym celem zadania jest zrozumienie podstaw:

- Warstwowej architektury aplikacji
- Refleksji i technik mock
- Wstrzykiwania zależności (ang. Dependency Injection)
- Testów jednostkowych
- Testów integracyjnych
- Testów interfejsu użytkownika
- Ciągłej integracji

## Opis zadania

Opracować program z wykorzystaniem technologi ASP .NET Core, który będzie odczytywał metadane z wybranego pliku dll/exe (ang. Portable Executable) korzystając z mechanizmu refleksji. Odczytane dane zastaną zapisane w pamięci w postaci modelu obiektowego. Dane te zostaną udostępnione użytkownikowi za pośrednictwem interfejsu graficznego (GUI).

Dla programu należy opracować testy jednostkowe, integracyjne oraz funkcyjne dla interfejsu użytkownika. Należy również zapewnić ciągłą integrację z wykorzystaniem usługi [Azure DevOps][DevOps].

## Wymagania

1. Z wykorzystaniem mechanizmu refleksji analizowanie zawartości wybranej .dll i zapisanie możliwie dużo informacji o zawartości wybranego pliku do utworzonego modelu obiektowego w pamięci
1. Wyświetlić zawartości utworzonego modelu obiektowego użytkownikowi z wykorzystaniem technologii ASP .NET
1. Wszystkie ważniejsze funkcje muszą być testowane z wykorzystaniem wymienionych powyżej testów

## Funkcje

1. Odczyt metadanych z wybranego za pośrednictwem GUI komponentu .dll/.exe
1. Wyświetlenie metadanych w postaci hierarchicznej z wykorzystaniem drzewa pokazującego wzajemne zależności konstrukcji językowych

## Wytyczne do realizacji

Dodatkowe informacje ułatwiające wykonanie zadania:

- zaoszczędzisz czas, jeśli do wykonania zadania zostaną wykorzystane podane poniżej dostępne przykłady
- do realizacji podstawowych funkcji programu nie trzeba stosować wstrzykiwania zależności
- pomocne w implementacji testów jednostkowych w miejsce testów integracyjnych jest wstrzykiwanie zależności i koncepcja MOCK

## Zaliczenie

Warunkami koniecznymi dopuszczenia do dalszego zaliczania zadania są:

1. Brak błędów kompilatora po wyciągnięciu nowej kopii kodu z repozytorium
1. Pozytywne wyniki testów jednostkowych
1. Pozytywne wyniki testów integracyjnych
1. Zastosowanie wstrzykiwania zależności do realizacji testów
1. Wyświetlenie określonych wyników z wykorzystaniem wybranego interfejsu użytkownika

W trakcie zaliczenia mogą być poruszane zagadnienie, które pozwolą potwierdzić że Student rozumie omawiane zagadnienia i umie je samodzielnie wdrożyć.

## Lista źródeł

1. [Język C# w praktyce. Kurs video. Przetwarzanie danych zewnętrznych](https://videopoint.pl/kurs/jezyk-c-w-praktyce-kurs-video-przetwarzanie-danych-zewnetrznych-mariusz-postol,vjcprv.htm#format/w)
1. [TP - projekt open source na GitHub zawierający przydatny kod przykładowy](https://github.com/mpostol/TP)
1. [Introduction to ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-3.1)
1. [Tutorial: Get started with ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/getting-started/?view=aspnetcore-3.1&tabs=windows)
1. [Build, test, and deploy .NET Core apps](https://docs.microsoft.com/en-us/azure/devops/pipelines/ecosystems/dotnet-core?view=azure-devops)
1. [Azure Pipelines documentation][DevOps]
1. [Mocks Aren't Stubs](https://martinfowler.com/articles/mocksArentStubs.html)
1. [How to test software, part I: mocking, stubbing, and contract testing](https://circleci.com/blog/how-to-test-software-part-i-mocking-stubbing-and-contract-testing/?gclid=Cj0KCQiAkePyBRCEARIsAMy5ScunlfHQKu8LF1w4pG9d4P10ChGBpIv8YNgJklqj0rOYGb3p7-kNe8saAjZYEALw_wcB)

[DevOps]: https://docs.microsoft.com/en-us/azure/devops/pipelines/?view=azure-devops
