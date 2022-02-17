# Projekt Etap 3 - szczegółowy opis

## programowanie równoległe i czasu rzeczywistego

## Cel

To trzy etapowe zadanie polega na opracowaniu programu komputerowego o architekturze wielowarstwowej i funkcjonalności pozwalającej na obserwowaniu zachowania się kul na  prostokątnej płaszczyźnie ograniczonej ścianami bocznymi.

Ten etap służy również do zaimplementowania tych wymagań, które w poprzednich etapach zostały przyjęte warunkowo.

Celem tego etapu jest praktyczne zastosowanie:

- implementacji koncepcji programowania czasu rzeczywistego,
- potwierdzenia wykorzystania programowania równoległego,
- testowania jednostkowego i integracyjnego,
- wstrzykiwania zależności (ang. Dependency Injection) (opcja)
- wykorzystanie techniki MOCK (opcja)

## Opis zadania

W tym etapie należy wykorzystać uprzednio stworzoną aplikację, w której dodatkowo należ wbudować elementy programowania czasu rzeczywistego, a więc zaimplementować takie  algorytmy, które będą wymagały wykorzystania czynnika czasu. Przykładowo może to być mechanizm logowania do pliku danych diagnostycznych o zachowaniu się kul. W takim przykładzie należy uwzględnić możliwość chwilowego braku odpowiedniej przepustowości kanałów zapisu do pliku. Dane diagnostyczne do zapisu powinny byc przygotowane z wykorzystaniem serializacji zgodnie ze składnią JSON, YAML, XML.

Program będzie implementował warstwy: `Dane`, `Logika` i `Prezentacja`. Bardziej szczegółowo warstwy opisano w rozdziale **Architektura** opisu do zadania `Projekt Etap 1`.

Wymienione wyżej warstwy `Dane` i `Logika` muszą być testowane niezależnie z wykorzystaniem testów jednostkowych. Aby to było możliwe API warstwy `Dane` i `Logika` musi być zrealizowany jako wyraźnie wydzielone definicje abstrakcyjne.

### Wytyczne do realizacji

Dodatkowe informacje ułatwiające wykonanie zadania:

- Proszę zwrócić uwagę na konieczność zastosowania technologi programowania reaktywnego dla wybranych scenariuszy.
- Niezbędna jest umiejętność wytłumaczenia czym różni się programowanie reaktywne od interaktywnego, synchroniczne od asynchronicznego i czasu rzeczywistego.
- Ważne jest, aby współdzielone dane były chronione sekcją krytyczną.
- Prawidłowa implementacja sekcji krytycznej, zapobieganie zjawisku wyścigu i poprawna synchronizacja współbieżnych wątków są krytyczne dla programowania czasu rzeczywistego.
- Pomocne w implementacji testów jednostkowych w miejsce testów integracyjnych jest wstrzykiwanie zależności i koncepcja MOCK.
- Do realizacji podstawowych funkcji programu nie trzeba stosować wstrzykiwania zależności (DI).

## Zaliczenie

W celu potwierdzenia osiągnięcia celu i zrealizowania zakresu zadania, w trakcie omawiania kodu programu należy wykazać, że zostały zrealizowane punkty z listy kontrolnej zamieszczonej w osobnym pliku. Przed oddaniem pracy do sprawdzenia, należy ten plik dodać do repozytorium i upewnić sie samemu, ze wszystkie punkty listy kontrolnej zostały zrealizowane.

## Lista źródeł

Do zrealizowania zadania można wykorzystać przykładowy kodu na [C# in Practice - set of C# examples targeting education purpose](https://github.com/mpostol/TP). Literatura uzupełniająca podana jest na stronie kursu.
