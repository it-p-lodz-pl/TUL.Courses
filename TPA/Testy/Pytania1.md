# Architektura aplikacji

## Pytanie

Z różnych powodów w architektura aplikacji wyróżnia się niezależne warstwy o dedykowanych funkcjach zależnych od wybranego modelu. W trakcie zajęć odwoływaliśmy się do modeli:

- Prezentacja, logika, dane
- Widok, model widoku i model (MVVM)

Jakie koncepcje, konstrukcje językowe i technologie można wykorzystać w realizacji takiego podejścia:

> **Uwaga**: Nieprawidłowe odpowiedzi są karane punktami ujemnymi.

## Odpowiedzi

- Abstrakcja (Interfejs, klasa abstrakcyjna), która pozwala ukryć nieistotne szczegóły implementacyjne przed użytkownikami warstwy i pozwala pracować na bazie wspólnego kontraktu.
 - **To jest dobra odpowiedz**, faktycznie abstrakcja ułatwia zastosowanie architektury warstwowej. 
- Polimorfizm, który pozwala warstwie użytkownika zaimplementować wybraną funkcjonalność na kilka różnych sposobów.
 - **Jest to zła odpowiedź**. Polimorfizm, jak zaznaczono w odpowiedzi, wpływa na realizację funkcjonalności, a nie na to, co jest oferowane w zakresie funkcjonalności.
- Technologii LINQ (Language Integrated Query), która pozwala na standaryzację dostępu do danych z interfejsu warstwy.
 - **To niepoprawna odpowiedź** – LINQ umożliwia tworzenie wyrażeń, które mają na celu wybór podzbioru elementów ze zbioru źródłowego. Za funkcjonalność odpowiedzialne są metody i właściwości w klasach.
- Żadne specjalistyczne koncepcje, konstrukcje i technologie nie są niezbędne, aby zastosować w praktyce wybraną architekturę warstwową.
 - To jest poprawna odpowiedź, jednak w praktyce trzeba jakoś istnienie warstw zasygnalizować, np. przestrzenie nazw, klasy, itp.
- Refleksja, która umożliwia dostęp do metadanych programu (warstwy) i używanie warstwy bez bezpośredniego dostępu do definicji oferowanej funkcjonalności na jej granicy.
 - **To niepoprawna odpowiedź** - O ile refleksja może się przydać w niektórych szczególnych przypadkach do implementacji warstw, to nie jest to technologia bazowa dla tej koncepcji. W związku z tym odpowiedzi tej nie można uznać za poprawną. 
- Kompilacja rozłączna, która pozwala tworzyć osobne niezależnie opracowywane i testowane komponenty.
 - **To poprawna odpowiedź**, kompilacja rozłączna jest podstawowym narzędziem do implementacji warstw i zapewnienia niezależności warstwy od jej użytkownika). 

# Architektura aplikacji - relacje zależności wars

Warstwa jest rodzajem abstrakcji pozwalającym na projektowanie architektury programu reprezentującej hierarchię zależności elementów składowych programu należących do warstwy. W tej architekturze warstwy łączą relacje zależności w taki sposób, że każda każda warstwa z wyjątkiem najniższej jest zależna wyłącznie od warstw niższych. Warstwa najniższa nie jest uzależniona od istnienia żadnej innej warstwy. Analogicznie od warstwy najwyższej nie jest uzależniona żadna inna warstwa. 

Zależność w kontekście programu oznacza wykorzystanie definicji eksponowanych przez inną warstwę zwanych (API). Ciąg zależności łączących warstwy nazywa się ścieżką. Innymi słowy wychodząc z dowolnej warstwy i poruszając się wzdłuż relacji zależności nigdy nie wrócimy do warstwy początkowej.

# Architektura aplikacji - wykorzystanie obiektów

## Pytanie

W warstwowej architekturze aplikacji warstwa niższa może korzystać z obiektów utworzonych na podstawie typów zdefiniowanych w warstwie wyższej.

## Odpowiedź

- `true` - **To jest dobra odpowiedź**. Faktycznie warstwie niższej wystarczy definicja abstrakcyjna i referencja do korzystania z cech obiektu.
- `False` - **To niepoprawna odpowiedź**. Warstwie niższej wystarczy definicja abstrakcyjna i referencja do obiektu, aby poprawnie korzystać z jego cech. 

# Architektura aplikacji - wykorzystanie typów

## Pytanie

W warstwowej architekturze aplikacji warstwa niższa może korzystać z typów zdefiniowanych w warstwie wyższej.

## Odpowiedź

- `false` - **To jest dobra odpowiedź**. Korzystanie z typów oznacza, że warstwa niższa byłaby zależna od warstwy wyższej, a to by zaburzyło hierarchię warstw zbudowanej na ich wzajemnych zależnościach.
- `true` - **To niepoprawna odpowiedź**. Korzystanie z typów oznacza, że warstwa niższa byłaby zależna od warstwy wyższej, a to zaburza hierarchię warstw zbudowanej na ich wzajemnych zależnościach. 

# Dynamiczne typy

## Pytanie

Typy generyczne są typowym przykładem typów dynamicznych.

## Odpowiedzi

* `false` - **To jest dobra odpowiedź** ponieważ typ dynamiczny, to typ którego definicja powstaje w trakcie realizacji programu.
* `true` -  **To niepoprawna odpowiedź** ponieważ typ dynamiczny, to typ którego definicja powstaje w trakcie realizacji programu. 

# Dynamiczne tworzenie obiektów

## Pytanie

Mówimy, że obiekt powstał w wyniku programowania dynamicznego, jeśli został utworzony wyłącznie na podstawie typu dynamicznego.

## Odpowiedzi

