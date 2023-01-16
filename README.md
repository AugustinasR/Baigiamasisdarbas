# Baigiamasisdarbas
## Scenarijus 1 - testuojamas Vilniaus Oro uosto puslapis https://www.vilnius-airport.lt/

### 1 atvejis - testuojama ar atidarius aukšiau pateiktą nuorodą atsidaro puslapis su siūloma šiandienos data.
1. Pasinaudojant DateTime funkcija nustatoma šiandienos data "today".
2. "today" data konvertuojama į "yyyy-MM-dd" formatą - tokį koks pateikiamas oro uosto puslapyje.
3. Paimama tikroji data rodoma internetiniame puslapyje "actualDate".
4. Palyginama ar "today" yra tokia pati kaip "actualDate".

### 2 atvejis - testuojama ar atidarius puslapį ir renkantis skrydžių laikotarpį visada rodomas mėnesio laikotarpis paieškai.
1. Pasinaudojant DateTime funkcija nustatoma šiandienos data "today".
2. Naudojantis DateTime funkcija prie šiandienos datos pridedamas vienas mėnuo ir atimama viena diena (nes skrydžių laikotarpyje rodomi ir šiandienos skrydžiai) gaunama "oneMonthFromToday" data.
3. "oneMonthFromToday" data konvertuojama į "yyyy-MM-dd" formatą - tokį koks pateikiamas oro uosto puslapyje.
4. Nuskaitoma tikroji data, kuri rodoma oro uosto puslapyje "actualDateTo".
5. Palyginama ar "oneMonthFromToday" yra ta pati kaip "actualDateTo".

### 3 atvejis - testuojama ar veikia skrydžių paieškos puslapis ieškant pasirinktos krypties.
1. žingsnis - paieškos atsakymas, kurio tikimasi - "expectedValue".
2. Pelės kursoriumi paspaudžiame kairįjį mygtuką ant oro uosto laukelio paieškoje.
3. Pelės kursoriumi paspaudžiame ant atiradusio tuščio teksto įvedimo laukelio kairįjį mygtuką.
4. Suvedame suvedame ieškomo oro uosto kodą.
5. Paspaudžiame kairįjį pelės klavišą ant žemiau suvedimo laukelio atsiradusio sąrašo pirmosios reikšmės.
6. Paspaudžiame pelės kairįjį mygtuką ant puslapio mygtuko "ieškoti skrydžio".
7. Nuskaitydami pateiktų atsakymų sąrašą puslapyje gauname "actualValue".
8. Palyginame ar kiekviename iš gauto sarašo atsakymo elementų gauname "expectedValue" reikšmę.

### 4 atvejis - patikriname ar oro uosto puslapis nukreipia į Hertz automobilių nuomos puslapį.
1. Paspaudžiame kairįjį pelės klavišą ant puslapio mygtuko "Paslaugos oro uoste".
2. Paspaudžiame kairįjį pelės klavišą ant puslapio mygtuko "Automobilių nuoma".
3. Paspaudžiame kairįjį pelės klavišą ant Hertz logotipo.
4. Nuskaitome atidarytą puslapio nuorodą.
5. Palyginame ar "expectedurlValue" sutampa su "actualUrl".

### 5 atvejis - patikriname ar veikia krypčių filtras naudojanits COVID-19 apribojimų filtro funkcija.
1. Pasirinenkame "expectedAnswer" atsakymą, kurio tikimės iš puslapio.
2. Paspaudžiame kairįjį pelės mygtuką ant puslapio apačioje esančio mygtuko "krypčių sąrašas".
3. Paspaudžiame kairįjį pelės klavišą ant išsiskleidžiančio sąrašo skiltyje "Ar grįžus reikia saviizoliuotis?".
4. Paspaudžiame kairįjį pelės klavišą ant pasirodžiusio atsymų sąrašo pasirinkdami "Taip".
5. Paspaudžiame kairįjį pelės klavišą ant puslapio mygtuko "Filtruoti".
6. Nuskaitydami puslapio atsakymo tekstą gauname "actualAnswer".
7. Palyginame ar "expectedAnswer" sutampa su "actualAnswer".
