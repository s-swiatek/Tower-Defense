Metadane
·	Format: User story (jako gracz, chcę…, aby…) + kryteria akceptacji
·	Skala estymacji: 1 / 2 / 3 / 5 / 8 / 13 (story points)
·	Priorytet: High / Medium / Low
Epik A - Podstawowa rozgrywka
A1 - Aplikacja uruchamia się i ładuje główne menu
ID: A1
User story:
Jako gracz chcę widzieć ekran startowy z przyciskiem „Graj”, „Opcje” i „Wyjście”, aby rozpocząć rozgrywkę lub zmienić ustawienia.
Kryteria akceptacji:
·	Po uruchomieniu wyświetla się ekran startowy z 3 przyciskami
·	Naciśnięcie „Graj” przechodzi do wyboru poziomu
·	Naciśnięcie „Opcje” otwiera ekran ustawień
Priorytet: High
Estymacja: 2
A2 - Podstawowa rozgrywka 1 falowa (game loop)
ID: A2
User story:
Jako gracz chcę rozegrać jedną falę przeciwników, aby zobaczyć działanie mechaniki.
Kryteria akceptacji:
·	Przeciwnicy spawnują z punktu A i podążają do punktu B po ścieżce
·	Gracz może postawić podstawową wieżę na przygotowanych polach
·	Wieża ostrzeliwuje przeciwników w zasięgu i zadaje obrażenia
·	Po zniszczeniu wszystkich przeciwników pojawia się ekran zwycięstwa dla tej fali
Priorytet: High
Estymacja: 8
A3 - Ruch i kolizje przeciwników
ID: A3
User story:
Jako gracz chcę, aby przeciwnicy poruszali się płynnie po ścieżce i kolidowali z końcem ścieżki (zadawanie obrażeń bazie).
Kryteria akceptacji:
·	Przeciwnik osiąga końcowy punkt i zmniejsza żywotność bazy o wartość obrażeń
·	Kolizje z przeszkodami nie blokują ruchu (przeciwnicy omijają przeszkody, jeśli zaprojektowano ścieżkę)
Priorytet: High
Estymacja: 5
Epik B - System wież i ulepszeń
B1 - Podstawowa wieża (shooting)
ID: B1
User story:
Jako gracz chcę kupić i postawić podstawową wieżę, która strzela co X sekund, by eliminować wrogów.
Kryteria akceptacji:
·	Wieża ma koszty, zasięg i DPS podstawowy
·	Po postawieniu zużywa pieniądze gracza
·	Wieża automatycznie celuje w najbliższego lub najsłabszego (konfigurowalne) wroga
Priorytet: High
Estymacja: 5
B2 - System ulepszeń wież (drzewko 2 poziomy)
ID: B2
User story:
Jako gracz chcę ulepszać wieże (poziom 1 -> 2 -> 3), aby zwiększać ich statystyki.
Kryteria akceptacji:
·	Ulepszenie zwiększa DPS, zasięg lub szybkość strzału
·	Ulepszenie ma koszt i animację potwierdzającą
·	Maksymalny poziom ulepszeń wynosi 3
Priorytet: High
Estymacja: 8
B3 - Różne typy wież (dmg, slow, aoe)
ID: B3
User story:
Jako gracz chcę mieć różne typy wież (np. Cannon - AoE, Frost - spowalnia, Archer - szybkie pojedyncze trafienie), żeby dobierać strategię.
Kryteria akceptacji:
·	Co najmniej 3 unikalne typy wież z różnymi statystykami i zachowaniem
·	Każdy typ ma ikonę i opis w tooltipie
Priorytet: High
Estymacja: 13
Epik C - Ekonomia i balans
C1 - System waluty i nagród za zabicie
ID: C1
User story:
Jako gracz chcę otrzymywać pieniądze za zabicie wroga i za ukończenie fali.
Kryteria akceptacji:
·	Zabicie przeciwnika daje zdefiniowaną ilość waluty
·	Ukończenie fali daje bonusowe pieniądze
·	Waluta wyświetlana jest w HUD i aktualizuje się na bieżąco
Priorytet: High
Estymacja: 3
C2 - Sklep i UI do kupowania i sprzedawania wież
ID: C2
User story:
Jako gracz chcę widzieć ofertę wież, ich koszty i możliwość sprzedania lub opuszczenia wieży.
Kryteria akceptacji:
·	Interfejs sklepu pokazuje ceny i statystyki
·	Możliwość sprzedania wieży zwraca część kosztu
Priorytet: High
Estymacja: 5
Epik D - Poziomy, kampania i progresja
D1 - System poziomów (mapy)
ID: D1
User story:
Jako gracz chcę wybierać mapę lub poziom z listy, aby grać różne plansze.
Kryteria akceptacji:
·	Ekran wyboru mapy z miniaturą i krótkim opisem
·	Co najmniej 3 wstępne mapy (łatwa, średnia, trudna)
Priorytet: High
Estymacja: 5
D2 - Mechanika fal i progresji trudności
ID: D2
User story:
Jako gracz chcę, żeby liczba i siła przeciwników rosła w kolejnych falach.
Kryteria akceptacji:
·	Konfiguracja fal: liczba, typy enemy, opóźnienia
·	Trudność wzrasta przewidywalnie i mierzalnie
Priorytet: High
Estymacja: 8
Epik E - Przeciwnicy i AI
E1 - Podstawowe typy przeciwników
ID: E1
User story:
Jako gracz chcę widzieć różne typy wrogów (szybki, tank, latający) z unikalnymi właściwościami.
Kryteria akceptacji:
·	Co najmniej 3 typy wrogów zaimplementowane i testowane
·	Latający ignoruje przeszkody naziemne (jeśli występują)
Priorytet: High
Estymacja: 8
E2 - Boss na końcu poziomu
ID: E2
User story:
Jako gracz chcę spotkać bossa z większą pulą HP i unikalnymi zdolnościami.
Kryteria akceptacji:
·	Boss ma HUD z paskiem życia i specjalnym atakiem lub innym unikalnym zachowaniem
·	Po zabiciu bossa przyznawany jest bonus (waluta lub XP)
Priorytet: Medium
Estymacja: 8

