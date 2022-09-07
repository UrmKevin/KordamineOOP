using KordamineOOP;

Console.WriteLine("Tere Tulemast!");

Koer koer = new Koer(Koer.toug.Haski, "Sarik", "Punane", koduloom.sugu.isane, 35.5, 7, true);
koer.print_Info();
koer.print_Haal();
Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Nika");
veelkoer.muudaVarv("Pruun");
veelkoer.muudaLoomaSugu(koduloom.sugu.emane);
veelkoer.muudaKaal(15.5);
veelkoer.muudaVanus(5);
veelkoer.muudaElav(true);
veelkoer.muudaToug1(Koer.toug.Jorkširi_terjer);
veelkoer.print_Info();