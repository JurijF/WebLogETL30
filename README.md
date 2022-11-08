# WebLogETL_LF8
## 1. Projekt-Beschreibung
Ein Webserver protokolliert alle Zugriffe in einer log-Datei. 
<br>Um den Zugriff auf einen Webserver über einen längeren Zeitraum analysieren zu können,<br>
ist es notwendig, viele dieser log-Dateien in einer Analyse zu berücksichtigen.<br>
Dieses LF08-Projekt hat daher zum Inhalt, eine Software zu entwickeln, die es erlaubt,<br> 
log-Dateien in einem sog. ETL-Prozess¹ in einer SQLite-Datenbank <b>zusammenzuführen</b> und
diese bereitgestellten Daten zu <b>analysieren</b>:

![grafik](https://user-images.githubusercontent.com/104195315/199200535-78f225d9-ae03-48c9-9bbb-547741a9a081.png)

Die Software soll als Windows-Desktop-Client in C# realisiert werden, wobei entweder
WinForms oder WPF verwendet wird.

## 2. Logfile
Für dieses Projekt kommt ein reales logfile der Firma netnea² aus der Schweiz als Beispiel-
logfile zum Einsatz, das von der Firma für dieses Projekt zur Verfügung gestellt worden ist
(die Genehmigung liegt schriftlich vor).<br> 
Das logfile wurde allerdings noch für dieses Projekt angepasst, indem die realen IP-Adressen ersetzt worden sind (Datenschutz).<br>
Es ist für diese Projekt natürlich notwendig, die Struktur der logfile-Einträge zu analysieren³.<br>
Hier ein Ausschnitt eines logfiles in der verwendeten Form:

![grafik](https://user-images.githubusercontent.com/104195315/199201185-fc35b55a-4a90-4a33-9da4-95e6ee6bbae2.png)

¹ https://de.wikipedia.org/wiki/ETL-Prozess <br>
² https://www.netnea.com/ <br>
³ https://httpd.apache.org/docs/current/mod/mod_log_config.html#formats

## 3. Anforderungsbeschreibung
Es versteht sich von selbst, dass das Programm ohne Abstürze läuft und im Fehlerfall
geeignete Fehlermeldungen angezeigt.<br>
Für die gesamte Anwendung ist die .NET-SQLite-Bibliothek System.Data.SQLite zu
verwenden.<br>
Andere Bibliotheken oder das Entity-Framework sind nicht erlaubt.<br>
Die folgenden Anforderungsbereiche ordnen die Funktionalität der Anwendung.

### 3.1 Anforderungsbereich GUI
Es gibt für den Aufbau des GUI keine Vorgaben, sondern ist von jeder Projektgruppe selbst zu entwickeln.<br> 
Es gilt lediglich, dass die folgenden Funktionalitäten vorhanden sein müssen:

● Der Benutzer muss die log-Dateien auswählen können, die in die Datenbank geladen
werden sollen. Die Dateiendung ist .log.<br>
● Die in die Datenbank bereits importierten log-Dateien müssen angezeigt werden.<br>
● Das erneute Importieren von bereits importierten log-Dateien muss verhindert werden.<br>
● Der Benutzer muss die unten aufgeführten Analysen durchführen können.

### 3.2 Anforderungsbereich Datenbank
Es ist eine SQLite-Datenbank zu verwenden.<br>
Die Struktur der Datenbank ist komplett selbst zu entwickeln.

### 3.3 Anforderungsbereich Analyse
Dieser Anforderungsbereich muss komplett durch an die Datenbank gerichtete SQL-Abfragen
realisiert werden (also kein LINQ o.ä.).<br>
Alle angegebenen IPs werden im Format IPv4 erwartet und müssen vom prinzipiellen Aufbau
her korrekt sein.<br> 
Beispielsweise wäre eine IP 123.12.12. $\textcolor{red}{\text{967}}$ nicht korrekt. 
<br>Eine Unterscheidung bzgl. öffentlicher oder privater IP-Bereiche ist nicht nötig.
Die folgenden Analysemöglichkeiten soll die Software bieten:

![grafik](https://user-images.githubusercontent.com/104195315/199203919-b6ee8dc4-08c1-4156-915a-16063331c2ce.png)
![grafik](https://user-images.githubusercontent.com/104195315/199204017-57dae252-b6aa-4599-8b6e-d13ebcb35981.png)
![grafik](https://user-images.githubusercontent.com/104195315/199204096-3cf6ede7-a209-4570-ab22-306b144b6068.png)
![grafik](https://user-images.githubusercontent.com/104195315/199204151-ac0b08fe-15ff-4ff7-9986-a3bff767eb64.png)

### 4.  Abgabe
Das Projekt ist als (auf den Schulrechnern!) lauffähiges Programm abzugeben.<br> 
Zusätzlich dazu ist das VisualStudio-Projekt abzugeben.<br>
Das Projekt kann zu zweit oder zu dritt bearbeitet werden.<br>

$\textcolor{red}{\text{Die Abgabe erfolgt über den moodle-Kurs am:}}$ &nbsp;&nbsp;&nbsp;&nbsp; $\textcolor{red}{\text{13.12.2022}}$<br>
$\textcolor{red}{\text{zum Ende der Unterrichtsstunde}}$ $\textcolor{red}{\text{um:}}$ &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; $\textcolor{red}{\text{11:20 Uhr}}$
