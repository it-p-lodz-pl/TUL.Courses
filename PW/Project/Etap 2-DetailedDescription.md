# Projekt Etap 2 - szczegółowy opis

## programowania asynchroniczne, sekcja krytyczna

## Cel

To trzy etapowe zadanie polega na opracowaniu programu komputerowego o architekturze wielowarstwowej i funkcjonalności pozwalającej na obserwowaniu zachowania się kul na  prostokątnej płaszczyźnie ograniczonej ścianami bocznymi.

Ten etap służy również do zaimplementowania tych wymagań, które w poprzednich etapach zostały przyjęte warunkowo.

Celem tego etapu jest praktyczne zastosowanie:

- jednokierunkowej architektury warstwowej
- dwukierunkowej komunikacji warstw
- implementacji koncepcji sekcji krytycznej
- testowania jednostkowego i integracyjnego
- wstrzykiwania zależności (ang. Dependency Injection) (opcja)
- wykorzystanie techniki MOCK (opcja)

## Opis zadania

Zmodyfikować uprzednio utworzony w etapie 1 program tak, aby uwzględnić, że:

- kule poruszając się po trajektoriach zgodnych z fizyką zjawiska przy założeniu braku tarcia
- kule odbijają sie od siebie i od ścian (odbicie sprężyste bez straty energii)
- kierunek i prędkość poruszania się kul po odbiciu będą uwzględniały ich masę, poprzedni kierunek i wartość prędkości z jaką się poruszały przed odbiciem
- zachowania interaktywne proszę zaimplementować jako asynchroniczne z wykorzystaniem konstrukcji `Task`

Program będzie implementował warstwy: `Dane`, `Logika` i `Prezentacja`. Bardziej szczegółowo warstwy opisano w rozdziale **Architektura** opisu do zadania `Projekt Etap 1`.

Wymienione wyżej warstwy `Dane` i `Logika` muszą być testowane niezależnie z wykorzystaniem testów jednostkowych. Aby to było możliwe API warstwy `Dane` i `Logika` musi być zrealizowany jako wyraźnie wydzielone definicje abstrakcyjne.

**UWAGA**: rozwiązanie dalej będzie modyfikowane w celu uzyskania końcowej funkcjonalności, która opisana jest w kolejnych etapach

## Wytyczne do realizacji

Dodatkowe informacje ułatwiające wykonanie zadania:

- Warstwa `Logika` powinna reprezentować wszystkie operacje realizowane w procesie implementacji zderzeń i informować warstwę `Model` o aktualnym położeniu kul
- Warstwa `Dane` odpowiada za parametry kul (waga i średnica) i ruch kul
- Proszę pamiętać, że `Dane` + `Logika` mogą zawierać sekcje krytyczne, a w konsekwencji rozwiązanie musi być odporne na zdarzenia współbieżne
- do wykrywania zderzeń proszę rozważyć możliwość wykorzystania drzewa binarnego
- pomocne będzie odprzęgnięcie warstw na potrzeby testowania używając abstrakcyjnego API, DI lub MOCK
- do realizacji podstawowych funkcji programu nie trzeba stosować wstrzykiwania zależności (DI)

## Zaliczenie

W celu potwierdzenia osiągnięcia celu i zrealizowania zakresu zadania, w trakcie omawiania kodu programu należy wykazać, że zostały zrealizowane punkty z listy kontrolnej zamieszczonej w osobnym pliku. W celu uniknięcia niespodzianek, przed oddaniem pracy do sprawdzenia, należy ten plik dodać do repozytorium jako issue i upewnić się samemu, ze wszystkie punkty listy kontrolnej zostały zrealizowane. Po upewnieniu się zamknąć issue. Utworzyć kolejne z tą samą listą kontrolną dla prowadzącego na potrzeby zaliczenia.

## Lista źródeł

Do zrealizowania zadania można wykorzystać przykładowy kodu na [C# in Practice - set of C# examples targeting education purpose](https://github.com/mpostol/TP). Literatura uzupełniająca podana jest na stronie kursu.
