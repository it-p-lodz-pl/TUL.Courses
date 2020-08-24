# Wykład

## Harmonogram 2020

| Data  | Tydzień | Wykład  godz. 14:15:30                       | Projekt godz. 15:30-19:00      |
| :---- | :-----: | :------------------------------------------- | ------------------------------ |
| 26.03 |    4    | Wprowadzenie                                 | ND                             |
| 16.04 |    6    | Architektura                                 | ND                             |
| 30.04 |    8    | Protokoły komunikacyjne                      | ND                             |
| 14.05 |   10    | Semantyka danych - interoperacyjność         | ND                             |
| 27.05 |   12    | ND                                           | Sprawdzian 1 (1)               |
| 28.05 |   12    | Przetwarzanie w chmurze                      | Sprawdzian 1 (1)               |
| 03-06 |   13    | ND                                           | Sprawdzian 1 (2), 2 (1)        |
| 04-06 |   13    | ND                                           | Sprawdzian 1 (2), 2 (1)        |
| 10.06 |   14    | Bezpieczeństwo komunikacji, Danych i zasobów | Sprawdzian 1 (3), 2 (2)        |
| 18.06 |   14    | ND                                           | Sprawdzian 1 (3), 2 (2)        |
| 17.06 |   15    | ND                                           | Sprawdzian 2 (3)               |
| 22.06 |   15    | Kolokwium (1), Sprawdzian 2 (3)              | Kolokwium(1), Sprawdzian 2 (3) |

UWAGI:

- We wszystkich terminach odpowiedni moduł bęzie dostępny zdalnie.
- Sprawdzian 1 obejmuje wykłady 4, 6, 8 (tydzień)
- Sprawdzian 2 obejmuje wykłady 10, 12, 14 (tydzień)

### Testy - zakres tematyczny

| Wykład | Temat                                        | Sprawdzian 1 | Sprawdzian 2 | Kolokwium |
| ------ | -------------------------------------------- | :----------: | :----------: | :-------: |
| 1.     | Wprowadzenie                                 |      X       |              |     X     |
| 2.     | Architektura                                 |      X       |              |     X     |
| 3.     | Protokoły komunikacyjne                      |      X       |              |     X     |
| 4.     | Semantyka danych - interoperacyjność         |              |      X       |     X     |
| 5.     | Przetwarzanie w chmurze                      |              |      X       |     X     |
| 6.     | Bezpieczeństwo komunikacji, danych i zasobów |              |              |     X     |

## Tematyka

### Wprowadzenie

#### Wprowadzenie Plan

1. O kursie
1. Wyjaśnienie tematu
   - Mobilne dane, urządzenia, aplikacje, systemy
   - \[Industrial\] Internet of Things (IoT), Machine to Machine communication (M2M), Cyber Physical Systems, Industry 4.0
1. Wymagania wstępne
   - informacja a dane,
   - algorytm a program,
   - typ - co to znaczy
   - programowanie obiektowe
   - współużywalność danych
   - oprogramowanie sekwencyjne, współbieżne, równoległe, rozproszone
   - program warstwowy
   - Użyteczne narzędzia: C#, Visual Studio, GitHub
1. Programowanie
   - interaktywne
   - reaktywne
1. Komunikacja
   - Interaktywna - klient-serwer
   - Reaktywna Publisher-subscriber

#### Wprowadzenie Realizacja

- co to jest informatyka
- co to jest dana vs informacja
- co to jest warstwa programu
- jak jest relacja z mvvm
- co to jest podwarstwa
- po co nam warstwy
- co to jest urządzenie mobilne
- co to jest aplikacja mobilna
- co to są dane mobilne
- jakie dziedziny inżynierii oprogramowani są wykorzystywane w programowaniu urządzeń mobilnych (programowanie równoległe, współbieżne, czasu rzeczywistego)
- czy odbiornik GPS służący do lokalizacji geograficznej jest urządzeniem mobilnym
- programowanie urządzeń mobilnych - zmiana położenia geograficznego
- realizacja algorytmu (wiedza, abstrakcja) a implementacja algorytmu
- urządzenie mobilne: zmiana adresu i dostępność infrastruktury
- ergonomia a programowanie
- co to są dane mobilne
- programowanie obiektowe - paradygmaty, stan obiektu, abstrakcja zdalne tworzenie obiektów,
- web service, SOA,
- współdziałanie urządzeń rozproszonych
- XML jest jeżykiem tekstowym, schema uszczegóławiania skłądni.
- WSDL do czego służy ?
- SOAP
- co to jest synchronizacja danych - powody 
  - zastępowanie
