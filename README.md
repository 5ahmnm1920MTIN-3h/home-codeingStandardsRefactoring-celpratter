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

```c#
// init rigidbody
Rigidbody2D rb;
// init animator
Animator anim;

```

### Nichtssagende Namen
Sowohl Variablen, als auch Klassen sollten so benannt werden, dass man davon die Funktion ablesen kann

```c#
private string baumschuleABCD;
```

### Doppelter Code
Ein Code kommt zwei mal vor

```c#
public void Restart()
    {
        SceneManager.LoadScene(mainScene);
    }
public void Resume()
    {
        SceneManager.LoadScene(mainScene);
    }
```

### Lange Methode
Eine Methode ist zu lang.

```c#
public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
	float c = float.Parse(ipVarC.text);
	float d = float.Parse(ipVarD.text);
        result.text = NumbersAdd(a, b).ToString();
        ipVarA.interactable = false;
        ipVarB.interactable = false;
        btn_add.interactable = false;
        btn_reset.interactable = true;
    }
```

### Große Klasse
Zu viele Variablen und generell zu umfangreich

### Kurze Namen
Einzelne Buchstaben, anstatt beschreibender Name

```c#
private string a = "Baumschule";
```

### Lange Namen
Variablen oder Klassen haben viel zu lange Namen

```c#
private float ThisIsMyNewVariableForTheNeededFloatValue = 2;
```

### Ausgeschlagenes Erbe
Unterklassen erben Methoden und Daten, die sie gar nicht brauchen

### Tiefe Verschaftelungen
Verschachtelungen, die den Code unlesbar machen

### Datenklasse
Klassen mit Feldern ohne Funktionalität

*(Idee die Beispiele so einzubinden ist von kkoenig)*

## Testcase
Play drücken, über drei Hindernisse springen, gegen das vierte laufen, restart.

# Santa Run

### Project description: 
This is a simple 2D side-scroll game. The Santa runs from left to right and has to avoid some obstacles by jumping over them.
The game ends when the Santa hits an obstacle.  The goal is to avoid as many obstacles as possible.

### Development platform: 
Windows 10, Unity version 2019.1.14f1, Visual Studio Community 2017, Scripting Runtime Version: .NET 4.0

### Target platform: 
WebGl and Standalone, RefRes: 1920 * 1080


### Visuals: 

https://www.youtube.com/embed/2C74XxBkFfI

### Necessary setup/execution steps: 
For playing the game go to: 
* WebGL: https://hs-teaching.github.io/WegGL-SantaRun/
* Standalone (.exe): Clone project and publish as Standalone

For development: Clone this project. 

### Third party material: 
* This game is based on the game Santa Run developed by Raja Biswas in the Udemy-course Unity 2018 Game Developmen by Example 
[Unity 2018 Game Development by Example](https://www.udemy.com/course/unity-2d-game-development-by-example/).
* Sprites are used from https://www.gameart2d.com/santa-claus-free-sprites.html


### Project state: 
Program is working correctly, no errors, refactoring is needed.
Refactoring needed: 
* del not used namespaces
* del unused variables
* del needless debugs
* del needless comments
* del unused methods
* rename variables (coding standards)
* rename methods (coding standards)
* fix poor conditional clauses
* fix poor formating
* replace magic string
* replace magic number

### Limitations: 
Only one level is implemented. 

### Lessons Learned: 
* Create 2D Scenes
* Use Quads for moving Backgrounds (Textures instead of Sprites)
* Use Particle System for snowing effect.
* Use Scene Management for switching between Scenes
* Create and control Animations (Animation, Animator and Scripts)
* Use the singelton pattern
* Spawn objects
* Use UI elements and manipulate UI elements with scrips


Copyright by smeerws
