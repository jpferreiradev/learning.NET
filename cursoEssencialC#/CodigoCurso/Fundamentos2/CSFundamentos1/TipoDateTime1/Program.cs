Console.WriteLine("Struct DateTime");
Console.WriteLine("Datas no C# ");

// Pegando a data atual
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);


// extrair informaçõs da data atual
Console.WriteLine($"hoje : {dataAtual}\n ");

Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Millisecond);



// Adicionando valores

Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddMonths(30));
Console.WriteLine(dataAtual.AddHours(2));
Console.WriteLine(dataAtual.AddYears(5));

// Obter o dia da semana e do ano

Console.WriteLine("Dia da semana: " + dataAtual.DayOfWeek);
Console.WriteLine("Dia do ano: " + dataAtual.DayOfYear);

// Data no formato longo e curto 

Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToShortTimeString());

Console.WriteLine(dataAtual.ToLongTimeString());
Console.WriteLine(dataAtual.ToShortTimeString());

Console.ReadKey();

/*
 
 
// Data Especifica no formato: aaaa/mm/dd

DateTime dataHoje = new DateTime(2022, 09, 06); // Não foi informado a hora
Console.WriteLine(dataHoje);

// Definir as horas

DateTime dataHoraHoje = new DateTime(2022, 09, 06, 21, 10, 30);

Console.WriteLine(dataHoraHoje);
 */ 