- tranzakcie etapy
- M2M communication co to jest
  - brak interakcji człowieka
  - komunikacja maszyn
  - produkcja przez rożnych producentów

### Architektura

#### Architektura plan

- Aplikacja rozproszona - Model domenowy
- Cyber Physical Systems - Model domenowy
- Pozyskiwanie danych procesowych
  - Protokoły klasy field bus
  - Symulator
- Przetwarzanie danych procesowych
- Komunikacja in-band
- Data Transfer Object

### Architektura realizacja

- współdziałanie, programowanie i komunikacja
  - interaktywna
  - reaktywna
- współdziałanie - co to jest
- mobilne urządzenia
  - zmiana adresu
  - wyjście z zasięgu
- co to jest cloud computing
  - prawo dysponowania
  - utrzymywanie
  - za co płącimy
  - dostępność
  - dopasowanie zasobów do naszych potrzeb
  - abstrakcja
- dane
  - proste, złożone, strukturalne, obiektowe, graficzne, strumieniowe, bazy danych
- spójność danych
- harmonizacja danych
- synchronizacja danych
- sekcja krytyczna
- transakcja
- buforowanie
- praca synchroniczna i asynchroniczna
- systemy dla użytkowania przez człowieka co to jest HMI
- machine centric communication
- konteksty semantyczny
  - skłądnia - poprawność strumieni bitów
  - semantyka przypisanie wiedzę - przypisywanie informacji
- kontekst bezpieczeństwa
- Cyber Physical System
- Data holder mobility
- komunikacja klient serwer, sesja, współdzielenie danych, przechowywanie stanu
  - sesja kontekst bezpieczeństwa, kontekst semantyczny
- aplikacja (komunikacja reaktywna) Publisher/ subscriber) brak klient serwer, distribution channel, broker - dodatkowa aplikacja,
- dwukierunkowość w komunikacji reaktywnej (publisher/subscriber)
- czy protokół bezpołączeniowy może służyć do utworzenia sesji.
- czy korzystając pubsub można utworzyć komunikację interaktywną.
- asymetryczna komunikacja na urządzeniach brzegowych
- przestrzeń adresowa 
  - szukanie danych
  - metadane
  - model informacyjny
- po jest standaryzacja modelu informacyjnego
- stan dla publisher subscriber

### Protokoły komunikacyjne

#### Protokoły plan

- Internet, HTTP, TCP, UDP, IP
- Web Services (WS*)
- Web-socket
- REST

#### Protokoły Realizacja

- Przełączanie obwodów vs przełączanie pakietów
- warstwa programu jako zb ór typów
- mmvm i relacja w stosunku do Prezentacja logika i dane
- aplikacja webowa klient, przeglądarka, komunikacja,
- Podstawowe operacje na ekranie pisz, czytaj, wykonaj,
- aplikacja na żądanie - aplikacja mobilna wirtualny procesor język programowania
- HTTP jest bezpołączeniowy czy implementuje klient serwer
- czy mvvm to podwarstwy prezentacji 
- różnica pomiędzy danymi a modelem w mvvm
- ograniczenia w komunikacji klient sewer
  - dynamiczny adres
  - asymetria ruchu sieciowego
  - interaktywność serwera
  - pulling - co to jest
- czy podział aplikacje na dwie czyści burzy koncepcje warstw
- standaryzacja
  - papierowa - organizacje 
  - de facto - firmowa
  - de facto - open source
- Internet - co to jest
- REST - co to jest, czy to jest standard - czy jest
- WEBSOCKET podejście reaktywne, interaktywne, a asynchroniczne, sesja 
- kiedy ciąg bitów jest tekstem

### Semantyka danych - interoperacyjność

1. Type concept
1. Anonymous type
1. Partial types and methods
1. Generics
1. XML, JSON, YAML
   - [XML=>YAML](https://codebeautify.org/xml-to-yaml#)
   - [JSON => YAML,XML, CSV](https://jsonformatter.org/)  
1. OPC UA Information Model
 
### Przetwarzanie w chmurze


### Bezpieczeństwo komunikacji

- end to end security
- application identity
- application instance identity
- data identity
- user identity
- non repudiation
