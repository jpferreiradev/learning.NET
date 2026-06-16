using System.Net.Http.Headers;

Console.WriteLine(" ## Estrutura Date Time ##\n ");

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual); // Data atual, de acordo com o seu SO

// Cria uma Data especifica: aaaa,mm,dd

DateTime dataHoje = new DateTime(2022, 09, 06);
Console.WriteLine(dataHoje);

// definir as horas

DateTime dataHoraHoje = new DateTime(2022, 09, 06,21,10,30);
Console.WriteLine(dataHoraHoje);

Console.WriteLine("--------------------------------------\n");

// extrair informaçoes data atual

Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Millisecond);
Console.WriteLine();

// Adicionando valores

Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddMonths(1));
Console.WriteLine(dataAtual.AddHours(2));
Console.WriteLine(dataAtual.AddYears(5));

// Obter o dia da semana e do ano
Console.WriteLine();
Console.WriteLine("Dia da semana: " + dataAtual.DayOfWeek);
Console.WriteLine("Dia do ano: 365/" + dataAtual.DayOfYear + " dias");

// Data no formato longo e curto

Console.WriteLine("Data longa: " + dataAtual.ToLongDateString());
Console.WriteLine("Data resumida: " + dataAtual.ToShortDateString());

Console.WriteLine("Hora longa: " + dataAtual.ToLongTimeString());
Console.WriteLine("Hora resumida: " + dataAtual.ToShortTimeString());

    

