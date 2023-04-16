# TPUM Wykład Tematyka  <!-- omit in toc -->

## Spis treści <!-- omit in toc -->

- [1. Wprowadzenie](#1-wprowadzenie)
  - [1.1. Wprowadzenie Plan](#11-wprowadzenie-plan)
  - [1.2. Wprowadzenie Realizacja](#12-wprowadzenie-realizacja)
  - [1.3. Architektura](#13-architektura)
    - [1.3.1. Protokoły plan](#131-protokoły-plan)
    - [1.3.2. Protokoły Realizacja](#132-protokoły-realizacja)
- [2. Programowanie scentralizowane](#2-programowanie-scentralizowane)
  - [2.1. Podstawy programowania](#21-podstawy-programowania)
  - [2.2. Architektura warstwowa](#22-architektura-warstwowa)
    - [2.2.1. Mapowanie odpowiedzialności](#221-mapowanie-odpowiedzialności)
  - [2.3. Programowanie sekwencyjne - współbieżne](#23-programowanie-sekwencyjne---współbieżne)
  - [2.4. Programowanie synchroniczne - asynchroniczne](#24-programowanie-synchroniczne---asynchroniczne)
  - [2.5. Programowanie interaktywne - reaktywne](#25-programowanie-interaktywne---reaktywne)
- [3. Programowanie rozproszone](#3-programowanie-rozproszone)
- [4. Współdziałanie](#4-współdziałanie)
  - [4.1. `<semantyka danych - interoperacyjność>`](#41-semantyka-danych---interoperacyjność)
  - [4.2. Semantyka danych - interoperacyjność](#42-semantyka-danych---interoperacyjność)
- [5. Normalizacja - standaryzacja](#5-normalizacja---standaryzacja)
- [6. Przetwarzanie w chmurze](#6-przetwarzanie-w-chmurze)
- [7. Bezpieczeństwo](#7-bezpieczeństwo)
  - [7.1. komunikacji](#71-komunikacji)
  - [7.2. danych](#72-danych)
  - [7.3. zasobów](#73-zasobów)
  - [7.4. Bezpieczeństwo](#74-bezpieczeństwo)
  - [7.5. Architektura realizacja](#75-architektura-realizacja)

## 1. Wprowadzenie

1. O kursie
1. Wymagania wstępne
   - informacja a dane,
   - algorytm a program,
   - typ - co to znaczy
   - programowanie obiektowe
   - współużywalność danych
   - oprogramowanie sekwencyjne, współbieżne, równoległe, rozproszone
   - program warstwowy
   - Użyteczne narzędzia: C#, Visual Studio, GitHub
1. Wyjaśnienie tematu
1. Mobilne dane, urządzenia, aplikacje, systemy
1. IoT, M2M, Cyber Physical Systems, Industry 4.0
1. Programowanie
   - interaktywne
   - reaktywne
1. Komunikacja
   - Interaktywna - klient-serwer
   - Reaktywna Publisher-subscriber

- Nazwa przedmiotu - słowa kluczowe
- Urządzenia mobile
- Programowanie scentralizowane

- współdziałanie, programowanie i komunikacja
  - interaktywna
  - reaktywna
- współdziałanie - co to jest
- mobilne urządzenia
  - zmiana adresu
  - wyjście z zasięgu

### 1.1. Wprowadzenie Plan

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

### 1.2. Wprowadzenie Realizacja

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

### 1.3. Architektura

- Aplikacja rozproszona - Model domenowy
- Cyber Physical Systems - Model domenowy
- Pozyskiwanie danych procesowych
  - Protokoły klasy field bus
  - Symulator
- Przetwarzanie danych procesowych
- Komunikacja in-band
- Data Transfer Object

#### 1.3.1. Protokoły plan

- Internet, HTTP, TCP, UDP, IP
- Web Services (WS*)
- Web-socket
- REST

#### 1.3.2. Protokoły Realizacja

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

## 2. Programowanie scentralizowane

### 2.1. Podstawy programowania

- informacja a dane
- dane
  - proste, złożone, strukturalne, obiektowe, graficzne, strumieniowe, bazy danych
- spójność danych

### 2.2. Architektura warstwowa

#### 2.2.1. Mapowanie odpowiedzialności

1. Prezentacja.View (używanie kontrolek)
   - wyświetlanie danych dla użytkownika końcowego
   - klawisze start, kup teraz, przygotuj ofertę, wypożycz
2. Prezentacja.ViewModel (maszyna stanu GUI)
   - mapowanie wymiarów stołu ekranowego i stołu wirtualnego (reaktywne)
   - obsługa wprowadzania początkowej ilości kul (konwersja, walidacja, obsługa błędów) (interaktywne)
   - obsługa klawisza start (interaktywna, zmiana stanu)
3. Prezentacja.Model
   - dane na potrzeby GUI
4. Logika biznesowa
   - Realizacja głównych wymagań związanych
5. Dane
   - Model obiektowy

### 2.3. Programowanie sekwencyjne - współbieżne

### 2.4. Programowanie synchroniczne - asynchroniczne

### 2.5. Programowanie interaktywne - reaktywne

- harmonizacja danych
- synchronizacja danych
- sekcja krytyczna
- transakcja
- buforowanie
- praca synchroniczna i asynchroniczna
- systemy dla użytkowania przez człowieka co to jest HMI

## 3. Programowanie rozproszone

- Podstawy
  - Po co nam systemy rozproszone?
  - Co to są systemy rozproszone?
- Komunikacja
  - Wprowadzenie
  - Internet
  - Protokoły
    - Stos protokołów (ISO/TCP)
    - HTTP, TCP, UDP, IP
    - REST
    - WebSocket
- Współdzielenie GUI
- Współdzielenie repozytoriów
- Podział programu na niezależne procesy

Programowanie rozproszone

- Aplikacja rozproszona - Model domenowy
- Cyber Physical Systems - Model domenowy
- Pozyskiwanie danych procesowych
  - Protokoły klasy field bus
  - Symulator
- Przetwarzanie danych procesowych
- Komunikacja in-band
- Data Transfer Object

## 4. Współdziałanie

### 4.1. `<semantyka danych - interoperacyjność>`

- Integracja komponentów różnych producentów
  - Roboty
  - Autonomiczne samochody

1. Type concept
1. Anonymous type
1. Partial types and methods
1. Generics
1. XML, JSON, YAML
   - [XML=>YAML](https://codebeautify.org/xml-to-yaml#)
   - [JSON => YAML,XML, CSV](https://jsonformatter.org/)  
1. OPC UA Information Model

### 4.2. Semantyka danych - interoperacyjność

Współdziałanie rozproszone
Integracja komponentów różnych producentów
Roboty
Autonomiczne samochody
Przykłady architektoniczne
Machine to Machine Communication (M2M)
IoT
Cyber Physical Systems

## 5. Normalizacja - standaryzacja

- Przykłady architektoniczne
  - Machine to Machine Communication (M2M)
  - IoT
  - Cyber Physical Systems

## 6. Przetwarzanie w chmurze

- co to jest cloud computing
  - prawo dysponowania
  - utrzymywanie
  - za co płacimy
  - dostępność
  - dopasowanie zasobów do naszych potrzeb
  - abstrakcja

## 7. Bezpieczeństwo

### 7.1. komunikacji

- end to end security
- application identity
- application instance identity
- data identity
- user identity
- non repudiation

### 7.2. danych

### 7.3. zasobów

### 7.4. Bezpieczeństwo

- Data Transfer Object/Graph
  - kontekst semantyczny
  - kontekst bezpieczeństwa
  - wymagania projektowe
- Bezpieczeństwo komunikacji
  - wybrane protokoły
  - bezpieczeństwo punkt to punkt (p2p)
  - Bezpieczeństwo end to end (e2e)
  - end to end security
- Bezpieczeństwo danych
  - kryptografia symetryczna
  - kryptografia asymetryczna
    - tożsamość aplikacji
    - tożsamość instancji aplikacji
    - tożsamość użytkownika (nie wyrzekanie się ang. non repudiation)
  - bezpieczeństwo dokumentów
    - tożsamość danych

### 7.5. Architektura realizacja

- machine centric communication
- konteksty semantyczny
  - składnia - poprawność strumieni bitów
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
