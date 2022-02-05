# Projekt Etap 2 - programowania asynchroniczne, sekcja krytyczna

## Cel

Celem zadania jest praktyczne poznanie:

- Komunikacji klient/serwer z wykorzystaniem `Web Socket`
- reaktywnego i interaktywnego interfejsu warstwy komunikacyjnej,
- testowania jednostkowego i integracyjnego,
- wstrzykiwania zależności (ang. Dependency Injection) (opcja)
- wykorzystanie techniki MOCK (opcja)

## Opis zadania

Opracować dwa programy z wykorzystaniem technologi .NET, które będą pełniły rolę klienta i sewera - podzielić uprzednio utworzony w etapie 1 program na współdziałające części, tak abu utworzyć aplikację rozproszoną o architekturze klient/serwer. Innymi słowy należy wyróżnić dwa niezależne programy komunikujące sie przez sieć komputerową i pozwalające na automatyzację wybranego uprzednio procesu biznesowego.

Każdy z wymienionych programów będzie implementował warstwy: `Dane`, `Logika` i `Prezentacja`. Wymienione warstwy `Dane` i `Logika` muszą być testowane z wykorzystaniem testów jednostkowych. Bardziej szczegółowo warstwy te opisano w rozdziale **Architektura** opisu do zadania `Projekt Etap 1 - interaktywna/reaktywne programowanie`.

Komunikację pomiędzy klientem i serwerem należy zrealizować z wykorzystaniem `Web Socket`.

API warstwy KOMUNIKACYJNEJ (WARSTWA DANYCH (klient)/PREZENTACJI (serwer)) MUSI zawierać operacje interaktywne (np. zakup czegoś) i reaktywne (okresowe wysłanie PIT'u, zamówień, itp.)

## Wytyczne do realizacji

- Oba programy powinny być w tym samym `Solution`. VS pozwala uruchomić dwie instancje programów jednocześnie.
- Warstwę `Prezentacja` i `Dane` (odpowiednio dla sewera i klienta) proszę zrealizować z wykorzystaniem komunikacji `Web Socket`,
- Warstwa `Logiki` powinna reprezentować wszystkie operacje realizowane w wybranym procesie odpowiednio dla klienta i serwera
- Proszę pamiętać, że `Dane` + `Logika` to sekcja krytyczna i rozwiązanie musi być odporne na zdarzenia jednoczesne, rozproszone
- Zachowania reaktywne proszę zaimplementować z wykorzystaniem interfejsów IObserver/IObservable
- Zachowania interaktywne proszę zaimplementować jako asynchroniczne z wykorzystaniem konstrukcji Task
- Proszę dodać testy jednostkowe dla ważniejszych operacji. Opcjonalnie proszę odprzęgnąć warstwy na potrzeby testowania używając DI lub MOCK.

- **UWAGA**: rozwiązanie dalej będzie modyfikowane w celu standaryzacji komunikacji poprzez sieć.

Do zrealizowania zadania można wykorzystać przykładowy kodu opublikowany w [C# in Practice - set of C# examples targeting education purpose](https://github.com/mpostol/TP).

## Zobacz też

- [Mocks Aren't Stubs](https://martinfowler.com/articles/mocksArentStubs.html)
- [How to test software, part I: mocking, stubbing, and contract testing](https://circleci.com/blog/how-to-test-software-part-i-mocking-stubbing-and-contract-testing/?gclid=Cj0KCQiAkePyBRCEARIsAMy5ScunlfHQKu8LF1w4pG9d4P10ChGBpIv8YNgJklqj0rOYGb3p7-kNe8saAjZYEALw_wcB)
- [The WebSocket Protocol; Request for Comments: 6455](https://tools.ietf.org/html/rfc6455)
- [mpostol/TP/DistributedProgramming](https://github.com/mpostol/TP/tree/master/DistributedProgramming)
- [Web-sockets implementacja na GitGub w repozytorium `mpostol/NBlockchain`](https://github.com/mpostol/NBlockchain)
- [Programowanie Reaktywne](https://github.com/mpostol/TP/tree/master/AdaptiveProgramming/ConcurrentProgramming)
- [Repo for managing Moq 4.x](https://github.com/moq/moq4)
- [Moq 4.13.1](https://www.nuget.org/packages/Moq/4.13.1)
