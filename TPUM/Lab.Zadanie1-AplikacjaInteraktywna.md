# Aplikacja Mobilna

**UWAGA:** opis zostanie uzupełniony w miarę potrzeb.

## Cel

Celem zadania jest praktyczne poznanie:

- technologii Web-sockets
- reaktywnego i interaktywnego współdziałania aplikacji, a w tym
  - architektury client/server
  - architektury publisher/subscriber
- wykorzystanie standardów do reprezentowania modeli współdziałania aplikacji wytworzonych przez różnych producentów
- wstrzykiwania zależności (ang. Dependency Injection)
- testowania jednostkowego i integracyjnego
- wykorzystanie techniki MOCK

## Opis zadania

Opracować program z wykorzystaniem technologi .NET, który będzie realizował rolę klienta i serwera. Z wykorzystaniem tych ról należy zapewnić wymianę wybranych danych strukturalnych pomiędzy instancją klienta i serwera. Należy zrealizować następujące  scenariusze wymiany danych:

- zapytanie/odpowiedź - klient wysyła żądanie, a sewer odpowiada danymi w zależności od otrzymanego zapytania
- samorzutne wysyłanie/filtrowanie - serwer  wysyła dane samorzutnie, natomiast klient filtruje je zgodnie z potrzebami
- publikowanie/subskrypcja - klient zamawia dane (subskrybuje), a serwer wysyła (publikuje) samorzutnie do niego wybrane dane w ramach subskrypcji

Klient/serwer komunikuje się ze sobą z wykorzystaniem technologii Web-sockets.

Przesyłąne dane muszą być opisane z wykorzystaniem wspólnego modelu obiektowego i reprezentować wybrany model biznesowy, np.

- system antywłamaniowy,
- samochód
- ogrzewanie mieszkania
- blister z lekami
- grę komputerową

Dane przesyłać z wykorzystaniem serializacji zgodnie ze skłądnią JSON, YAML, XML. Wybór składni musi być dostępny w interfejsie użytkownika aplikacji serwera. Klient musi rozpoznawać skłądnię reaktywnie na podstawie otrzymywanych danych.

Poprawność programu należy sprawdzić z wykorzystaniem testów jednostkowych i testów integracyjnych.

Opracować model danych z wykorzystaniem standardu OPC Unified Architecture i harmonizować używany model objektowy z modelem wygenerowanym automatycznie przez wybrane narzędzie.

Opracować program z wykorzystaniem technologi .NET, który będzie realizował rolę publisher'a i subscriber'a. Z wykorzystaniem tych ról należy zapewnić wymianę wybranych danych strukturalnych pomiędzy instancją publisher'a i subscriber'a.

### Wytyczne do realizacji

Dodatkowe informacje ułatwiające wykonanie zadania:

- ważne jest, aby rola aplikacji była określona przez łatwo dostępny przy uruchomieniu parametr
- proszę zwrócić uwagę na konieczność zastosowania technologi programowania reaktywnego dla wybranych scenariuszy
- niezbędna jest umiejętność wytłumaczenia czym różni się współdziałanie reaktywne od interaktywnego, synchroniczne od asynchronicznego
- zaoszczędzisz czas, jeśli do wykonania zadania zostaną wykorzystane podane poniżej dostępne przykłady
- proszę zwrócić uwagę, aby dane był strukturalne niezależnie od wybranego realizowanego modelu biznesowego
- do realizacji podstawowych funkcji programu nie trzeba stosować wstrzykiwania zależności
- ważne jest, aby współdzielone dane były chronione sekcją krytyczną
- pomocne w implementacji testów jednostkowych w miejsce testów integracyjnych jest wstrzykiwanie zależności i koncepcja MOCK

## Zaliczenie

Warunkami koniecznymi dopuszczenia do dalszego zaliczania zadania są:

1. Brak błędów kompilatora po wyciągnięciu nowej kopii kodu z repozytorium
1. Pozytywne wyniki testów jednostkowych
1. Pozytywne wyniki testów integracyjnych
1. Zastosowanie wstrzykiwania zależności do realizacji testów
1. Wyświetlenie określonych wyników z wykorzystaniem wybranego interfejsu użytkownika
1. Utworzenie wskazanych plików

W trakcie zaliczenia mogą być poruszane zagadnienie związane z:

- umiejętnością wskazania miejsc występowania i wytłumaczenia różnicy pomiędzy programowaniem reaktywny, a programowaniem interaktywnym
- umiejętnością wskazania miejsc występowania i wytłumaczenia różnicy pomiędzy programowaniem asynchronicznym, a programowaniem synchronicznym
- umiejętnością wskazania miejsc występowania sekcji krytycznej i jej implementacji
- wykazania, że aplikacja jest warstwowa i wskazani granic warstw
- wskazaniem w programie miejsc odpowiedzialnych za produkowanie danych procesowych, komunikację pomiędzy instancjami programu, itp.
- omówienie w kontekście programu wykorzystania obiektu DTO (ang. Data Transfer Object)

## Lista źródeł

- [Mocks Aren't Stubs](https://martinfowler.com/articles/mocksArentStubs.html)
- [How to test software, part I: mocking, stubbing, and contract testing](https://circleci.com/blog/how-to-test-software-part-i-mocking-stubbing-and-contract-testing/?gclid=Cj0KCQiAkePyBRCEARIsAMy5ScunlfHQKu8LF1w4pG9d4P10ChGBpIv8YNgJklqj0rOYGb3p7-kNe8saAjZYEALw_wcB)
- [The WebSocket Protocol; Request for Comments: 6455](https://tools.ietf.org/html/rfc6455)
- [Web-sockets implementacja na GitGub w repozytorium `mpostol/NBlockchain`](https://github.com/mpostol/NBlockchain)
- [Programowanie Reaktywne](https://github.com/mpostol/TP/tree/master/AdaptiveProgramming/ConcurrentProgramming)
- [Repo for managing Moq 4.x](https://github.com/moq/moq4)
- [Moq 4.13.1](https://www.nuget.org/packages/Moq/4.13.1)
- [Przykładowa implementacja repliki procesu - symulator boilerów](https://github.com/mpostol/OPC-UA-OOI/tree/master/Networking/Simulator.Boiler)
