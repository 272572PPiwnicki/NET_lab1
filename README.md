# 🧠 Knapsack Problem Solver (.NET 8.0)

Projekt konsolowej aplikacji w języku C# rozwiązującej klasyczny problem plecakowy (0/1 Knapsack Problem) przy użyciu algorytmu zachłannego.

---

## 📌 Informacje

- **Autor:** *Patryk Piwnicki*
- **Prowadzący:** mgr inż. Michał Jaroszczuk
- **Grupa:** [SR][17:05]
- **Data:** 19 marca 2025

---

## 🔧 Technologie

- C#
- .NET 8.0
- MSTest
- Visual Studio 2022

---

## ⚙️ Opis Działania

Program generuje instancję problemu plecakowego na podstawie liczby przedmiotów i ziarna (seed) losowania, a następnie rozwiązuje go za pomocą algorytmu zachłannego:
- Sortuje przedmioty malejąco według stosunku wartość/waga.
- Dodaje kolejne przedmioty do plecaka, o ile ich łączna waga nie przekracza pojemności.
- Zwraca łączną wartość, wagę oraz indeksy wybranych przedmiotów.

---

## 🌲 Drzewo projektu

![image](https://github.com/user-attachments/assets/c6f4c6dd-a899-40a8-8220-38e2ada61363)

---

## 🔍 Kluczowe klasy

- **Item** - przechowuje wartość, wagę i współczynnik opłacalności (Ratio).
- **Problem** - generuje dane i rozwiązuje problem metodą zachłanną (Solve()).
![image](https://github.com/user-attachments/assets/a671d147-d349-4f15-83d4-2f62f5078d3d)

- **Result** - przechowuje wynik: wartość, waga i lista wybranych przedmiotów.
- **Test1** - testy jednostkowe (m.in. poprawność wyniku, puste rozwiązanie, przekroczenie pojemności).

---

## ✅ Testy jednostkowe

Testy obejmują następujące funkcjonalności:
- Przynajmniej jeden przedmiot mieści się w plecaku.
- Żaden przedmiot się nie mieści.
- Poprawność wyników na znanym zestawie danych.
- Suma wag nie przekracza pojemności.
- Wszystkie przedmioty mieszczą się przy dużej pojemności.
