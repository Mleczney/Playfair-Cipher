# PlayFair

**PlayFair** je desktopová aplikace (Windows Forms v C#), která umožňuje šifrování a dešifrování textu pomocí modifikované Playfair šifry s podporou českého a anglického jazyka. Program také normalizuje vstupní text, včetně převedení diakritiky a čísel na písmena, a zajišťuje vizuální formátování výstupu.

---

## 🔐 Funkce

- Podpora **Playfair šifry** s úpravami pro češtinu a angličtinu
- Převedení čísel (např. `3` → `THREE`) a české diakritiky (`ř` → `r`)
- Automatické dělení textu na dvojice a doplňování znaků, pokud je potřeba
- Umožňuje zobrazit šifrovací tabulku a upravený vstup
- Výběr jazyka (čeština / angličtina) ovlivňuje abecedu a pravidla

---

## 🧩 Použité principy

### 1. **Úprava textu**
Text se upravuje podle pravidel daného jazyka:
- Diakritika se převádí na základní znaky (`č` → `c`)
- Nahrazení čísel slovy (`1` → `ONE`)
- Vynechání opakujících se znaků ve dvojicích (vkládá se `x`)
- Pokud je vstupní text lichý, přidá se na konec `X` nebo `N`
- Mezery se nahrazují `XSPACEX`

### 2. **Tvorba tabulky**
Z klíče se vytvoří 5×5 tabulka znaků:
- V češtině chybí písmeno `W`, v angličtině `Q`
- Klíč se normalizuje a doplní se zbytek abecedy

### 3. **Šifrování / Dešifrování**
Probíhá podle pravidel Playfair šifry:
- Stejný řádek → posun doprava / doleva
- Stejný sloupec → posun dolů / nahoru
- Jinak → výměna sloupců mezi znaky

---

## 💻 Použití

### Šifrování:
1. Zadej klíč (např. `tajnyklic`)
2. Napiš text (např. `ahoj světe 123`)
3. Vyber jazyk
4. Klikni na `Encrypt`
5. Výstup se zobrazí ve formátu po 5 znacích

### Dešifrování:
1. Nech zadaný stejný klíč a jazyk
2. Klikni na `Decrypt`

---

## 🧪 Ukázka

**Vstup:**
Klíč: tajnyklic
Text: ahoj světe 123
**Po úpravě:**
AHOJXSVETEXONETWOTHREE
**Výstup:**
Šifrovaný text: FYGHD RPBAF HYRLP KWHGA

---
