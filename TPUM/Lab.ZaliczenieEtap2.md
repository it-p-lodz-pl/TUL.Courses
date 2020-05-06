# Projekt - zadanie etap 2 - interaktywna/reaktywna komunikacja

## Treść zadania

### Cel

Celem zadania jest praktyczne poznanie:

- Komunikacji klient/serwer
- reaktywnego i interaktywnego interfejsu warstwy komunikacyjnej,
- testowania jednostkowego i integracyjnego,
- wstrzykiwania zależności (ang. Dependency Injection) (opcja)
- wykorzystanie techniki MOCK (opcja)

### Zakres

Opracować dwa programy z wykorzystaniem technologi .NET, które będą pełnił rolę klienta i sewera:

- będą implementowały warstwy: `Dane`, `Logika` i `Prezentacja`.
- Warstwy `Dane` i `Logika` proszę zrealizować w technologii .NET STandard o ile się da
- Warstwę `Prezentacja` proszę zrealizować w dowolnej ulubionej technologii, np. WPF/mvvm, która pozwoli na graficzną reprezentację danych w przypadku implementacji UI
- Warstwę `Prezentacja` proszę zrealizować z wykorzystaniem komunikacji Web Socked w przypadku implementacji komunikacji,
- Warstwa `Dane` ma zwierać model obiektowy reprezentujący wybrany proces biznesowy, np. sklep lub komunikację z serwerem
- Warstwa `Logiki` powinna reprezentować wszystkie operacje realizowane w wybranym procesie odpowiednio dla klienta i serwera
- Proszę pamiętać, że `Dane` + `Logika` to sekcja krytyczna i rozwiązanie musi być odporne na zdarzenia jednoczesne, rozproszone
- API warstwy KOMUNIKACYJNEJ (WARSTWA DANYCH (klient)/PREZENTACJI (serwer)) MUSI zawierać operacje interaktywne (np. zakup czegoś) i reaktywne (okresowe wysłanie PIT'u, zamówień, itp.)
- Zachowania reaktywne proszę zaimplementować z wykorzystaniem interfejsów IObserver/IObservable
- Zachowania interaktywne proszę zaimplementować jako asynchroniczne z wykorzystaniem konstrukcji Task
- Proszę dodać testy jednostkowe dla ważniejszych operacji warstwy `Dane`. Opcjonalnie proszę odprzęgnąć warstwy na potrzeby testowania używając DI lub MOCK.

### Termin

- termin oddania: zajęcia 10 (13.05) - czyli do 12-05 godź 24:00
- ostateczny termin oddania: Zajęcia 12 (27.05) - czyli do 26-05 godź 24:00
- zadanie należy oddać zgodnie z zasadami opisanymi w regulaminie zaliczani (Release, WIKAMP zgłoszenie, daty, itp. )

### Ocena

Zadnie jest fakultatywne, ale jest ono oceniane w skali 4..10, natomiast ocena ta nie jest oceną cząstkową ogólnej oceny z przedmiotu.

## Komunikaty

### Informacja o publikacji

Waśnie opublikowałem [Projekt - zadanie etap 2 - interaktywna/reaktywna komunikacja](https://ftims.edu.p.lodz.pl/mod/page/view.php?id=75591). To fakultatywne zadanie pozwoli zbliżyć się do rozwiązani wymaganego do zaliczenia przedmiotu, więc zachęcam to jego realizacji i przejścia procedury zaliczającej. Szczegóły w opisie. Na najbliższych zajęciach w czwartek postaram się omówić jego treść.

### Przypominam o terminie zgłoszenia

Przypominam o terminie zgłoszenia [Projekt - zadanie etap 1 - interaktywna/reaktywne programowanie](https://ftims.edu.p.lodz.pl/mod/assign/view.php?id=73857), który upływa dziś o 14:00. Wszyscy, którzy zgłosili zadanie do oceny powinni zarezerwować sobie termin w tym module [29-04-20 16:00 - Projekt - zaliczanie etap 1](https://ftims.edu.p.lodz.pl/mod/reservation/view.php?id=75159). Na jedną grupę przewiduję 30 min, więc limit na zajęcia to 4 grupy. Tylko jedna osoba z grupy powinna się zgłaszać. Ci, którzy się nie zmieszczą będą mieli kolejne terminy. Termin zgłoszeń upływa 14:00 w dniu 29-04-20. Zajęcia odbywają się z wykorzystaniem Teams.
