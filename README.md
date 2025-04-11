
# 🚗 ÖVNING C# - Fordonshanteringssystem  
Inkapsling, Arv & Polymorfism i C#

---

## 📋 Funktioner

### 🔹 Del 1 – Inkapsling

**1️⃣ Klass Vehicle**  
Privata fält:
- `brand`, `model`, `year`, `weight`

Publika properties med validering:
- **Brand** och **Model**: 2–20 tecken  
- **Year**: mellan 1886 och nuvarande år  
- **Weight**: positivt tal  

Felhantering:
- Vid ogiltig inmatning kastas `ArgumentException` med tydligt felmeddelande.

**2️⃣ Klass VehicleHandler**  
Metoder för att:  
- Skapa nya fordon  
- Uppdatera värden (ex: ändra modell, vikt, etc.)  
- Lista alla fordon  

**3️⃣ Felhantering**  
Alla metoder omges av `try-catch` i `Program.cs` för att fånga och visa eventuella fel.

---

### 🔹 Del 2 – Polymorfism

**Abstrakt klass SystemError**  
- Metod: `ErrorMessage()` (abstrakt)

**Subklasser:**
- `EngineFailureError`: "Motorfel: Kontrollera motorstatus!"
- `BrakeFailureError`: "Bromsfel: Fordonet är osäkert att köra!"
- `TransmissionError`: "Växellådsproblem: Reparation krävs!"

Felmeddelanden skrivs ut via `foreach` över en lista av `SystemError`.

---

### 🔹 Del 3 – Arv

**Abstrakt klass Vehicle**  
- Metoder: `StartEngine()` och `Stats()` (returnerar `string`)

**Subklasser:**
- `Car` → unik egenskap: t.ex. `HasSunroof`
- `Truck` → t.ex. `CargoCapacity`
- `Motorcycle` → t.ex. `HasSidecar`
- `ElectricScooter` → t.ex. `BatteryRange`

Alla override:  
- `StartEngine()` → varje fordon har ett eget sätt att "starta"

---

### 🔹 Del 4 – Mer Polymorfism

- `List<Vehicle>` innehåller olika fordonstyper  
- Loopar igenom listan:
  - Visar `Stats()`
  - Anropar `StartEngine()`

**Interface ICleanable**
- Metod: `Clean()`
- Implementeras av t.ex. `Truck` och `Car`

Om ett fordon implementerar `ICleanable`, anropas `Clean()` i loopen.

---

## ⚠️ 🛠️ Att göra / Buggar att åtgärda 🪲

- Direktvalidering i `AddVehicle` `UpdateVehicle`
Just nu visas felmeddelanden (t.ex. för kort märke eller ogiltigt årtal) först efter att alla fält har fyllts i.
Varje fält bör valideras omedelbart, och vid fel bör processen stoppas direkt för att förbättra användarupplevelsen.

- Utlogik i InputHelper
Nuvarande logik visar inte ett tydligt meddelande som "Press anykey to exit..." efter ett fel.
Att implementera: en riktig utgångslogik efter ogiltig inmatning, utan att fastna i den oändliga loopen med `InvalidInputMessage`,
vilket just nu tvingar användaren att tvångsavsluta programmet för att kunna avsluta.

- Kodstruktur / organisering
Program.cs är för "tungt".
Förslag:
  - Skapa en mapp Utilities eller UserInteraction för menyer och användarinteraktion.
  - Skapa en separat fil för `DemoVehicleActions` för att strukturera huvudkoden bättre.

-------

## 🧪 Att förbättra / Implementera 🔧
- ➕ Användarinmatning via meny
- ➕ Möjlighet att ta bort ett fordon
- 🔒 Mer robust validering
- 🔁 Spara/ladda fordon via fil

---

## 🛠 Installation

1. Klona detta repo  
2. Öppna terminalen i projektmappen  
3. Se till att du har **.NET SDK** installerat  
4. (Om nödvändigt) Återställ beroenden:  
```bash
dotnet restore
```
5. Kör programmet:  
```bash
dotnet run
```
