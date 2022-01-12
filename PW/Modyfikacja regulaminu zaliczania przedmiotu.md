# Modyfikacja regulaminu zaliczania przedmiotu

Wychodząc naprzeciw akcji #STUDENSAMWDOMU przypominam, że to nie są korona-ferie. Dlatego zachęcam do realizacji programu kursu w nowych warunkach, w których zamieniamy godziny kontaktowe na pracę zdalną (ang. home office). Kiedyś Was napominałem, że Internet to nie jest najważniejsza rzecz, bo do życia potrzebne jest jeszcze picie i jedzenie. W odpowiedzi usłyszałem, że jak będziecie mieli Internet to picie i jedzenie sobie załatwicie. OK, to załatwcie sobie teraz słuchawki z mikrofonem, bo Internet póki co jest.

To nowe doświadczenia dla wszystkich, ale co zrobimy teraz, nie będziemy musieli robić w wakacje.

Pomimo nietypowej sytuacji mogę chyba podsumować dyskusję dotyczącą celu, zakresu i sposobu oceniania w kursie TPUM. W planowanym uprzednio terminie nie otrzymałem żądnej propozycji merytorycznej, a w głosowaniu wzięły udział tylko 3 osoby z 33, które zapisały się na przedmiot. Ponieważ nie otrzymałem propozycji przedłużenia tego terminu, uważam dyskusję za zamkniętą i przyjmujemy nowe propozycje jako drogowskaz. Warunki zewnętrzne są dynamiczne, więc pozostawiam tę kwestię otwartą.

Oczywiście, stopień realizacji efektów kształcenia musi mieć wpływ na końcową ocenę bez względu na warunki zewnętrzne. Zaliczenie przedmiotu (otrzymanie minimalnej zaliczającej oceny, czyli 3.0) musi być natomiast uzależnione od osiągnięcia pewnych minimów w tym zakresie.

Problemy, które znam lub się domyślam można pogrupować w następujący sposób:

1. Fakultet wybrany, aby zapchać „dziurę”
1. .NET i Visual Studio
1. systemy operacyjne, a w tym Android
1. technologii Web-sockets
1. testowanie jednostkowego i integracyjne
1. wykorzystanie techniki MOCK
1. standaryzacja
1. współdziałanie interaktywne i reaktywne

## Fakultet wybrany, aby zapchać dziurę punktową

Z oczywistych powodów nie możemy nawet przez chwilę podnosić tego argumentu w kontekście dyskusji na temat sposobu realizacji przedmiotu. Rozumiem, że tego typu argumenty mogę pominąć milczeniem, by dalej nie pastwić się nad ich autorami.

**UWAGA**: Wszystkie osoby, które zmieniły preferencje co do wyboru przedmiotu z dowolnego powodu, proszę o informację w celu ręcznego wypisania ich z kursu. Oczywiście nie trzeba podawać przyczyny.

## .NET i Visual Studio

Zgadzam się z argumentem, że nie jest to jedyne środowisko programistyczne, które można wykorzystać. Jest jednak kilka ważkich powodów, dla których je wybrałem. Po konsultacji z osobami odpowiedzialnymi za utrzymanie oprogramowania narzędziowego w Instytucie, można skonkludować, że jest to jedyne oprogramowanie, którego sposób licencjonowania w kontekście realizacji dydaktyki nie budzi wątpliwości. Oprogramowanie jest dostępne dla studentów PŁ na mocy umów podpisanych z jego producentem firmą Microsoft. Oprogramowanie pokrywa potrzeby przedmiotu w zakresie efektów kształcenia. Nie jest naszym celem poznanie tej platformy, a jedynie jej wykorzystanie do realizacji postawionych celów. Preferencje studentów co do wyboru technologii realizacji projektu są tak różnorodne, że nie mogą być pomocne przy wyborze wspólnych wymagań, które powinny być podstawą stawiania wymagań i oceniania. Wybór tej platformy, moim zdaniem, jest szczególnie korzystny dla studentów, którzy nigdy z niej nie korzystali, ponieważ daje szanse do uatrakcyjnienie zbioru swoich kompetencji. Jest to platforma, którą najlepiej znam, więc w przypadku problemów szansa, że pomogą rozwiązać problem jest praktycznie 100%.

