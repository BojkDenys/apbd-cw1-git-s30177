Zadanie 5.
W jednym z zadań merge nie był fast-forward, ponieważ po utworzeniu gałęzi feature-max został dodany dodatkowy commit bezpośrednio w gałęzi main. W rezultacie obie gałęzie miały własne zmiany i Git musiał utworzyć merge commit.
Odpowiedzi na pytania:
1.Git wykonuje fast-forward wtedy, gdy gałąź main nie ma nowych commitów od momentu utworzenia gałęzi roboczej. Merge commit powstaje wtedy, gdy obie gałęzie mają własne nowe commity i Git musi połączyć historię obu gałęzi.
2.Merge polega na połączeniu dwóch gałęzi i utworzeniu dodatkowego commitu, który je łączy.Rebase działa inaczej, ponieważ przenosi commity z jednej gałęzi na koniec drugiej gałęzi, dzięki czemu historia wygląda bardziej liniowo.
3.Konflikt został wywołany przez zmianę tego samego fragmentu kodu w gałęzi main oraz w gałęzi feature-conflict. Podczas próby połączenia gałęzi Git zgłosił konflikt. Plik został edytowany ręcznie, wybrana została poprawna wersja kodu, a następnie plik został zapisany, dodany poleceniem git add i wykonany został commit kończący operację merge.
