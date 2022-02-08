# Projekt Etap 2 - programowania asynchroniczne, sekcja krytyczna

## Cel

Celem zadania jest praktyczne poznanie:

- programowania asynchronicznego,
- implementacji koncepcji sekcji krytycznej,
- testowania jednostkowego i integracyjnego,
- wstrzykiwania zależności (ang. Dependency Injection) (opcja)
- wykorzystanie techniki MOCK (opcja)

## Opis zadania

Zmodyfikować uprzednio utworzony w etapie 1 program tak, tak aby uwzględnić, że kule:

- kule poruszając się pr trajektoriach zgodnych z fizyka zjawiska (brak tarcia)
  kule odbijają sie od siebie i od ścian (odbicie sprężyste bez straty energii)
- Przy wyznaczeniu kierunku poruszania się po odbiciu proszę masę kul i ich prędkość

Program będzie implementował warstwy: `Dane`, `Logika` i `Prezentacja`. Wymienione warstwy `Dane` i `Logika` muszą być testowane z wykorzystaniem testów jednostkowych. Bardziej szczegółowo warstwy te opisano w rozdziale **Architektura** opisu do zadania `Projekt Etap 1`.

## Wytyczne do realizacji

- Warstwa `Logiki` powinna reprezentować wszystkie operacje realizowane w tym procesie
- Proszę pamiętać, że `Dane` + `Logika` to sekcja krytyczna i rozwiązanie musi być odporne na zdarzenia jednoczesne, rozproszone
- Zachowania reaktywne proszę zaimplementować z wykorzystaniem interfejsów IObserver/IObservable
- Zachowania interaktywne proszę zaimplementować jako asynchroniczne z wykorzystaniem konstrukcji Task
- Proszę dodać testy jednostkowe dla ważniejszych operacji. Opcjonalnie proszę odprzęgnąć warstwy na potrzeby testowania używając DI lub MOCK.

**UWAGA**: rozwiązanie dalej będzie modyfikowane w celu uzyskania końcowej funkcjonalności, która opisana jest w kolejnych etapach

Do zrealizowania zadania można wykorzystać przykładowy kodu opublikowany w [C# in Practice - set of C# examples targeting education purpose](https://github.com/mpostol/TP).

## Zaliczenie

 W celu potwierdzenia osiągnięcia celu i zrealizowania zakresu zadania, w trakcie omawiania kodu programu należy wykazać, że zostały zrealizowane punkty z listy kontrolnej zamieszczonej w osobnym pliku. Przed oddaniem pracy do sprawdzenia, należy ten plik dodać do repozytorium i upewnić sie samemu, ze wszystkie punkty listy kontrolnej zostały zrealizowane.

## Lista źródeł

Do zrealizowania zadania można wykorzystać przykładowy kodu na [C# in Practice - set of C# examples targeting education purpose](https://github.com/mpostol/TP). Literatura uzupełniająca podana jest na stronie kursu.

### Zobacz też

- [Mocks Aren't Stubs](https://martinfowler.com/articles/mocksArentStubs.html)
- [How to test software, part I: mocking, stubbing, and contract testing](https://circleci.com/blog/how-to-test-software-part-i-mocking-stubbing-and-contract-testing/?gclid=Cj0KCQiAkePyBRCEARIsAMy5ScunlfHQKu8LF1w4pG9d4P10ChGBpIv8YNgJklqj0rOYGb3p7-kNe8saAjZYEALw_wcB)
- [mpostol/TP/DistributedProgramming](https://github.com/mpostol/TP/tree/master/DistributedProgramming)
- [Programowanie Reaktywne](https://github.com/mpostol/TP/tree/master/AdaptiveProgramming/ConcurrentProgramming)
- [Repo for managing Moq 4.x](https://github.com/moq/moq4)
- [Moq 4.13.1](https://www.nuget.org/packages/Moq/4.13.1)
