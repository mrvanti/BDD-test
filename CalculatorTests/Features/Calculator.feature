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


Scenario: Multiplikation i miniräknaren
  Givet att två tal matas in
  | tal1 | tal2 | 
  |   3  |   5  | 
  |   4  |   7  | 
  |   6  |   8  | 
  När de två siffrorna multipliceras från tabell
  Så ska resultatet bli:
    | resultat |
    | 15       |
    | 28       |
    | 48       |