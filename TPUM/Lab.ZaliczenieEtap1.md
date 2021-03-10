# Projekt - zadanie etap 1 - interaktywna/reaktywne programowanie

## Treść zadania

### Cel

Celem zadania jest praktyczne poznanie:

- reaktywnego i interaktywnego programowania,
- testowania jednostkowego i integracyjnego,
- wstrzykiwania zależności (ang. Dependency Injection) (opcja)
- wykorzystanie techniki MOCK (opcja)

### Zakres

Opracować program z wykorzystaniem technologi .NET, który będzie:

- implementował warstwy: `Dane`, `Logika` i `Prezentacja`.
- Warstwy `Dane` i `Logika` proszę zrealizować w technologii .NET STandard
- Warstwę `Prezentacja` proszę zrealizować w dowolnej ulubionej technologii, np. WPF/mvvm, która pozwoli na graficzną reprezentację danych
- Warstwa `Dane` ma zwierać model obiektowy reprezentujący wybrany proces biznesowy, np. sklep
- Warstwa `Logiki` powinna reprezentować wszystkie operacje realizowane w wybranym procesie
- Proszę pamiętać, że `Dane` + `Logika` to sekcja krytyczna i rozwiązanie musi być odporne na zdarzenia jednoczesne
- API warstwy powinno zawierać operacje interaktywne (np. zakup czegoś) i reaktywne (okresowe wysłanie PIT'u)
- Proszę pomyśleć w którym miejscu wstawić komunikację pomiędzy klientem i serwerem pamiętając, że klient/serwer komunikuje się ze sobą z wykorzystaniem technologii Web-sockets
- Proszę dodać testy jednostkowe dla ważniejszych operacji warstwy `Dane`, `Logika`. Opcjonalnie proszę odprzęgnąć warstwy na potrzeby testowania używając DI lub MOCK

### Termin

- termin oddania: Zajęcia 8 (29.04) - czyli do 28-04 godź 24:00
- ostateczny termin oddania: Zajęcia 10 (13.05) - czyli do 12-04 godź 24:00

### Ocena

- zadanie należy oddać zgodnie z zasadami opisanymi w regulaminie zaliczani (Release, WIKAMP zgłoszenie, daty, itp. )
- zadnie jest oceniane w skali 4..10
