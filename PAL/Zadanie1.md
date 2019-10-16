# Zadanie 1 

Opracować model BPMN dla wybranej procedury logistycznej

# Cel

Celem zadania jest praktyczne potwierdzenie wiedzy w zakresie tworzenia formalnego opisy wybranych logistycznych procesów biznesowych, a w tym:

1. praktyczne wykorzystanie języka BPMN
2. praktyczne modelowanie wybranej procedury logistycznej
3. praktyczne wykorzystanie wybranego języka do zapisu modelu

## Zakres projektu

W ramach tego zadnia należy opracować formalny opis **modelu procedury harmonizacji dostawy** do abstrakcyjnego magazynu. Procedura ta jest realizowana wspólnie przez pracowników magazynu i zewnętrzne firmy transportowe. Celem procedury jest harmonizowanie wykorzystania:

- taboru przez firmy transportowe
- lokalnych zasobów rozładunkowych

W efekcie unika się kolejek ciężarówek przed bramą wjazdową na teren magazynu i zapewnia maksymalne wykorzystanie zasobów rozładunkowych. Synchronizacja działań uczestników procesu ma być zapewniona, w wyniku wspólnego wykorzystania oprogramowania komputerowego. Harmonizację dostaw należy zapienić w wyniku wspólnego zarządzania harmonogramem, w którym poszczególne dostawy są realizowane w rezerwowanych z wyprzedzeniem oknach czasowych.

### Role i funkcje

W modelu należy uwzględnić następujące role:

- firma transportowa - zapewnia dostarczenie zamówionego towaru w uprzednio uzgodnionym terminie
- ochrona (brama wjazdowa) - wpuszcza, wypuszcza (odnotowuje godziny tych operacji) tylko uwierzytelniony zestaw transportowy (ciągnik, naczepa, kierowca, pomocnik)
- koordynator procesów logistycznych - zamawia usługę i koordynuje przebieg dostawy
- administrator - interweniuje w sytuacjach nieprzewidzianych
- magazynier - dokonuje rozładunku (odnotowuje godzinę rozpoczęcia i zakończenia)

Role komunikują się ze sobą za pośrednictwem usługi email - niezależne oprogramowania.

Zestawy transportowe są katalogowane w słowniku jako jedna całość. Innymi słowy, w modelu można pominąć proces tworzenia zestawu zakładając, że każda firma transportowa dysponuje pewną pulą takich zestawów.

## Wytyczne do realizacji

W trakcie realizacji zadania zwróć uwagę na to:

* ważne jest aby, nie uwzględniać procesu zarządzania kalendarzem dostępnych okien czasowych
* proszę zwrócić uwagę na konieczność uwzględnienia działań dla każdej z wymiecionych powyżej ról
* niezbędna jest umiejętność wytłumaczenia sekwencji zdarzeń, działań i zależności pomiędzy nimi
* proszę zwrócić uwagę na to, że każdy proces ma swój początek, koniec i jednoczesna działania
* oprogramowanie jest jedna z ról procesu 

Lista ta zawiera tematy przewidziane do dyskusji w trakcie zaliczania zadania.

## Lista źródeł

W trakcie prac nad zadaniem można opcjonalnie wykorzystać filmiki ilustrujące przebieg omawianego procesu w warunkach produkcyjnych.

- [Shepherd #1](https://www.youtube.com/watch?v=VYhPM_5a0lk)
- [Shepherd #2](https://www.youtube.com/watch?v=_rqMfWhoCOA&t=4s)

Model w Zadanie 1 należy zapisać z wykorzystaniem programu:

[VP Online](https://online.visual-paradigm.com/diagrams/)

Przy zgłaszaniu do oceny należy dołączyć pojedynczy plik vpd zawierający kompletny model.

## Zaliczenie

### Harmonogram

Zadanie należy oddać do oceny i zaliczyć zgodnie z zasadni zaliczania laboratorium opublikowanymi na stronie kursu. 

### Realizacja zakresu zadania

Wymaga się przygotowania modelu zgodnie z powyższym opisem, a w tym:

1. plik z modelem otwiera się w wymienionym edytorze 
2. model opisuje wszystkie role wymienione powyżej
3. model zawiera występujące w praktyce zdarzenia, aktywność, itd.   
3. student umie omówić sekwencje zdarzeń z uwzględnieniem zdarzeń oraz działań równoległych, asynchronicznych i sekwencyjnych


 
