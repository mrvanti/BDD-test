#language: sv-SE
Egenskap: Calculator

Enkel miniräknare


Scenario: Adderas två tal
	Givet den första siffran är 70
	Och den andra siffran är 50
	När de två siffrorna adderas
	Så ska resultatet bli 120

Scenario: Subtrahera två tal
	Givet den första siffran är 70
	Och den andra siffran är 50
	När de två siffrorna subtraheras
	Så ska resultatet bli 20

Scenario: Multiplicera två tal
	Givet den första siffran är 70
	Och den andra siffran är 50
	När de två siffrorna multipliceras
	Så ska resultatet bli 3500

Scenario: Modulo två tal
	Givet den första siffran är 10
	Och att modulo är 3
	När de två siffrorna moduleras
	Så ska resten bli 1

Scenario: Addera två tal från tabell
	Givet följande tal
	| Siffra ett | Siffra två |
	| 99         | 33         |
	| 20         | 24         |
	När talen adderas
	Så ska resultatet bli
	| Resultat |
	| 132      |
	| 44       |