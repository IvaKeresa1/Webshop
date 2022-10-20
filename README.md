ECommerceWebshopProject


Github: https://github.com/IvaKeresa1/Webshop/tree/master

Koraci za pokretanje projekta: 
 
Pokrenuti projekt nakon što smo izabrali opciju “Set as Startup project”
Kada se stranica otvori, potrebno je kliknuti na "Register" gumb te u polje UserName upisati admin@admin.com, proizvoljnu šifru, FirstName I LastName.
Kliknuti "Save" I ulogirati se u stranicu s admin@admin.com Emailom I šifrom koja je upisana prilikom registracije
Kada je proces odrađen, potrebno je otići u "Role manager" te dodati novu rolu pod nazivom "Super admin" te zatim otići u Assign role i admin@admin.com dodijeliti rolu super admina
Izlogirati se iz stranice i opet se ulogirati
 
 
 
Čemu projekt služi i kako radi
 
 
Projekt je Webshop koji služi za kupovinu proizvoda u raznim kategorijama. 
Uz kupovinu, moguće je I dodavanje novih proizvoda, kategorija (ProductTypes) I posebnih oznaka (SpecialTag) kako bi se što lakše navigiralo podacima koji se spremaju u bazu. Lista klijenata vidljiva je adminu te je moguće uređivanje, zaključavanje, brisanje I dodavanje novih korisnika. 
 
1. Registracija 
 
Za registraciju je potrebno popuniti sva polja I kliknuti "Save" gumb. Važno je napomenuti kako postoje sljedeća pravila za unos passworda:
 
Passwords must be at least 6 characters 
Passwords must have at least one non alphanumeric character.
Passwords must have at least one digit ('0'-'9').
Passwords must have at least one uppercase ('A'-'Z').
 
Klikom na "Save", korisniku se automatski dodjeljuje "user" rola koja se potom zapisuje u bazi. 

 
2. Role

2.1. User 
 
U ulozi Usera, korisnik može pregledavati proizvode, staviti ih u košaricu I doći do zadnjeg koraka prije naplate gdje je vidljivo što se sve nalazi u košarici. Iz košarice je moguće brisati proizvode sve do zadnjeg koraka ili klikom na proizvod koji je već dodan u košaricu klikom na gumb "Remove from cart". Također, osim na inicjalnoj stranici gdje su izlistani proizvodi koji su u ponudi, moguće je u navigaciji kliknuti na "Category" te će korisnik biti odveden na listu kategorija te će biti izlistani isključivo proizdvodi koji se nalaze u toj kategoriji (productTypes). 
 
2.2. Super admin
 
  2.2.1. Kreiranje Product Type I Special Tag (nužno za kreiranje proizvoda)
 
  Uloga super admina omogućuje kreiranje Product Typea koji je u svrsi kategorije proizvoda te je nužan korak prije samog dodavanja novog proizvoda te kreiranje Special Taga koji će još pobliže razdijeliti proizvode 
 
 
  2.2.2. Kreiranje proizvoda
 
 
  Moguće je dodavanje novih proizvoda te upisivanje podataka u sljedeća polja; Name, Price, Image, Product Color, Product Type, Special Tag I oznaka je li proizvod dostupan ili ne. Učitavanje slike je obavezno kako bi se uspješno dodao proizvod. ProductType I Special Tag polja imaju padajući izbornik te je za mogućnost odabira opcija nužno prvo dodati željeni Special Tag I Product Type (slika 1. I 2.) 
 

  2.2.3. Kreiranje nove role
 
  Dodavanje nove role nužan je korak prije dodjeljivanje određenih rola korisnicima. Novu rolu moguće je dodati, urediti ili izbrisati. Nema limita koliko novih rola može biti dodano. User rola je generirana automatski prilikom registracije prvog usera (slika 2.)
 
 
  2.2.4. Dodjeljivanje role korisnicima
 
  Oba polja su padajući izbornici sastavljeni od opcija koji su dodani prilikom registracije usera u user roli ili dodavanja usera preko admin role. 
 
 
  2.2.5. Pregled svih korisnika
 
  Klikom na "User list" gumb u navigaciji, otvara se pregled svih korisnika koji su registrirani ili dodani preko admin role. Moguće je dodati novog usera, zaključati postojećeg (preduvjet za brisanje), brisanje te uređivanje.
 
 
 