Czyli, żeby w pełni zrealizować efekty kształcenia trzeba przedstawić swoje rozwiązanie zgodnie z wymogami opublikowanymi w przestrzeni roboczej WIKAMP w pierwszym wymaganym terminie. Ale dla tych wszystkich, którzy czują awersję do tej platformy i tego uczucia nie są w stanie pokonać biorąc pod uwagę przedstawione powyżej argumenty, jako minimum zaliczeniowe w trzecim terminie można przedstawić rozwiązanie na dowolnej platformie, które jednak będzie zawierało program komputerowy zawierający elementy charakterystyczne dla urządzeń mobilnych. Tu przypomnę, że cyzelowanie graficznego interfejsu użytkownika (GUI) w kontekście specyficznych cech ekranów smartfonów („macalność”, wielkość, energooszczędność, itp.) jest przedmiotem rozważań związanych z ich ergonomią, a nie mobilnością – to inny przedmiot! Aby uniknąć problemów, w takim przypadku zaliczenie będzie realizowane na komputerze/smartfonie studenta, ale nadal trzeba umieć wykonać: lokalny klon, kompilację, wykonanie testów i omówić proponowane rozwiązanie – wykazać, że jest mobilne.

Podkreślam, że VS i .NET wspierają przenośność oprogramowania pomiędzy różnymi systemami, a w tym Android jest w pełni wspierany. Polecam pracę mojego studenta, a Waszego kolegi: [Reactive HMI Android application example]( https://github.com/Drutol/CrossHMI).

## Systemy operacyjne, a w tym Android

O ile dobrze zrozumiałem intencje, jedna z otrzymanych propozycji postuluje omawianie dostępnych na rynku produktów - a w szczególności  system operacyjny Android - związanych bezpośrednio lub pośrednio z mobilnością urządzeń. Na ten temat chyba mówiłem w trakcie pierwszych zajęć, ale nie wszystkie się odbyły. Jednak z racji tej formy i celu powtórzę tylko główne myśli w tym zakresie. Dydaktyka na PŁ, która pozwala poświadczyć prawo do dyplomu, musi mieć charakter akademicki (a nie produktowy) z kilku powodów. Dyplom jest dokumentem wydawanym na całe życie, a nie tylko zaświadczeniem na potrzeby najbliższej rekrutacji. Żywot i dynamika rozwoju produktów dziś jest ogromna, więc wiedza/umiejętności nabyte dziś, mogą się okazać całkowicie nieprzydatne jutro. Omawiając jakiś produkt, zwykle w co drugim zdaniu należy dodać w wersji X …. Ale nowe wersje wychodzą średnio kilka razy w roku. W trakcie zajęć nie jest możliwe omówienie wszystkich produktów, więc jak wybrać te najważniejsze – jaka jest miara ważności! Tym bardziej, że dla różnych uczestników kursu będzie inna, a wahania od niezbędne do całkowicie nieprzydatne. Niestety kategorycznie muszę odmówić podejścia produktowego. Pozostajemy przy założeniu, że produkty wykorzystujemy, bo musimy zdobyć pewne umiejętności, ale najważniejsza jest w miarę ogólna wiedza.

## Technologii Web-sockets

Wiem, że boicie się aplikacji rozproszonych, gdzie wykorzystuje się sieć do zapewnienia ich współdziałania, choć dziś praktycznie każda zespołowa gra zawiera takie elementy. Pewnie obawa wynika z faktu, że temat nie jest omawiany na innych przedmiotach, a przedmioty sieciowe były dawno i dotyczyły głównie infrastruktury. Z dyskusji na pierwszych zajęciach wynikało, że trudno sobie przypomnieć takie „egzotyczne” tematy jak: protokół IP, adres IP, okno TCP i czym TCP różni się od UDP. Nie jest prawdą, że one nie są związane z tematem. Są tylko pośrednio. Dla nas najważniejszą kwestią jest to, że urządzenia mobilne przemieszczają się względem infrastruktury komunikacyjnej, a nie względem przykładowo Słońca. Naszym celem jest popatrzeć na te zagadnienia z innej perspektywy. Ale bez obaw, osobno (webinar, post, książka, itp.) pokażę gdzie są gotowce, które można wykorzystać bez wchodzenia w szczegóły implementacyjne. Więc nie jest prawdą, że ten punkt projektu trzeba zrealizować całkowicie samodzielnie. Samodzielnie jedynie trzeba temat zrozumieć. Więc ogarnięcie tematu mieści się pomiędzy copy/paste - a świadome wykorzystanie.
Jeśli jednak kogoś to nie przekonuje, to za minimalny wymóg potwierdzający osiągnięcie efektów kształcenia, a zatem minimum zaliczeniowym będzie przedstawienie aplikacji, które się ze sobą komunikują w dowolny sposób, np. piętnasta wersja sklepu pod warunkiem, że użyte w programie dane będą strukturalne (definicję przypomniałem na ostatnim wykładzie). Czyli lada (front-end) i magazyn (back-end) komunikują się z wykorzystaniem sieci. Oczywiście nadal obowiązuje konieczność omówienia proponowanych rozwiązań w kontekście mobilności.

## Testowanie jednostkowe i integracyjne

To teraz temat na topie, ale faktycznie z tematem kursu ma jedynie związek pośredni. Biorąc jednak to pod uwagę, mogę przyjąć, że nie jest niezbędny w minimum zaliczeniowym, więc w trzecim terminie można pokazać i omówić rozwiązanie bez tego wymogu. Proszę jednak łatwo nie odpuszczać. Ja pokażę jak to zrobić i nie wymaga to dużej ilości pracy. To rozwiązanie jest wykorzystywane w wielu moich repozytoriach, a w tym w TP, więc proszę tam zajrzeć. Do tematu wrócimy wkrótce.

## Wykorzystanie techniki MOCK

Podobnie jak poprzednio, to teraz temat na topie, ale faktycznie z tematem kursu ma jedynie związek pośredni – pozwala zrealizować testowanie jednostkowe w miejsce testowania integracyjnego. Biorąc jednak to pod uwagę, mogę przyjąć, że nie jest niezbędny w minimum zaliczeniowym, więc w trzecim terminie można pokazać i omówić rozwiązanie bez tego wymogu. I znów, proszę łatwo nie odpuszczać. Ja pokażę jak to zrobić i nie wymaga to dużej ilości pracy. To rozwiązanie jest wykorzystywane w wielu moich repozytoriach, a w tym w TP, więc proszę tam zajrzeć. Do tematu wrócimy wkrótce.

## Standaryzacja

Jeśli aplikacje mobilne mają współdziałać, a są produktami różnych podmiotów gospodarczych, np. roboty KUKA i ABB, to współdziałanie musi być zrealizowanie na bazie standaryzacji choćby z powodów czysto formalnych. To tak samo działa, jak standard wtyczki zasilającej żelazko. Ostatnio (ale wystarczająco dawno 😊) sam się o tym przekonałem przy próbie włączenia do zasilania ładowaczki laptopa w hotelu we Włoszech. Ja proponuję wykorzystanie konkretnego standardu, by zachować praktyczny charakter naszego kursu, ale nie szczegóły tego standardu będą przedmiotem rozważań i wymagań.

Czyli, żeby w pełni zrealizować efekty kształcenia trzeba przedstawić swoje rozwiązanie zgodnie z wymogami opublikowanymi w przestrzeni roboczej WIKAMP w pierwszym wymaganym terminie. Ale dla tych wszystkich, którzy czują awersję do standaryzacji i tego uczucia nie są w stanie pokonać biorąc pod uwagę przedstawione powyżej argumenty, jako minimum zaliczeniowe w trzecim terminie można przedstawić rozwiązanie bez tego punktu (aktualnie zadanie 2).

## Współdziałanie interaktywne i reaktywne

Od zawsze aplikacje rozproszone współdziałają korzystając z modelu interaktywnego (architektura klient/serwer, np. Chrom/serwer WWW) albo reaktywnego (architektura publisher/subscriber, np. RSS). Ponieważ w minimum zaliczeniowym trzeba pokazać aplikacje jakoś się komunikujące, więc trzeba wybrać jeden z tych modeli, ale jako minimum zaliczeniowe w trzecim terminie można przedstawić rozwiązanie zawierające tylko jeden i to dowolny mechanizm.

## Podsumowując

COVID-19 ma wiele zabójczych wad, ale sytuacja, którą spowodował, promuje pisanie i czytanie - to chyba zaleta. **Więc miłego czytania w zdrowiu życzę** i piszczcie do mnie by współdziałanie miało charakter bardziej interaktywny, a nie tylko reaktywny. Jak wspominałem, organizuję również zajęcia typu WEBINAR, gdzie będziemy mogli wrócić do werbalnego i interaktywnego charakteru komunikacji. Jeśli o czymś zapomniałem to proszę o informację. Tu jednak muszę czekać na dostęp do zasobów, a to się opóźnia.

Jeśli jest coś niejasne proszę zaplanować konsultacje na Teams. Niektórzy już z tego korzystają - chwalę.

W najbliższym czasie (pewnie jutro) dostosuję treści WIKAMP do tych ustaleń i poinformuję o tym.

Zdrowia życzę i zachęcam do pracy pomimo trudności. Obyście zawsze wszystko mogli zorganizować sobie poprzez Internet. Z wodą i jedzeniem jest trudniej niż edukacją – taka jest fizyka zjawiska!
