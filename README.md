1. Problem 1.Debit Card Number

Write a program, which receives **4**** integers **on the console and** prints them **in** 4-digit debit card format**. See the examples below for the appropriate formatting.

### Examples

| **Input** | **Output** |
| --- | --- |
| 1243315331 | 0012 0433 0001 5331 |
| 91824221123 | 9182 4221 0012 0003 |
| 81232112322 | 0812 0321 0123 0022 |

### Problem 4.  \* Beverage Labels

Write a program, which reads a food product **name**, **volume**, **energy content per 100ml and sugar content per
100ml** and **sugar content per 100ml**. Calculate the **energy** and **sugar content** for the **given volume** and print them on the console in the following
format:

* Name - as per the input
* Volume - **integer**, **suffixed** by "**kcal**" (e.g. "**500kcal**")
* Sugar content - **real number**, **suffixed** by "**g**" (e.g. "**30g**")

#### Examples
| **Input** | **Output** |
| --------- | ---------- |
| Nuka-Cola<br> 220<br> 300<br> 70<br> | 220ml Nuka-Cola:<br> 660kcal, 154g sugar |


| **Input** | **Output** |
| --------- | ---------- |
| Ice Cold Nuka-Cola<br> 250<br> 350<br> 65 | 250ml Ice Cold Nuka-Cola:<br> 875kcal, 162.5g sugars |

| **Input** | **Output** |
| --------- | ---------- |
| Nuka-Cola Quantum<br> 350<br> 600<br> 140<br> | 350ml Nuka-Cola Quantum:<br> 2100kcal, 490g sugars |

1. Problem 5.\* Character Stats

Write a program, which **displays information** about a video game character. You will receive their **name** , **current health** , **maximum health** , **current energy** and **maximum energy** on separate lines. The **current** values will **always** be valid ( **equal or lower** than their respective **max** values). Print them in the format as per the examples.

### Examples

| **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- |
| Mayro510910 | Name: MayroHealth: ||||||.....|Energy: ||||||||||.| | Bauser10101010 | Name: BauserHealth: ||||||||||||Energy: |||||||||||| |

| **Input** | **Output** |   | **Input** | **Output** |
| --- | --- | --- | --- | --- |
| Loogi820214 | Name: LoogiHealth: |||||||||............|Energy: |||............| | Toad05010 | Name: ToadHealth: |.....|Energy: |..........| |

### Hints

- You can print a character **multiple** times, using **new string(character, count)**.

