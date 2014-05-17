namespace FootballBookmaker.Data.Migrations
{
    using FootballBookmaker.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<FootballBookmaker.Data.DataContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DataContext context)
        {
            if (context.Teams.Any())
            {
                return;
            }

            var teamNames = new List<string> {
                "Avangard", "Avren", "Agroelit", "Adasport", "Aydemir", "Agromel", "Akademik (Varna)", "Akademik (Veselets)", "Akademik (Svishtov)", "Akademik (Sofia)", "Aksakovo", "Akfix", "Albena 97", "Aleko 2006", "Aleks OK", "Almus Beer", "Altay", "Altay sport", "Angel Kanchev", "Anhialo", "Apolon", "Apriltsi 2001", "Arda (Kardzhali)", "Ariva", "Ariston", "Arsenal (Kazanlak)", "Arsenal (Lavino)", "Asenovets 2005", "Atletik (Blagoevgrad)", "Atletik (Makak)", "Atletik (Kuklen)", "Atletik (Mokrishte)", "Atletik (Svishtov)", "Atletik (Trastenik)", "Atletik 09 (Usoyka)", "Augusta", "Aheloy", "Ayaks", "Baykal", "Bakadzhik (Voynika)", "Bakadzhik (Chargan)", "Balik", "Balkan (Asparuhovo)", "Balkan (Banishte)", "Balkan (Belogradchik)", "Balkan (Botevgrad)", "Balkan (Varvara)", "Balkan (Goritsa)", "Balkan (Gorna Breznitsa)", "Balkan (Oreshak)", "Balkan (Planinitsa)", "Balkan (Prilep)", "Balkan (Razboyna)", "Balkan (Selimnovo)", "Balkan (Tvarditsa)", "Balkan (Tserovo)", "Balkan 04 (Inovo)", "Balkan 2009 (Dobra polyana)", "Balkanski", "Bankya", "Banya", "Bansko", "Barikadi", "Barsa (Sushevo)", "Barselona (Borovo)", "Barselona (Prosenik)", "Batak", "Batishnitsa", "Bdin 1923", "Bezmer", "Belasitsa (Petrich)", "Belasitsa 08 (Belasitsa)", "Belite galabi", "Belite orli", "Belitsa", "Beloslav", "Benkovski (Balgarsko Slivovo)", "Benkovski (Byala - Ruse)", "Benkovski (Gabrovnitsa)", "Benkovski (Zimnitsa)", "Benkovski (Kopanitsa)", "Benkovski (Kostenets)", "Benkovski (Kurtovo Konare)", "Benkovski (Leskovets)", "Benkovski (Nikolaevo)", "Benkovski (Opanets)", "Benkovski (Pazardzhik)", "Benkovski (Pishtigovo)", "Benkovski (Podgoritsa)", "Benkovski (Salmanovo)", "Benkovski (Simeonovgrad)", "Benkovski (Teteven)", "Benkovski 2006 (Tsrancha)", "Benkovski 2007 (Kriva bara)", "Benkovski 53 (Saparevo)", "Beroe", "Bioelit", "Birlik", "Bistritsa (Katuntsi)", "Bistritsa 2008 (Albanitsa)", "Bozveliysko", "Boila", "Boychinov", "Boychinovtsi", "Borba 10", "Borislav", "Bobov dol", "Borovets 2002", "Borovo 2000", "Botev (Boboshevo)", "Botev (Bolyarovo)", "Botev (Brestak)", "Botev (Bardaski gegan)", "Botev (Vratsa)", "Botev (Valchi tran)", "Botev (General Inzovo)", "Botev (Golyamo Vranovo)", "Botev (Gramada)", "Botev (Galabovo)", "Botev (Debelets)", "Botev (Dolna Mitropoliya)", "Botev (Debar)", "Botev (Komarevo)", "Botev (Koprivets)", "Botev (Kraynitsi)", "Botev (Krivodol)", "Botev (Levski)", "Botev (Letnitsa)", "Botev (Momina klisura)", "Botev (Lukovit)", "Botev (Novi pazar)", "Botev (Plovdiv)", "Botev (Popitsa)", "Botev (Rogozen)", "Botev (Rogosh)", "Botev (Ruptsi)", "Botev (Tranchovitsa)", "Botev (Chernogorovo)", "Botev 1 (Batanovtsi)", "Botev 1921 (Zlataritsa)", "Botev 1921 (Ihtiman)", "Botev 1930 (Kobilyak)", "Botev 1949 (Kermen)", "Botev 2008 (Kozloduy)", "Botev 2009 (Dzherman)", "Botev 2012 (Pudriya)", "Botev D (Dimovo)", "Botev (Drugan)", "Boyadzhik 2004", "Boyanovo 2012", "Bradvari 08", "Bratanitsa", "Bratsigovo", "Brestnik 1948", "Brestovitsa", "Buzludzha (Enina)", "Buzludzha (Kyustendil)", "Buzovo kale", "Buyna Mesta", "Bukovo", "Bulldog", "Burgos", "Burya (Gradsko)", "Burya (Kosharevo)", "Badeshte 2010", "Byala reka (Topolnitsa)", "Byala reka 1 (Zaychar)", "Varna", "VVS", "Vedrare", "Vekta", "Velbazhd", "Veliki Preslav", "Velichkovo", "Venets", "Ventsi", "Vereya", "Verila", "Veselina", "Vetovo 2007", "Vetren (Vetren)", "Vetren (Polena)", "Vetrino", "Vidima (Dushevo)", "Vidima-Rakovski (Sevlievo)", "Vinaya", "Vit", "Vitanovtsi", "Vitosha (Bistritsa)", "Vitosha (Dolna Dikanya)", "Vitski orli", "Vihren 1925", "Vihar (Aldomirovtsi)", "Vihar (Bahovitsa)", "Vihar (Belozem)", "Vihar (Boil)", "Vihar (Borima)", "Vihar (Barziya)", "Vihar (Vetren)", "Vihar (Vladimirovtsi)", "Vihar (Voyvodinovo)", "Vihar (Voysil)", "Vihar (Gulyantsi)", "Vihar (Dobri dyal)", "Vihar (Zheglartsi)", "Vihar (Zavet)", "Vihar (Kavrakirovo)", "Vihar (Gorublyane)", "Vihar (Trebich)", "Vihar (Loznitsa)", "Vihar (Lopyan)", "Vihar (Lyuben)", "Vihar (Marash)", "Vihar (Radanovo)", "Vihar (Ryahovtsite)", "Vihar (Semerdzhievo)", "Vihar (Stroevo)", "Vihar 1926 (Valchi dol)", "Vihar 1965 (Zlatograd)", "Vihar 1969 (Boyan)", "Vihar 2000 (Aytos)", "Vihar 2006 (Graf Ignatievo)", "Vihar 23 (Nikolovo)", "Vihar 97 (Prevala)", "Vihar S (Senokos)", "Vladislav (Varna)", "Vladislav 2004 (Dzholyunitsa)", "Voyvoda", "Voynyagovo", "Vabel", "Varba 1917", "Varbitsa", "Varbitsa 2006 (Benkovski)", "Varbitsa 2008 (Oreshe)", "Varshets 2012", "Vastanik", "Vacha (Yoakim Gruevo)", "Vacha (Kadievo)", "Gaber", "Gabrovnitsa 04", "Gabar", "Gagarin", "Galktika", "Galatasaray", "Gelemenovo", "Gerganin izvor", "Gerena", "Germaneya", "Geroy", "Gigant (Belene)", "Gigant (Saedinenie)", "Glodzhevo", "Golemi vrah", "Goloe ", "Goritsa", "Gorubso", "Gotse Delchev (Gorni Voden)", "Gradishte 1932", "Granit (Vladaya)", "Granit (Godeshevo)", "Granit (Konyavo)", "Granit (Kanchevo)", "Granit (Sborishte)", "Granit (Slatina)", "Granit (Shiroki gol)", "Granit 2012 (Skobelevo)", "Granichar (Koprivlen)", "Granichar (Tuhovishta)", "Granichar 2008 (Dospat)", "Galabets", "Davidovo", "Dan Kolov", "Debren", "Devin", "Devnya", "Dzhebel", "Diana 1924", "Divotino", "Dimitrovgrad II", "Dimitrovets 1", "Dimitrovgrad 1947", "Dimcha", "Dinamo (Izgrev)", "Dinamo 2011 (Stambolovo)", "Dobrinishte", "Dobromirka", "Dobrudzha (Iskra)", "Dobrudzha (Sitovo)", "Dobrudzha 1919 (Dobrich)", "Dobrudzhanets (Ovcharovo)", "Dobrudzhanets 2005 (Alfatar)", "Dobrudzhanski sportist ", "Dolen", "Dolna Oryahovitsa", "Dorostol 2003", "Dragalevtsi", "Dragoman", "Dren 2011", "Drenovets", "Druzhba (Dobrovnitsa)", "Druzhba (Lyulyakovo)", "Druzhba (Meshtitsa)", "Dulovo 2006", "Dunav (Vardim)", "Dunav (Gigen)", "Dunav (Dunavtsi)", "Dunav (Slivo pole)", "Dunav 09 (Leskovets)", "Dunav 2010 (Ruse)", "Dunav 98 (Selanovtsi)", "Dunarit", "Dabene", "Dabrava", "Dyankovo", "Evrokolezh", "Edinstvo (Gurkovo)", "Edinstvo (Dolni Dabnik)", "Edinstvo (Kitanchevo)", "Edinstvo (Targovishte)", "Edinstvo 2005 (Dabnitsa)", "Ezerche", "Eleshnitsa", "Elit", "Eltemir", "Elhovo", "Endzhe", "Enev", "Energitik", "Era", "Erma", "Etar", "Zheleznitsa", "Zhilentsi", "Zhitnitsa", "ZSK Ihtiman", "Zavod 12", "Zagorets", "Zapadno eho", "Zarya (Krushare)", "Zarya (Todor Ikonomovo)", "Zarya 2006 (Krushari)", "Zarya 2006 (Tsar Samuil)", "Zarya Zvegor 1963", "Zvezda", "Zvezdets", "Zdravets (Gruevo)", "Zdravets (Zdravets)", "Zemedelets-Elit", "Zenit  (Vetren dol)", "Zenit (Pamukchii)", "Zenit 2012 (Pravoslaven)", "ZKMO", "Zlaten klas", "Iva", "Ignatievo", "Izvor AM", "Izgrev (Meden kladenets)", "Izgrev (Yablanitsa)", "Izgrev 93 (Tsarevets)", "Izgtrebitel", "Ilinden (Klyuch)", "Ilinden 2005", "Imrenchevo", "Iskra (General Kiselovo)", "Iskra (Golyamo gradishte)", "Iskra (Iskrets)", "Iskra (Chernoochene)", "Iskra 2009 (Iskrets)", "Iskra 41 (Benkovski)", "Iskar (Dolni Lukovit)", "Iskar (Orehovitsa)", "Iskar 1923 (Roman)", "Iskar 2005 (Lakatnik RS)", "Yaldaram", "Kabile", "Kabiyuk", "Kableshkovo 07", "Kazichene", "Kale (Krepcha)", "Kalabak", "Kale (Ruyno)", "Kale 09 (Nova mahala)", "Kaliakra", "Kaloyanovo", "Kalchevo", "Kamenar", "Kameno", "Kamchiets", "Kamchiyski sokol", "Kanina", "Karadzhalovo 2011", "Karnobat", "Keramik", "Kilifarevo", "Kiprovets", "Kitka", "Klikach", "Koba", "Kom (Berkovitsa)", "Kom (Godech)", "Kom-Minyor (Berkovitsa)", "Komatevo 2001", "Komuna 2011", "Koneliano /Conegliano/", "Kopie", "Koprivlen", "Kornitsa", "Korten 2012", "Kosmos (Boyantsi)", "Kosmos (Branichevo)", "Kosmos (Grivitsa)", "Kosmos (Kamenets)", "Kostievo", "Kostinbrod", "Kotel", "Kochan", "Kochovo", "Kraishte", "Kremikovtsi", "Krichim", "Kubrat 2007", "Kula 04", "Kyustendil", "Lavrov", "Lazur", "Lato", "Levski (Brest)", "Levski (Gorna Mitropoliya)", "Levski (Egalnitsa)", "Levski (Karamanovo)", "Levski (Karlovo)", "Levski (Dragalevtsi)", "Levski (Komoshtitsa)", "Levski (Kocherinovo)", "Levski (Lyaskovets)", "Levski (Mladovo)", "Levski (Novgrad)", "Levski (Odarne)", "Levski (Omyrtag)", "Levski (Patalenitsa)", "Levski (Pisarovo)", "Levski (Podayva)", "Levski (Sofia)", "Levski (Suhache)", "Levski (Chepintsi - Smolyan)", "Levski (Chepintsi - Sofia)", "Levski 1923 (Elin Pelin)", "Levski 1986 (Strazhitsa)", "Levski 2005 (Krumovgrad)", "Levski 2007 (Dolna banya)", "Levski 2007 (Krupnik)", "Levski 2007 (Levski)", "Levski 2012 (Lom)", "Levski 96 (Glavinitsa)", "Levski Vida Olimeks", "Lencho", "Lesichovo", "Lider", "Lipa", "Lipen", "Lisets", "Litex", "Lovsko", "Lozen", "Lozen 2006 (Suhindol)", "Lokomotiv (Vakarel)", "Lokomotiv (General Todorov)", "Lokomotiv (Gorna Oryahovitsa)", "Lokomotiv (Damyanitsa)", "Lokomotiv (Dryanovo)", "Lokomotiv (Mezdra)", "Lokomotiv (Ruse)", "Lokomotiv (Samuil)", "Lokomotiv (Septemvri)", "Lokomotiv (Sofia)", "Lokomotiv (Stara Zagora)", "Lokomotiv (Han Krum)", "Lokomotiv (Chernograd)", "Lokomotiv 101 (Sofia)", "Lokomotiv 1926 (Plovdiv)", "Lokomotiv 2008 (Kaspichan)", "Lokomotiv 2012 (Mezdra)", "Ludogorets (Dobroplodno)", "Ludogorets (Kaolinovo)", "Ludogorets 1945 (Razgrad)", "Ludogorets 2011 (Paisievo)", "Laki 2004", "Lyubimets (Tarnava)", "Lyubimets 2007", "Lyublyana", "Lyulin", "Lyulyak", "Lyuta", "Lyaksi", "Madan", "Madara 2010", "Malexh 1040", "Manastirishte 2000", "Manish (Tsarkva)", "Manklich", "Marek 2010", "Marisan", "Maritsa (Belovo)", "Maritsa (Krum)", "Maritsa (Menenkyovo)", "Maritsa (Milevo)", "Maritsa (Ognyanovo)", "Maritsa (Plovdiv)", "Maritsa (Tsalapitsa)", "Maritsa (Yasno pole)", "Maritsa 1951 (Lyubenovo)", "Maritsa 2003 (Manole)", "Maritsa 2006 (Gradina)", "Mariya Luiza", "Master", "Mezhda", "Mesembriya", "Mesta 2005 ", "Metalik 1938", "Metalurg (Pernik)", "MIG 2010", "Miziya", "Mizia 2005", "Malinovo 2007", "Milkovitsa 09", "Mineral (Ovoshtnik)", "Mineral (Ognyanovo)", "Mineral (Rudartsi)", "Mini Maritsa - iztok", "Minyor (Bobov dol)", "Minyor (Eleshnitsa)", "Minyor (Elshitsa)", "Minyor (Pernik)", "Minyor (Radnevo)", "Minyor (Rudnik)", "Minyor (Senovo)", "Minyor 1934 (Rudinik)", "Mirkovo", "Mlada gvardiya", "Mladost (Ekzarh Yosif)", "Mladost (Zlatovrah)", "Mokrash 2005", "Momino", "Monolit", "Montana 1921", "Morena", "Mortagonovo", "Most ", "Musala", "Malniya", "Mativir", "Nadezhda 1926", "Nevrokop", "Nedan", "Nesebar (Nesebar)", "Nesebar (Sunny Beach)", "Neftohimic 1962", "Neftyanik 2010", "Nikola Kozlevo 2004", "Nova Cherna", "Novi Iskar", "Novosel", "Obedinenie", "Obelya", "Obzor", "Obnova", "Oborishte", "Ogosta", "Ograzhdenets", "Okolchitsa", "Old House", "Olimpik (Burgas)", "Olimpik 2000 (Teteven)", "Orel (Gluhar)", "Orel (Lebnitsa)", "Orel (Razdeltsi)", "Orel 19 (Oryahovo)", "Orelyak", "Orizare", "Orlite (Nadarevo)", "Orlite (Stefan Karadzha)", "Orlovets 2008 (Pobeda)", "Orlovets 94 (Gabrovo)", "Osmar", "Osogovo", "Osam", "Pirin (Blagoevgrad)", "Pavlikeni", "Pazardzhik 2012", "Palamara", "Palankite", "Panayot Hitov", "Partizan (Cherven bryag)", "Partizan (Yardzhilovtsi)", "Partizani (Gradina)", "Partizani (Makresh)", "Pautaliya", "Pelezo", "Perperikon", "Perun", "Pirin (Breznitsa)", "Pirin (Gotse Delchev)", "Pirin (Zemen)", "Pirin (Razlog)", "Planinets ", "Plastik", "Pletena", "Pobeda (Vresovo)", "Pobeda (Gradnitsa)", "Pobeda (Kesarevo)", "Pobeda (Kolobar)", "Pobeda (Palamartsa)", "Pobeda (Pobeda)", "Pobeda (Pristoe)", "Pobeda (Tsaratsovo)", "Pobeda  2009 (Vokil)", "Podgorets", "Pomorie", "Popovitsa", "Pordim", "Porominovo", "Pravda 1944", "Pravets", "Pretsiz Inter", "Prista 2000 (Sredna kula)", "Provadiya", "Prosenik", "Parvomay", "Parvomaytsi", "Pastrina 2012", "Ravda 1954", "Ravnets 2011", "Radinovo 2006", "Raketa (Preselets)", "Raketa 1111 (Bukovlak)", "Rakovski (Ivaylovgrad)", "Rakovski (Ruse)", "Rakovski 2005 (Kalipetrovo)", "Rakovski 2011 (Rakovski)", "Rapid (Dividyanovo)", "Rasovo", "Rafo spor", "Ratsiara", "Relax", "Republikanets (Enevo)", "Republikanets (Lisets)", "Resen 2012", "Rila", "Rilets (Govedartsi)", "Rilets 1948 (Resilovo)", "Rilski orli", "Rilski sportist", "Riltsi (Riltsi)", "Riltsi 2006 (Riltsi)", "Rodopa (Ribnovo)", "Rodopa (Smolyan)", "Rodopi (Debrashtitsa)", "Rodopi (Satovcha)", "Rodopi 1921 (Kozarsko)", "Rodopi 1935 (Momchilgrad)", "Rodopski sokol", "Rozova dolina", "Roma", "Ropotamo", "Rositsa (Polikraishte)", "Rositsa (Stokite)", "Rudanovski", "Rudnichar (Bela voda)", "Ruen (Bogoslov)", "Ruen 2008 (Ruen)", "Rusokastro", "Sadovo (Sadovo - Plovdiv)", "Sadovo (Sadovo - Blagoevgrad)", "Sakarski sportist", "Samovodene", "Samuil", "Santos", "Sarata", "Saraya", "Sveti Vlas", "Sveti Vlas 08", "Sveti Nikola", "Svetkavitsa (Banite)", "Svetkavitsa (Kralevo)", "Svetkavitsa (Manolsko Konare)", "Svetkavitsa (Medovene)", "Svetkavitsa (Mitino)", "Svetkavitsa (Mihaltsi)", "Svetkavitsa (Sinitovo)", "Svetkavitsa 2004 (Gyulyovitsa)", "Svetkavitsa (Targovishte)", "Svetlina", "Svetlya 2000", "Svetoslav", "Svoboda (Milkovitsa)", "Svoboda 2011 (Peshtera)", "Svrakite", "Seydol", "Sekirovo ", "Seliyak", "Seltik", "Septemvri (Glozhene)", "Septemvri (Gradets)", "Septemvri (Kravoder)", "Septemvri (Medkovets)", "Septemvri (Simitli)", "Septemvri (Sofia)", "Septemvri 2005 (Zhabokrat)", "Septemvri 2009 (Lehchevo)", "Septemvri 98 (Tervel)", "Silistra 2009", "Sini vir", "Sinite izvori", "Sinya voda", "Sion", "Sitalk", "Sitomir", "Skala (Bov railway station)", "Skala (Zverino)", "Skala (Kamen)", "Skalite ", "Skrita sila", "Slava", "Slavi mes (Goznitsa)", "Slavilov", "Slaviya (Asenovtsi)", "Slaviya (Granitsa)", "Slaviya (Novachene)", "Slaviya (Novo selo)", "Slaviya (Hadzhievo)", "Slaviya 1913 (Sofia)", "Slaviya 2000 (Yahinovo)", "Slashten 2007", "Sliven 2000", "Slivnishki geroy", "Smirnenski", "Smolyan 2000", "Smolyanovtsi", "Smyadovo 2010", "Sozopol", "Sokol (Karavelevo)", "Sokol (Dolni Voden)", "Sokol (Krislovo)", "Sokol (Markovo)", "Sokol (Negovan)", "Sokol (Poroy)", "Sokol (Padarsko)", "Sokol (Samoranovo)", "Sokol (Treskavets)", "Sokol (Chervena voda)", "Sokol 2008 (Zarnevo)", "Sokol 2008 (Yabalchevo)", "Sokol 2009 (Elenino)", "Sokol 2012 (Sokolovo)", "Soley 97 (Kalkas)", "Sparta (Burgas)", "Spartak (Boshulya)", "Spartak (Bazan)", "Spartak (Byala)", "Spartak (Kalugerovo)", "Spartak (Koynare)", "Spartak (Novo selo)", "Spartak (Peshtera)", "Spartak (Podgumer)", "Spartak (Samokov)", "Spartak (Sklave)", "Spartak (Sliven)", "Spartak (Sofia)", "Spartak (Trivoditsi)", "Spartak (Tarnava)", "Spartak 1918 (Varna)", "Spartak 2001 (Pirdop)", "Spartak 2004 (Dolno Dryanovo)", "Spartak 2008 (Izbeglii)", "Spartak Pleven", "Spartak-S94 (Plovdiv)", "Spoting ", "Sportist (Baniska)", "Sportist (Bata)", "Sportist (Beli izvor)", "Sportist (Blagovo)", "Sportist (Golyam chardak)", "Sportist (Dobrich)", "Sportist (Dragievo)", "Sportist (Kaynkardzha)", "Sportist (Knizhovnik)", "Sportist (Koozarevets)", "Sportist (Mihalich)", "Sportist (Petko Slaveykov)", "Sportist (Preslavtsi)", "Sportist (Roza)", "Sportist (Slokoshtitsa)", "Sportist (Stefanovo)", "Sportist (Struma-Lebnitsa)", "Sportist (Yabalkovo)", "Sportist 2006 (Dragovishtitsa)", "Sportist 2010 (Kapitan Dimitrievo)", "Sportist 2011 (General Toshevo)", "Sportist 2012 (Svoge)", "Sportist Ozren (Golyam izvor)", "Sprint", "Srednogorets ", "Stambolovo", "Stan", "Standart", "Stara Zagora", "Stara sila", "Starchevo 2010", "Stefan Karadzha", "Stefanovo", "Stobi", "Stolipinovo", "Storgoziya", "Strazhitsa 2012", "Straldzha", "Strandzha (Malko Tarnovo)", "Strandzha 2010 (Sredets)", "Strandzhanets ", "Strela (Dobroslavtsi)", "Strela (Dabnik)", "Strela (Obedinenie)", "Strela (Oresh)", "Strela (Todorovo)", "Strela (Shumata)", "Strela 2003 (Valkosel)", "Strela 2004 (Orlyak)", "Stroitel (Kunino)", "Stroitel (Sofia)", "Struma (Kralev dol)", "Struma (Marikostinovo)", "Struma (Novi chiflik)", "Struma 2005 (Strumyani)", "Strumska slava 1927 (Radomir)", "Strumska slava 1956 (Tarnovlag)", "Strumski sokol (Kalishte)", "Stryama 2001", "Studena", "Suvorovo 1", "Sungularska dolina", "Saedinenie", "Timok", "Titan", "Ticha (Varna)", "Ticha 1948 (Dolni chiflik)", "Toplika 1977", "Topoli 2010 ", "Topolite 2005", "Topolovo", "Topchiysko", "Tornado", "Torpedo (Kosovo)", "Torpedo (Pleven)", "Torpedo 2004 (Borovan)", "Trakiets (Govedare)", "Trakiets (Isperihovo)", "Trakiets (Katunitsa)", "Trakiets (Kukorevo)", "Trakiets 2001 (Kalekovets)", "Trakiets 2005 (Glavinitsa)", "Trakite", "Trakiya (Pazardzhik)", "Trakiya (Tsarimir)", "Trakiya 06 (Stamboliyski)", "Trakiya 1948 (Lozen)", "Trakiya 2008 (Novi izvor)", "Trakiya 2012 (Byala reka)", "Trapishte", "Trud", "Trastenik 2009", "Trastikovo", "Tryavna", "Tuzlushka slava", "Tundzha (Veselinovo)", "Tundzha 1915(Yambol)", "Tundzha 2006 (Tenevo)", "Tundzha 2006 (Yagoda)", "Tundzha 2007 (Zhelyo voyvoda)", "Tundzha 2009 (Mechkarevo)", "Tundzha 2010 (Koprinka)", "Tundzha sport ", "Udar (Byala cherkva)", "Udar 99 (Petko Karavelovo)", "Udarnik ", "Uragan (Boyadzhik)", "Uragan (Bazovets)", "Uragan (Vladimir)", "Uragan (Getsovo)", "Uragan (Manastirtsi)", "Uragan (Patresh)", "Uragan (Mihnevo)", "Uragan 1970 (Gorno Draglishte)", "Urvich (Pancharevo)", "Urvich 1960 (Dolni Pasarel)", "Urozhay (Balgarovo)", "Urozhay (Garchinovo)", "Uruma", "Ustrem (Belodol)", "Ustrem (Dropla)", "Ustrem (Karamanite)", "Ustrem (Kreta)", "Ustrem (Maslarevo)", "Ustrem (Pet mogili)", "Ustrem (Trem)", "Ustrem (Rakovski)", "Ustrem D (Donchevo)", "Ustrem (Tankovo)", "Feniksi", "Hadzhi Dimitar", "Haydut", "Han Kardam", "Hanovete", "Haskovo 2009", "Hebros 1921", "Hebar", "Helga", "Himik", "Hristo Botev (Stozher)", "Hristo Botev (Cheshnegirovo)", "Tserovo 2006", "CeSeKa", "CSKA", "Chavdar (Brashlyanitsa)", "Chavdar (Byala Slatina)", "Chavdar (Etropole)", "Chavdar (Divdyadovo)", "Chavdar (Kovachite)", "Chavdar (Sadovets)", "Chavdar (Troyan)", "Chayka Konush 2000", "Chargan", "Chardafon 1919", "Chelnik", "Chelsi", "Chepinets", "Chepintsi", "Chervena zvezda (Glava)", "Chervena zvezda (Kamenets)", "Cherveno zname", "Cherno more (Varna)", "Chernno more (Topola)", "Cherno more (Cherno more)", "Chernogorets 1946", "Chernozem", "Chernolik", "Chernolomets (Gorsko Albanovo)", "Chernolomets (Ostritsa)", "Chernolomets 04 (Popovo)", "Chernomorets (Balchik)", "Chernomorets (Burgas)", "Chernomorets (Nesebar)", "Chernomorets (Pomorie)", "Chernomorets (Chernevo)", "Chernomorets 2003 (Byala - Varna)", "Chernomorski sportist ", "Chiko", "Chirakman", "Chirpan", "Chorni 1920", "Chudomi", "Chumerna", "Shabla", "Sherba", "Shipka (Dragor)", "Shipka 1955 (Malo Konare)", "Shipchenski sokol", "Shumen 1929", "Shumen 2010", "Shurdanitsa", "Yuventus", "Yudelnik", "Yunak (Kormyansko)", "Yunak (Merdanya)", "Yunak (Yunatsite)", "Yunak 2000 (Ardino)", "Yustina", "Yakov", "Yakoruda 2007", "Yambol 2004", "Yankovo", "Yantra (Dolna Studena)", "Yantra (Draganovo)", "Yantra (Polsi Trambesh)", "Yantra (Tsonevo)", "Yantra (Gabrovo)", "Yantra 1919 (Gabrovo)", "Yasen (Yasenovets)", "Yasen 2007 (Yasenkovo)", "Yastreb (Kosharitsa)", "Yastreb (Stratsin)"
            };

            foreach (var teamName in teamNames)
            {
                context.Teams.Add(new Team
                    {
                        Name = teamName,
                    });
            }

            context.SaveChanges();

            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                var homeTeamIndex = random.Next(0, teamNames.Count);
                int awayTeamIndex;
                do
                {
                    awayTeamIndex = random.Next(0, teamNames.Count);
                }
                while(awayTeamIndex == homeTeamIndex);

                var homeTeamName = teamNames[homeTeamIndex];
                var awayTeamName = teamNames[awayTeamIndex];
                var homeTeam = context.Teams.FirstOrDefault(x => x.Name == homeTeamName);
                var awayTeam = context.Teams.FirstOrDefault(x => x.Name == awayTeamName);

                context.Games.Add(new Game
                    {
                        HomeTeam = homeTeam,
                        AwayTeam = awayTeam,
                    });
            }

            context.SaveChanges();
        }
    }
}