
string gissning;


Console.WriteLine("Gissa talet, det ligger på skalan 1-10");
for(int pepefrog = 1; pepefrog <= 5; ++pepefrog)
{
    int tal;
    gissning = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(gissning)){
        Console.WriteLine("Skriv något snälla");
        continue;
    }
    int.TryParse(gissning, out tal);
    if(tal > 5){
        Console.WriteLine("Din gissning var större än talet");
                continue;
    }else if(tal < 5){
        Console.WriteLine("Din gissning var mindre än talet");
                continue;
    }
    else{
        Console.WriteLine("Bra jobbat, du gissade rätt");
        Thread.Sleep(3000);
        Environment.Exit(0);
    }
}