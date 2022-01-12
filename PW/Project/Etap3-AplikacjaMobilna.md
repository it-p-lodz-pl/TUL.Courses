# Aplikacja Mobilna

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

Do zrealizowania zadania można wykorzystać przykładowy kodu opublikowany w [C# in Practice - set of C# examples targeting education purpose](https://github.com/mpostol/TP).

## Zobacz też

- [Mocks Aren't Stubs](https://martinfowler.com/articles/mocksArentStubs.html)
- [How to test software, part I: mocking, stubbing, and contract testing](https://circleci.com/blog/how-to-test-software-part-i-mocking-stubbing-and-contract-testing/?gclid=Cj0KCQiAkePyBRCEARIsAMy5ScunlfHQKu8LF1w4pG9d4P10ChGBpIv8YNgJklqj0rOYGb3p7-kNe8saAjZYEALw_wcB)
- [The WebSocket Protocol; Request for Comments: 6455](https://tools.ietf.org/html/rfc6455)
- [mpostol/TP/DistributedProgramming](https://github.com/mpostol/TP/tree/master/DistributedProgramming)
- [Web-sockets implementacja na GitGub w repozytorium `mpostol/NBlockchain`](https://github.com/mpostol/NBlockchain)
- [Programowanie Reaktywne](https://github.com/mpostol/TP/tree/master/AdaptiveProgramming/ConcurrentProgramming)
- [Repo for managing Moq 4.x](https://github.com/moq/moq4)
- [Moq 4.13.1](https://www.nuget.org/packages/Moq/4.13.1)
- [Przykładowa implementacja repliki procesu - symulator bojlerów](https://github.com/mpostol/OPC-UA-OOI/tree/master/Networking/Simulator.Boiler)
- [Address Space Model Designer](https://github.com/mpostol/ASMD/releases)
- [Address Space Model Designer OnLine Help](https://commsvr-com.github.io/Documentation/ModelDesigner/html/a2d55988-b59a-4a87-95b9-933f6bbdf5bd.htm)
- [Mariusz Postol. OPC UA Information Model Deployment. 2016. Version 1.2][CAS.OPCUAIMD] [![DOI](https://zenodo.org/badge/DOI/10.5281/zenodo.2586616.svg)](https://doi.org/10.5281/zenodo.2586616)
- [Address Space Prototyping Tool (asp.exe)](https://commsvr.gitbook.io/ooi/semantic-data-processing/addressspacecompliancetesttool)

[CAS.OPCUAIMD]: https://www.researchgate.net/publication/331565040_OPC_UA_INFORMATION_MODEL_DEPLOYMENT