# home-codeingStandardsRefactoring-celpratter
# Ausarbeitung Refactoring

## Was ist Refactoring?

Beim Refactoring strukturiert man den Code so um, dass er verständlicher,
leichter zu lesen und für andere nachvollziehbar ist. Beim Umstrukturieren, Löschen,
Ändern und Hinzufügen sollte sich die Funktionalität nicht ändern.

## Was sind die Vorteile / Nachteile?

### Vorteile

- verständlich für alle (bei Zusammenarbeit)
- Performance kann gesteigert werden (durch weniger Redundanzen, unnötige Zeilen,...)

### Nachteile

- aus Versehen den Code kaputt machen
- im Endprodukt sieht man keine Änderung / Verbesserung

## Welche Refactoring Schritte gibt es?

Zuerst muss ein Testcase definiert werden, den man immer wieder durchmacht,
um zu checken, ob das Script nach den Änderungen noch funktioniert.
Nach jeder kleinen Änderung sollte dieser Testcase geprüft werden. 
Um im Überblick zu haben, was man geändert hat und was schuld daran ist, dass
es nicht mehr funktioniert, sollte man jede einzelne Änderung testen und diese
mit einer beschreibenden commit message speichern.

1.) Einen Testfall definieren
2.) Sichergehen, dass das Programm funktioniert
3.) Ändern und Umstrukturieren in kleinen Schritten
4.) Den Testfall ausprobieren
5.) Commit

## Welche Prinzipien gibt es?

- DRY - Mehrfache Nennungen von Code verhindern, also mit Variablen arbeiten
- KISS - Der Code soll so einfach wie möglich gestaltet werden
- YAGNI - "Extras", die nicht unbedingt für die Funktion des Programms nötig sind, sollen entfernt werden
- Principle of Least Surprise - Die Funktionen sollten so sein, wie man es sich erwartet
- SoC - Der Code sollte in klare Abschnitte gegliedert sein
- Single Responsibility Principle - Klassen sollten nur für eine Sache zuständig sein und nicht mehrere Funktionen erfüllen

## Was ist ein Code Smell?

Teile im Code, die man aufgrund der Struktur ändern sollte - nicht weil es ein Programmfehler ist. Der Code funktioniert also, aber wird umgeschrieben"

## 10 Code Smells, die eigene Projekte betreffen?

### Kommentare
Kommentare sollen eine Stütze sein - zu viele sinnlose Kommentare sind überflüssig

### Nichtssagende Namen
Sowohl Variablen, als auch Klassen sollten so benannt werden, dass man davon die Funktion ablesen kann

### Doppelter Code
Ein Code kommt zwei mal vor

### Lange Methode
Eine Methode ist zu lang.

### Große Klasse
Zu viele Variablen und generell zu umfangreich

### Kurze Namen
Einzelne Buchstaben, anstatt beschreibender Name

### Lange Namen
Variablen oder Klassen haben viel zu lange Namen

### Ausgeschlagenes Erbe
Unterklassen erben Methoden und Daten, die sie gar nicht brauchen

### Tiefe Verschaftelungen
Verschachtelungen, die den Code unlesbar machen

### Datenklasse
Klassen mit Feldern ohne Funktionalität


# README

## Development Platform

- OS: MacOS 10.14.3
- Unity Version: 2019.1.14f1
- Visual Studio Code Version: 1.33.0
- Scripting Runtime Version: .NET 4.x Equivalent
- API Compatibility Level: .NET 2.0

## Testcase
Play drücken, über drei Hindernisse springen, gegen das vierte laufen, restart.

## Copyright Game

SantaRun by smeerws
