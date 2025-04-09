# ConvertGregorianDateToSolar

![NuGet](https://img.shields.io/nuget/v/ConvertGregorianDateToSolar)
![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)
![NuGet Downloads](https://img.shields.io/nuget/dt/ConvertGregorianDateToSolar.svg)
![.NET Version](https://img.shields.io/badge/.NET-9-purple.svg)

A minimal .NET library that converts **Gregorian dates to Persian (Shamsi) format** using `PersianCalendar`.  
Perfect for applications targeting Iranian users.

---

## ✨ Features

- 🔁 Converts a `DateTime` value to the Shamsi (Persian) calendar.
- 📅 Uses `System.Globalization.PersianCalendar` internally.
- 💼 Useful for desktop or web applications needing localized date formats.

---

## 🚀 How to Use

### Install via .NET CLI:
```bash
dotnet add package ConvertGregorianDateToSolar
```

## Or via Package Manager:
```
Install-Package ConvertGregorianDateToSolar
```

## 💡 Example
```
using System;
using ConvertGregorianDateToSolar;

class Program
{
    static void Main(string[] args)
    {
        var converter = new ConvertDate();
        var today = DateTime.Now;
        string shamsi = converter.ToShamsiDate(today);

        Console.WriteLine($"Shamsi Date: {shamsi}");
    }
}
```

## ✔️ Sample Output:
```
Shamsi Date: 1404/1/20
```

## ⚙️ Method
```
public string ToShamsiDate(DateTime date)
```
Description: Converts the given DateTime to a string in yyyy/MM/dd format based on the Persian calendar.

## 🛠 Target Framework
**.NET 9**

## 📦 NuGet Package
You can get the package from NuGet:
https://www.nuget.org/packages/ConvertGregorianDateToSolar/

## 📄 License
This project is licensed under the MIT License — free for personal and commercial use.
See the LICENSE file for more information.

## 👨‍💻 Author
Created with ❤️ by Hamed Heydarian
GitHub: https://github.com/hheydarian

## 🚧 This project is under active development and will be expanded with more features like:

"Shamsi to Gregorian conversion"
"Localized formatting options"
"Extended date formatting patterns"
