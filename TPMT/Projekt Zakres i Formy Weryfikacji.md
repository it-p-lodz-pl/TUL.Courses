# Projekt - zakres i formy weryfikacji
  
Pomimo nietypowej sytuacji mogę chyba podsumować dyskusję dotyczącą celu, zakresu i sposobu oceniania projektu. W planowanym uprzednio terminie otrzymałem dwa emaile i jedną skargę. Ponieważ nie otrzymałem propozycji przedłużenia tego terminu, uważam dyskusję za zamkniętą. Oczywiście pozostawiam tę kwestię otwartą i w przypadkach indywidualnych będę nakłaniał do podjęcia adekwatnego wysiłku w celu realizacji planowanych efektów kształcenia. Aby zmobilizować stopień realizacji efektów kształcenia musi mieć wpływ na końcową ocenę. Zaliczenie przedmiotu (otrzymanie minimalnej zaliczającej oceny, czyli 3.0) musi być natomiast uzależnione od osiągnięcia pewnych minimów w tym zakresie.

Treści skargi ani jej autorów nie znam, więc nie mogę się do niej odnieść i tym bardziej uwzględnić w dyskusji merytorycznej. Ponieważ obowiązuje mnie tajemnica korespondencji i nie mam upoważnienia do opublikowania pozostałych propozycji, poniżej przedstawię tylko główne propozycje. Propozycje te można pogrupować w następujący sposób:

1.	Ostatni przedmiot
1.	.NET i Visual Studio
1.	Rekurencja i refleksja
1.	Dostępne produkty i technologie
1.	Ciągła integracja (ang. continous integration)

## Ostatni przedmiot

Z oczywistych powodów, nie możemy nawet przez chwilę tego argumentu podnosić w kontekście dyskusji na temat sposobu realizacji przedmiotu. Rozumiem, że tego typu argumenty możemy pominąć milczeniem, by dalej nie pastwić się nad ich autorami.

## .NET i Visual Studio

Zgadzam się z argumentem, że nie jest to jedyne środowisko programistyczne, które można wykorzystać. Jest jednak kilka ważkich powodów, dla który je wybrałem. Po konsultacji z osobami odpowiedzialnym za utrzymanie oprogramowania narzędziowego w Instytucie, można skonkludować, że jest to jedyne oprogramowanie, którego sposób licencjonowania w kontekście realizacji dydaktyki nie budzi wątpliwości. Oprogramowanie jest dostępne dla studentów PŁ na mocy umów podpisanych z jego producentem firmą Microsoft. Oprogramowanie pokrywa potrzeby przedmiotu w zakresie efektów kształcenia. Nie jest naszym celem poznanie tej platformy, a jedynie jej wykorzystanie do realizacji postawionych celów. Preferencje studentów co do wyboru technologii realizacji projektu są tak różnorodne, że nie mogą być pomocne przy wyborze wspólnych wymagań, które powinny być podstawą stawiania wymagań i oceniania. Wybór tej platformy, moim zdaniem, jest szczególnie korzystny dla studentów, którzy nigdy z niej nie korzystali, ponieważ daje szanse do powiększenia zabioru swoich kompetencji. Jest to platforma, którą najlepiej znam, więc w przypadku problemów szansa, że pomogą rozwiązać problem jest praktycznie 100%.

Czyli, żeby w pełni zrealizować efekty kształcenia trzeba przedstawić swoje rozwiązanie zgodnie z wymogami opublikowanymi w przestrzeni roboczej WIKAMP w pierwszym wymaganym terminie. Ale dla tych wszystkich, którzy czują awersję do tej platformy i tego uczucia nie są w stanie pokonać biorąc pod uwagę przedstawione powyżej argumenty, jako minimum zaliczeniowe w trzecim terminie można przedstawić rozwiązanie na dowolnej platformie, które jednak będzie zawierało program komputerowy i wybrane rodzaje testów. Aby uniknąć problemów w takim przypadku zaliczenie będzie realizowane na komputerze studenta, ale nadal trzeba umieć wykonać: lokalny klon, kompilację, wykonanie testów i omówić proponowane rozwiązanie.

