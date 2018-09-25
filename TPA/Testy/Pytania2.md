# Śledzenie zachowania aplikacji

## Domena aplikacji - zarządzanie pamięcią

### Pytanie

Czy domenę aplikacji można wykorzystać do poprawy wykorzystania pamięci ?

### Odpowiedź

- prawda: **To jest poprawna odpowiedź**, ponieważ korzystając z domeny aplikacji możemy dynamicznie ładować komponenty w miarę potrzeby, a to wpływa na wykorzystanie pamięci operacyjnej.
- fałsz: **Jest to zła odpowiedź**, ponieważ korzystając z domeny aplikacji możemy dynamicznie ładować komponenty w miarę potrzeby, a to wpływa na wykorzystanie pamięci operacyjnej.

## Correlation token

### Pytanie

`Correlation token` wykorzystywany jest w procesie śledzenia działania aplikacji do:

#### Minimalizacji wpływu czasu transportu danych diagnostycznych od źródła (ang. source) do odbiorcy (ang. lisner)

- To jest dobra odpowiedź, ponieważ dzięki temu jest możliwość synchronizacji w czasie danych diagnostycznych pochodzących od komponentów tworzących jedną aplikację, a realizowanych w rożnych miejscach sieci.

#### Minimalizacji wpływy czasu realizacji kodu jako osobne wątki
- To jest dobra odpowiedź, ponieważ dzięki temu jest możliwość synchronizacji w czasie danych diagnostycznych wytwarzanych asynchronicznie i zminimalizowania wpływu czasu akumulowania.

#### Umożliwienia synchronizacji w czasie danych diagnostycznych pochodzących od komponentów programu realizowanych w osobnych procesach.

- To jest dobra odpowiedź, ponieważ dzięki temu jest możliwość synchronizacji w czasie danych diagnostycznych wytwarzanych asynchronicznie i zminimalizowania wpływu czasu akumulowania.

#### Umożliwienia synchronizacji w czasie danych diagnostycznych pochodzących od komponentów programu realizowanych w osobnych wątkach.

- To nie jest poprawna odpowiedź.

#### Umożliwienia synchronizacji w czasie danych diagnostycznych pochodzących od różnych programów realizowanych niezależnie od siebie.

- To nie jest poprawna odpowiedź.

## Co to jest śledzenie

### Pytanie

Które z poniższych funkcji są wykorzystywane do śledzenia działania programu:

### Odpowiedź

#### Testy jednostkowe
#### Testy regresyjne
#### Program diagnostyczny
#### Tworzenie pliku logu
#### Śledzenie wydajności
#### Rejestracja zdarzeń

## Śledzenie w chmurze

### Pytanie

Śledzenie w chmurze to:

### Odpowiedzi

- technologia pozwalająca na zapisywanie danych diagnostycznych we własnych zasobach dostępnych w Internecie.
- forma działalności gospodarczej pozwalająca na zapisywanie danych diagnostycznych w współdzielonych przez społeczność zasobach dostępnych w Internecie.
__________________________

## Śledzenie na osobnym wątku

Śledzenie na osobnym wątku jest zalecane, aby:

- minimalizować wpływ operacji diagnostycznych na zachowanie się programu;
 - to jest prawidłowa odpowiedź, ponieważ pozwala na maszynach wieloprocesorowych na równoległe wykonanie operacji i wyeliminowanie czasu przetwarzania przez system operacyjny 
- przyspieszyć realizacje operacji diagnostycznych;
 - to nie jest poprawna odpowiedź, ponieważ operacje diagnostyczne są sekwencyjne i wykonywane zawsze z tą samą szybkością;  
- umożliwić koncentrację uwagi (ang. separation of concern) na kontekst związany z realizacja śledzenia programu 
 - to nie jest poprawna odpowiedź, ponieważ dotyczy realizacji programu a nie jego tworzenia
- zwiększyć odporność programu na ewentualne błędy programistyczne;
 - to nie jest poprawna odpowiedź, ponieważ nie wpływa na poprawność realizacji

## Konfiguracja a serializacja

Współczesne technologie zarządzania parametrami aplikacji umożliwiają zapisanie w pliku konfiguracyjnym aplikacji  nawet danych, które nie są serializowalne.

fałsz - to jest poprawna odpowiedź, ponieważ plik xml jest strumieniem bajtów, więc musi powstać w procesie serializacji,
prawda - to nie jest poprawna odpowiedź, ponieważ plik xml jest strumieniem bajtów, więc musi powstać w procesie serializacji,

## string w pliku konfiguracyjnym XML

Użytkownik aplikacji może używać dowolnych znaków alfanumerycznych modyfikując parametry typu string w pliku konfiguracyjnym XML.

fałsz - to poprawna odpowiedź ponieważ niektóre znaki jak `<`, `>` i `&` są nielegalne i muszą być zastąpione przez sekwencję równoważną (ang. escape sequence),
prawda - to nie jest poprawna odpowiedź ponieważ niektóre znaki jak `<`, `>` i `&` są nielegalne i muszą być zastąpione przez sekwencję równoważną (ang. escape sequence)