* `false` - **To jest dobra odpowiedź** bo może jeszcze powstać w wyniku odzyskania definicji typu z wykorzystaniem refleksji.
* `true` -  **To niepoprawna odpowiedź** bo może jeszcze powstać w wyniku odzyskania definicji typu z wykorzystaniem refleksji. 
   
# dynamic - operacje na zmiennych

1. object _error = 10; 
1. _error += 1;  
1. dynamic _dyn = 0;  
1. _dyn += 1;

Które z poniższych linijek zawierają błąd kompilacji:

- Linia 2: [[2]]
- Linia 4: [[1]]

# Lokalizacja aplikacji

## Pytanie

Lokalizacja aplikacji polega na wykorzystaniu dostępnych technologii w celu określenia położenia geograficznego.

## Odpowiedzi

- `False` - **To poprawna odpowiedź** ponieważ lokalizacja aplikacji polega na wykorzystaniu dostępnych technologii do parametryzowania jej zachowania w zależności od ustawień kulturowych środowiska.
- `true` - **To niepoprawna odpowiedź** - ponieważ lokalizacja aplikacji polega na wykorzystaniu dostępnych technologii do parametryzowania jej zachowania w zależności od ustawień kulturowych środowiska.

# Polimorfizm

## Pytanie

Implementowanie różnej funkcjonalności wybranej metody w zależności od typu obiektu nazywamy:

## Odpowiedź

`polimorfi*`

To polimorfizm, który pozwala zaimplementować tą samą metodę w różny sposób.

# Luźne-ścisłe Powiązania

Mówiąc o luźnych i ścisłych powiązaniach w kontekście programu komputerowego możemy wyróżnić następujące dwa rodzaje powiązań:

1. typów: definicja jednego typu odwołuje się do innej definicji typu,
1. komponentów - jeden komponent wykorzystuje jawnie referencji do innego w celu udostępnienia jego publicznych definicji na potrzeby własnych typów,

Siłę powiązań można jedynie ocenić pod warunkiem, że zdefiniujemy odpowiednie jej miary. 

W przypadku definicji typów, typ T1 jest ściśle powiązany z typem T2, jeśli jego definicja bezpośrednio odwołuje się do typu T2. Typy będą luźno związane, jeśli definicja typu T1 odwołuje się do pewnego typu bazowego dla typu T2. W konsekwencji jest zwiększenie się liczby typów zgodnych, więc rozluźnienie reguł kontroli zgodności typów.

Jeśli komponent K1 nie ma referencji do komponentu K2, ale w trakcie realizacji programu wykorzystuje obiekty utworzone na podstawie definicji znajdującej się w K2 to komponenty będą luźno powiązane.

# Współdziałanie asynchroniczne

Dopasuj

* Programowanie asynchroniczne
 * Wykonywanie operacji jako efekt zdarzeń niedeterministycznych
 * Brak współdzielonych zasobów
* Programowanie współbieżne
 * Asynchroniczne operacje 
 * współdzielone zasoby
* Programowanie równoległe
 * Jednoczesne wykonywanie operacji programu
* Programowanie czasu rzeczywistego
 * Konieczność uwzględnienia czasu jako czynnika determinującego poprawność programu

# Współdziałanie asynchroniczne - sekcja krytyczna
> w opracowaniu
> 
Sekcja krytyczna to fragment kodu programu, w którym współbieżne wątki korzystają z współdzielonych danych. Dane te mogą reprezentować pewną złożoną informację lub zewnętrzne zasoby jak urządzenia wej./wyj., pliki, itp. Aby zachować spójność danych przetwarzanych w danej chwili tylko jeden wątek może być aktywny wewnątrz sekcji.  

# Zdarzenia

## Pytanie

Zdarzenie to konstrukcja językowa, którą wykorzystujemy do sygnalizowania wystąpienia pewnego warunku. Które z poniższych stwierdzeń są prawdziwe.

> **Uwaga**: Nieprawidłowe odpowiedzi są karane punktami ujemnymi.

## Odpowiedzi

- Metody subskrybentów są wywoływane w chwili spełnienia warunku, który ma być sygnalizowany.
 - **To niepoprawna odpowiedź**; do wywołania zasubskrybowanych metod wymagana jest instrukcja, a spełnienie warunku to jedynie wynik z wyznaczenia wartości wyrażenia.
- Sygnalizowanie wystąpienia zdarzenia wymaga instrukcji o składni wywołania metody, która uruchamia wszystkie metody subskrybentów.
 - **To poprawna odpowiedź**; wszystkie metody z parametrami aktualnymi zgodnie z deklaracją typu delegacyjnego.
- Poprawność wywołania zdarzenia jest możliwa, ponieważ zdarzenie ma zdefiniowany typ wartości zwracanej przez metody subskrybujące.
 - **To niepoprawna odpowiedź**; dla wszystkich metod muszą być podane parametry aktualne o typach zgodnych z definicją typu delegacyjnego.
- Po zasygnalizowaniu zdarzenia wszystkie zasubskrybowane metody są wykonywane niezależnie w stosunku do sekwencji instrukcji publikatora, tzn. wykonanie instrukcji następującej po zainicjowaniu zdarzenia może nastąpić przed zakończeniem lub w trakcie realizacji zasubskrybowanych metod.
 - **To niepoprawna odpowiedź**; Wszystkie metody są wykonywane w sekwencji instrukcji wywołującej (sygnalizującej), więc muszą się zakończyć przez rozpoczęciem następnej instrukcji publikatora.

# Zmienna delegacyjna

## Pytanie

Zmienna delegacyjna przechowuje referencję do wyrażenia, które określa jej wartość.

## Odpowiedź

- `true`: Jej wartością jest referencją do metody, a nie do wyrażenia.
- `false`: OK, to dobra odpowiedź.