## Rekurencja i refleksja

Wiem, że boicie się rekurencji i refleksji. Oba tematy są omówione w TP. Nie jest prawdą, że one nie są związane z tematem. Są tylko pośrednio. Refleksja bo jest podstawą dla Mock, rekurencja bo stwarza specyficzne wyzwanie dla testów. Osobno (post, książka lub inny zasób) pokażę gdzie są gotowce. Więc nie jest prawdą, że ten punkt projektu trzeba zrealizować całkowicie samodzielnie. Samodzielnie jedynie trzeba temat zrozumieć. Więc ogarnięcie tematu mieści się pomiędzy copy/paste a świadome wykorzystanie.

Jeśli jednak kogoś to nie przekonuje, to za minimalny wymóg potwierdzający osiągnięcie efektów kształcenia, a zatem minimum zaliczeniowe będzie przedstawienie wybranych testów dla dowolnego programu, np. piętnasta wersja sklepu pod warunkiem, że użyte w programie dane będą strukturalne (definicję przypomniałem na ostatnim wykładzie). Oczywiście nadal obowiązuje konieczność omówienia proponowanych rozwiązań w kontekście testowania oprogramowania.

## Dostępne produkty

O ile dobrze zrozumiałem intencje, jedna z otrzymanych propozycji postuluje omawianie dostępnych na rynku produktów związanych bezpośrednio lub pośrednio z testowaniem. W propozycji tej znajduję całą długą listę takich produktów. Na ten temat mówiłem w trakcie pierwszego wykładu, więc powtórzę tylko główne myśli w tym zakresie. Dydaktyka na PŁ, która pozwala poświadczyć prawo do dyplomu, musi mieć charakter akademicki (a nie produktowy) z kilku powodów. Dyplom jest dokumentem wydawanym na całe życie, a nie tylko zaświadczeniem na potrzeby najbliższej rekrutacji. Żywot i dynamika rozwoju narzędzi dziś jest ogromna, więc wiedza nabyta dziś może się okazać całkowicie nieprzydatna jutro. Omawiają produkt zwykle co drugie zdanie należy dodać w wersji XX …. Ale nowe wersje wychodzą średnio kilka razy w roku. W trakcie zajęć nie jest możliwe omówienie wszystkich narzędzi, więc jak wybrać te najważniejsze – jaka jest miara ważności. Tym bardziej, że dla różnych uczestników kursu będzie inna, a wahania od niezbędne do całkowicie niepotrzebne. Niestety kategorycznie muszę odmówić podejścia produktowego. Pozostajemy przy opcji, że produkty wykorzystujemy, bo musimy zdobyć pewne umiejętności, ale najważniejsza jest w miarę ogólna wiedza.

## Ciągła integracja (ang. continous integration)

To teraz temat na topie, ale faktycznie z testowaniem ma związek pośredni – pozwala na automatyzacje procesu. To zwiększa …… Szkoda teraz miejsca na wykład.

Biorąc jednak pośredni związek z testowaniem mogę przyjąć, że nie jest niezbędny w minimum zaliczeniowym, więc w trzecim terminie można pokazać i omówić rozwiązanie bez tego wymogu. Proszę jednak łatwo nie odpuszczać. Ja pokażę jak to zrobić i nie wymaga to dużej ilości pracy. To rozwiązanie jest wykorzystywane w wielu moich repozytoriach, a w tym w TP, więc proszę zajrzeć. Wystarczy kliknąć ikonkę. Do tematu wrócimy wkrótce.

## Podsumowując

COVID-19 ma wiele zabójczych wad, ale sytuacja, którą spowodował, promuje pisanie i czytanie - to chyba zaleta. **Więc miłego czytania w zdrowiu życzę**. Jeśli o czymś zapomniałem to proszę o informację. Jeśli jest coś niejasne proszę zaplanować konsultacje na Teams. Niektórzy już z tego korzystają. 
