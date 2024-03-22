# Projekt Etap 2 - interaktywna/reaktywna komunikacja

## Cel

Celem zadania jest praktyczne poznanie:

- Komunikacji klient/serwer z wykorzystaniem `Web Socket`
- reaktywnego i interaktywnego interfejsu warstwy komunikacyjnej,
- testowania jednostkowego i integracyjnego,
- wstrzykiwania zależności (ang. Dependency Injection) (opcja)
- wykorzystanie techniki MOCK (opcja)

## Opis zadania

Opracować dwa programy z wykorzystaniem technologi .NET, które będą pełniły rolę klienta i sewera - podzielić uprzednio utworzony w etapie 1 program na współdziałające części, tak abu utworzyć aplikację rozproszoną o architekturze klient/serwer. Innymi słowy należy wyróżnić dwa niezależne programy komunikujące się przez sieć komputerową i pozwalające na automatyzację wybranego uprzednio procesu biznesowego.

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

## Lista źródeł

Do zrealizowania zadania można wykorzystać przykładowy kodu na [C# in Practice - set of C# examples targeting education purpose](https://github.com/mpostol/TP). Literatura uzupełniająca podana jest na stronie kursu.

## Zaliczenie

W celu potwierdzenia osiągnięcia celu i zrealizowania zakresu zadania, w trakcie omawiania kodu programu, mogą byc poruszane zagadnienia z nim związane. W celu poprawy obiektywności do zadania dołączyłem listę kontrolną, która musi być wypełniona.
