# Mouse Speed Changer
### Jednoduchá konzolová aplikace, která pomocí Win32 API mění citlivost myši.

Windows User je komponenta, která zajišťuje např.vytváření a správu UI vč. ovládání myši. V OS je reprezentována knihovnou user32.dll. Z C# je možné používat Win32 API pro přístup k nativním knihovnám OS.

---
Pro použití stačí jednoduše využít knihovnu MouseSettingsChanger:

* Přidat referenci na knihovnu MouseSettingsChanger do řešení (.NET Standard)
* Zavolat metodu ChangeMouseSpeed()


```csharp
// new mouse speed value
UInt32 mouseSpeed = 5;

// change sensitivity
Changer.ChangeMouseSpeed(mouseSpeed); 
```
---

MS Dokumentace k **[SystemParametersInfo](https://msdn.microsoft.com/en-us/library/ms724947.aspx)**.