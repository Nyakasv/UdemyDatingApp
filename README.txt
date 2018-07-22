.NET Core 2.0 https://www.microsoft.com/net/download/windows ,https://nodejs.org/en/download/(node js kell hozz�) Angular v5 https://cli.angular.io/ , Entity Framework Core , Bootstrap v3
egy�b haszn�lt dolgok: AutoMapper, Cors, JWT

3rd party kompononsek: 
http://alertifyjs.com/
https://github.com/auth0/angular2-jwt
https://valor-software.com/ngx-bootstrap/#/getting-started
https://bootswatch.com/

K�t k�l�n porject van egyik az Angularnak, m�sik a webAPI-nak. Az adatb�zis SQLite az API project k�nyvt�r�ban tal�lhat�. Ez b�rmikor kicser�lhet� egy m�sik adatb�zisra az appsettings.json-ban. Meg lehet nyitni VS-ban is �n VSCode-ban �rtam. Sima VS nem nagyon szereti.(Mondjuk meg is lep�dtem volna, ha v�letlen gond n�lk�l elind�tja). Nem pr�b�ltam, hogy ott az automatikus ind�t�s a milyen localhost portra teszi �ket de konzolb�l(termin�lb�l) elind�tva a :4200, :5000 a k�t port. A mapp�kra navig�lva �s ott konzolt megnyitva az API a "dotnet run" az oldal a "ng serve" paranccsal ind�that�. Ha valami�rt nem siker�l futtatni akkor megpr�b�lom Azure-on hostolni �s ott rem�lhet�leg j� lesz.


App le�r�sa: Egy randioldal. Lehet regisztr�lni, term�szetesen ut�na bejelentkezni. A jelsz� hashelve van valamint egy t�k j� dolgot is mutattak a hash mell� egy v�letlen "salt"-ot is tehet�nk amely m�g tov�bb n�veli a biztons�got. Az oldal angol nyelv� kiv�ve az alertifyjs �zeneteket, mivel azt csak magamnak teszteltem. Routok, be vannak �ll�tva. Az adatb�zis v�letlen adatokkal van felt�ltve van ilyen Json gener�l� oldal, ha �jra fel kell t�lteni akkor a "Startup.cs" v�g�n ki kell venni a kommentet �s ind�t�sn�l felt�lti az adatb�zist.

!!!
Minden �gy l�trehozott user jelszava: "password" felhaszn�l�neve pedig ugye v�ltoz� de itt vna 2 p�lda: freda, simon.
!!!

Mi m�k�dik eddig:
-reisztr�ci�
-login
-adatb�zisb�l kiolvasni a regisztr�lt embereket (sajnos a csak sim�n regisztr�lt felhaszn�l� b�r megjelenik de nem �r ki semmi hozz�, mivel nincs implement�lva ez edit profile)

Mik a j�v�beli tervek: edit profile, k�pfelt�lt�s, r�szletes megkelen�t�se a felhaszn�l�i adatoknak, �zenetk�ld�s, like, stb.

Mire volt j� a beadand�, az �r�k:
Olyan 30-40 �r�t dolgoztam vele, az udemy.com-on van egy hasonl� kurzus. Ezt sim�n le lehetne r�vid�teni, ha a microsoft �ltal� biztos�tott identity framework-�t haszn�ljuk, de legal�bb mosmt�r meg tudok �rni egy saj�t authentik�ci�s elj�r�st. El�g sok sz�v�s volt vele, mert pr�b�ltam magamt�l r�j�nni dolgokra �s nem a vide�kat k�vetni mert annak kb semmi �rtelme. Rengeteg hasznos dolgot tanultam az �r�kon f�leg szerettem, hogy volt egy csom� kitekint�s m�s ir�nyba is �s nem csak k�dolni kellett, mert arra �gy sincs id� ennyi �rasz�mban. Ez�rt d�nt�ttem �gy, hogy magamt�l kezdek el ezzel a t�m�val foglalkozni. Eddig nem igaz�n �rdekelt a sulis webes t�m�k oktat�sa(az Internetes Alkalmaz�s fejleszt�s az modnjuk j� volt mert a Java-t szeretem, de mondjuk a PHP az csak sz�ks�ges rossz a szememben). J� lenne, ha ezt a t�rgyat is dupla �rasz�mban lehetne hallgatni(b�r gondolom erre id� nem igaz�n van), mert itt olyan dolgokkal foglalkoztunk(pl:angular), amik hasznosak lehetnek �s nem csak egy technol�gia t�mogatja. (Most a backend r�sz �gymond adott, de az angular ugyan�gy m�k�dik feljesen mindegy mi van m�g�tte, �s haszn�lj�k is sok helyen). A beadand� elk�sz�t�s rengeteg hasznos dologra vil�g�tott r� �s megmutatta, hogy mennyit kell foglalkzni egy alap szint� funkcionlit�s norm�lis megval�s�t�s�hoz.

TLDR.: �lveztem az �rai kitenkint�seket, lehetne dupla �rasz�mban is a t�gy, ha van r� id�.