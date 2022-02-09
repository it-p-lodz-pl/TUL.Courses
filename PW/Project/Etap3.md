# Projekt Etap 3 - programowanie równoległe i czasu rzeczywistego

## Cel

Celem zadania jest;

- programowania asynchronicznego,
- implementacji koncepcji programowania czasu rzeczywistego,
- potwierdzenia wykorzystania programowania równoległego,
- testowania jednostkowego i integracyjnego,
- wstrzykiwania zależności (ang. Dependency Injection) (opcja)
- wykorzystanie techniki MOCK (opcja)

## Opis zadania

W tym etapie należy wykorzystać uprzednio stworzoną aplikację, w której dodatkowo należ wbudować elementy programowania czasu rzeczywistego, a więc zaimplementować takie  algorytmy, które będą wymagały wykorzystania czynnika czasu. Przykładowo może to być mechanizm logowania do pliku danych diagnostycznych o zachowaniu się kulek. W takim przykładzie należy uwzględnić możliwość chwilowego braku odpowiedniej przepustowości kanałów zapisu do pliku. Dane diagnostyczne do zapisu powinny byc przygotowane z wykorzystaniem serializacji zgodnie ze składnią JSON, YAML, XML.

Ten etap służy również do zaimplementowania tych wymagań, które w poprzednich etapach zostały przyjęte warunkowo.

Poprawność programu należy sprawdzić z wykorzystaniem testów jednostkowych i testów integracyjnych.

### Wytyczne do realizacji

Dodatkowe informacje ułatwiające wykonanie zadania:

- proszę zwrócić uwagę na konieczność zastosowania technologi programowania reaktywnego dla wybranych scenariuszy
- niezbędna jest umiejętność wytłumaczenia czym różni się programowanie reaktywne od interaktywnego, synchroniczne od asynchronicznego i czasu rzeczywistego
- zaoszczędzisz czas, jeśli do wykonania zadania zostaną wykorzystane dostępne przykłady
- do realizacji podstawowych funkcji programu nie trzeba stosować wstrzykiwania zależności
- ważne jest, aby współdzielone dane były chronione sekcją krytyczną
- Prawidłowa implementacja sekcji krytycznej, zapobieganie zjawisku wyścigu i poprawna synchronizacja współbieżnych wątków są krytyczne dla programowania czasu rzeczywistego
- pomocne w implementacji testów jednostkowych w miejsce testów integracyjnych jest wstrzykiwanie zależności i koncepcja MOCK

## Zaliczenie

W celu potwierdzenia osiągnięcia celu i zrealizowania zakresu zadania, w trakcie omawiania kodu programu należy wykazać, że zostały zrealizowane punkty z listy kontrolnej zamieszczonej w osobnym pliku. Przed oddaniem pracy do sprawdzenia, należy ten plik dodać do repozytorium i upewnić sie samemu, ze wszystkie punkty listy kontrolnej zostały zrealizowane.

## Lista źródeł

Do zrealizowania zadania można wykorzystać przykładowy kodu na [C# in Practice - set of C# examples targeting education purpose](https://github.com/mpostol/TP). Literatura uzupełniająca podana jest na stronie kursu.

## Zobacz też

- [Mocks Aren't Stubs](https://martinfowler.com/articles/mocksArentStubs.html)
- [How to test software, part I: mocking, stubbing, and contract testing](https://circleci.com/blog/how-to-test-software-part-i-mocking-stubbing-and-contract-testing/?gclid=Cj0KCQiAkePyBRCEARIsAMy5ScunlfHQKu8LF1w4pG9d4P10ChGBpIv8YNgJklqj0rOYGb3p7-kNe8saAjZYEALw_wcB)
- [mpostol/TP/DistributedProgramming](https://github.com/mpostol/TP/tree/master/DistributedProgramming)
- [Programowanie Reaktywne](https://github.com/mpostol/TP/tree/master/AdaptiveProgramming/ConcurrentProgramming)
- [Repo for managing Moq 4.x](https://github.com/moq/moq4)
- [Moq 4.13.1](https://www.nuget.org/packages/Moq/4.13.1)
- [Przykładowa implementacja repliki procesu - symulator bojlerów](https://github.com/mpostol/OPC-UA-OOI/tree/master/Networking/Simulator.Boiler)

[CAS.OPCUAIMD]: https://www.researchgate.net/publication/331565040_OPC_UA_INFORMATION_MODEL_DEPLOYMENT
