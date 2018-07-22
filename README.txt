.NET Core 2.0 https://www.microsoft.com/net/download/windows ,https://nodejs.org/en/download/(node js kell hozzá) Angular v5 https://cli.angular.io/ , Entity Framework Core , Bootstrap v3
egyéb használt dolgok: AutoMapper, Cors, JWT

3rd party kompononsek: 
http://alertifyjs.com/
https://github.com/auth0/angular2-jwt
https://valor-software.com/ngx-bootstrap/#/getting-started
https://bootswatch.com/

Két külön porject van egyik az Angularnak, másik a webAPI-nak. Az adatbázis SQLite az API project könyvtárában található. Ez bármikor kicserélhetõ egy másik adatbázisra az appsettings.json-ban. Meg lehet nyitni VS-ban is én VSCode-ban írtam. Sima VS nem nagyon szereti.(Mondjuk meg is lepõdtem volna, ha véletlen gond nélkül elindítja). Nem próbáltam, hogy ott az automatikus indítás a milyen localhost portra teszi õket de konzolból(terminálból) elindítva a :4200, :5000 a két port. A mappákra navigálva és ott konzolt megnyitva az API a "dotnet run" az oldal a "ng serve" paranccsal indítható. Ha valamiért nem sikerül futtatni akkor megpróbálom Azure-on hostolni és ott remélhetõleg jó lesz.


App leírása: Egy randioldal. Lehet regisztrálni, természetesen utána bejelentkezni. A jelszó hashelve van valamint egy tök jó dolgot is mutattak a hash mellé egy véletlen "salt"-ot is tehetünk amely még tovább növeli a biztonságot. Az oldal angol nyelvû kivéve az alertifyjs üzeneteket, mivel azt csak magamnak teszteltem. Routok, be vannak állítva. Az adatbázis véletlen adatokkal van feltöltve van ilyen Json generáló oldal, ha újra fel kell tölteni akkor a "Startup.cs" végén ki kell venni a kommentet és indításnál feltölti az adatbázist.

!!!
Minden így létrehozott user jelszava: "password" felhasználóneve pedig ugye változó de itt vna 2 példa: freda, simon.
!!!

Mi mûködik eddig:
-reisztráció
-login
-adatbázisból kiolvasni a regisztrált embereket (sajnos a csak simán regisztrált felhasználó bár megjelenik de nem ír ki semmi hozzá, mivel nincs implementálva ez edit profile)

Mik a jövõbeli tervek: edit profile, képfeltöltés, részletes megkelenítése a felhasználói adatoknak, üzenetküldés, like, stb.

Mire volt jó a beadandó, az órák:
Olyan 30-40 órát dolgoztam vele, az udemy.com-on van egy hasonló kurzus. Ezt simán le lehetne rövidíteni, ha a microsoft általá biztosított identity framework-öt használjuk, de legalább mosmtár meg tudok írni egy saját authentikációs eljárást. Elég sok szívás volt vele, mert próbáltam magamtól rájönni dolgokra és nem a videókat követni mert annak kb semmi értelme. Rengeteg hasznos dolgot tanultam az órákon fõleg szerettem, hogy volt egy csomó kitekintés más irányba is és nem csak kódolni kellett, mert arra úgy sincs idõ ennyi óraszámban. Ezért döntöttem úgy, hogy magamtól kezdek el ezzel a témával foglalkozni. Eddig nem igazán érdekelt a sulis webes témák oktatása(az Internetes Alkalmazás fejlesztés az modnjuk jó volt mert a Java-t szeretem, de mondjuk a PHP az csak szükséges rossz a szememben). Jó lenne, ha ezt a tárgyat is dupla óraszámban lehetne hallgatni(bár gondolom erre idõ nem igazán van), mert itt olyan dolgokkal foglalkoztunk(pl:angular), amik hasznosak lehetnek és nem csak egy technológia támogatja. (Most a backend rész úgymond adott, de az angular ugyanúgy mûködik feljesen mindegy mi van mögötte, és használják is sok helyen). A beadandó elkészítés rengeteg hasznos dologra világított rá és megmutatta, hogy mennyit kell foglalkzni egy alap szintû funkcionlitás normális megvalósításához.

TLDR.: Élveztem az órai kitenkintéseket, lehetne dupla óraszámban is a tágy, ha van rá idõ.