# Projekt Etap 3 - Aplikacja Mobilna

## Cel

Celem zadania jest;

- praktyczne wykorzystanie standardów do projektowania modeli współdziałania programów wytworzonych niezależnie
- wykorzystanie komunikacji interaktywnej
- wykorzystanie komunikacji reaktywnej

## Opis zadania

W tym etapie należy wykorzystać uprzednio stworzoną aplikację rozproszoną, które będą realizuje role klienta i serwera. Z wykorzystaniem tych ról należy zapewnić wymianę wybranych danych strukturalnych pomiędzy instancją klienta i serwera. Należy zrealizować następujące scenariusze wymiany danych:

- zapytanie/odpowiedź - klient wysyła żądanie, a sewer odpowiada danymi w zależności od otrzymanego zapytania
- samorzutne wysyłanie/filtrowanie - serwer  wysyła dane samorzutnie, natomiast klient filtruje je zgodnie z potrzebami
- publikowanie/subskrypcja - klient zamawia dane (subskrybuje), a serwer wysyła (publikuje) samorzutnie wybrane dane w ramach utworzonej sesji

Klient/serwer komunikuje się ze sobą z wykorzystaniem technologii **Web-sockets**.

Przesyłąne dane muszą być opisane z wykorzystaniem wspólnego modelu obiektowego i reprezentować wybrany uprzednio model biznesowy.

Dane przesyłać z wykorzystaniem serializacji zgodnie ze skłądnią JSON, YAML, XML. Klient musi rozpoznawać skłądnię reaktywnie na podstawie otrzymywanych danych.

Poprawność programu należy sprawdzić z wykorzystaniem testów jednostkowych i testów integracyjnych.

Opracować model danych z wykorzystaniem standardu OPC Unified Architecture i harmonizować używany model obiektowy z modelem wygenerowanym automatycznie przez wybrane narzędzie.

### Wytyczne do realizacji

Dodatkowe informacje ułatwiające wykonanie zadania:

- proszę zwrócić uwagę na konieczność zastosowania technologi programowania reaktywnego dla wybranych scenariuszy
- niezbędna jest umiejętność wytłumaczenia czym różni się współdziałanie reaktywne od interaktywnego, synchroniczne od asynchronicznego
- zaoszczędzisz czas, jeśli do wykonania zadania zostaną wykorzystane dostępne przykłady
- proszę zwrócić uwagę, aby dane był strukturalne niezależnie od wybranego realizowanego modelu biznesowego
- do realizacji podstawowych funkcji programu nie trzeba stosować wstrzykiwania zależności
- ważne jest, aby współdzielone dane były chronione sekcją krytyczną
- pomocne w implementacji testów jednostkowych w miejsce testów integracyjnych jest wstrzykiwanie zależności i koncepcja MOCK

## Zaliczenie

W trakcie zaliczenia mogą być poruszane zagadnienie związane z:

- umiejętnością wskazania miejsc występowania i wytłumaczenia różnicy pomiędzy programowaniem reaktywny, a programowaniem interaktywnym
- umiejętnością wskazania miejsc występowania i wytłumaczenia różnicy pomiędzy programowaniem asynchronicznym, a programowaniem synchronicznym
- umiejętnością wskazania miejsc występowania sekcji krytycznej i jej implementacji
- wykazania, że aplikacja jest warstwowa i wskazanie granic i relacji warstw
- wskazaniem w programie miejsc odpowiedzialnych za produkowanie danych procesowych, komunikację pomiędzy instancjami programu, itp.
- aby zobiektywizować ocenianie zadania projektowego wykorzystamy listę kontrolną do sprawdzania poprawności realizacji etapu. Proszę sobie utworzyć Issue i skopiować do niego załączoną listę kontrolną i spróbować samemu odhaczyć zrealizowane wymagania, by sprawdzić kompletność wykonania

Do zrealizowania zadania można wykorzystać przykładowy kodu opublikowany w [C# in Practice - set of C# examples targeting education purpose](https://github.com/mpostol/TP).
