# Feedback

## Etap 2

## Warstwa danych

- Co znaczy w praktyce, że w tej warstwie ma mają być reprezentowane granice poruszania się i kulki? Interfejs zawierający promień i masę, który jest rozszerzany warstwę wyżej?
- Co znaczy w praktyce "Balls representation are independent and self-contained (no timer required)"? Reprezentacje kulek mają być niezależne, co oznacza reszta?

## Warstwa logiki

- "responsibility of this layer is to manage movement rectangle boundaries and balls interaction (collisions)"

Warstwa danych ma reprezentować granice, a w warstwie logiki mamy je zaimplementować i dodać kulkom współrzędne?
Jeśli mam listę kulek w tej warstwie, to czy żeby spełnić wymagania wystarczy, żeby w warstwie danych pojawił się interfejs kulek, którego rozszerzamy w warstwie logiki?

- "prove that the protection of data integration is implemented"

Co oznacza integracja danych i jak ją chronic?
