// uppgift 1: klasserna employee och program bör finnas med när man lagrar flera anställda. Just nu är enbart program med. 
//uppgift 2: name, salary och wage är attributerna. Eventuella metoder Parse, ToUpper, Substring, WriteLine och ReadLine, men inga egna, som eventuellt AddEmployee som skulle vara bra att skapa.   

Console.WriteLine("Ange förnamn på anställd:");
string fName = Console.ReadLine();
fName = char.ToUpper(fName[0]) + fName.Substring(1);

Console.WriteLine("Ange efternamn på anställd:");
string lName = Console.ReadLine();
lName = char.ToUpper(lName[0]) + lName.Substring(1);

Console.WriteLine("Ange lön för anställd:");
string salary = Console.ReadLine();
double wage = double.Parse(salary);

Console.WriteLine("Anställd heter " + fName + (" ") + lName + " och tjänar " + wage + " i månaden");