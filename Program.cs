// uppgift 1: klasserna employee och program bör finnas med när man lagrar flera anställda. Just nu är enbart program med. 
//uppgift 2: name, salary och wage är attributerna. Eventuella metoder Parse, WriteLine och ReadLine, men inga egna, som eventuellt AddEmployee som skulle vara bra att skapa.   

Console.WriteLine("Ange för- och efternamn på anställd:");
string name = Console.ReadLine();

Console.WriteLine("Ange lön för anställd:");
string salary = Console.ReadLine();
double wage = double.Parse(salary);

Console.WriteLine("Anställd heter " + name + " och tjänar " + wage + " i månaden");