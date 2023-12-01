

Conta person0 = new Conta(23, "Jose Jesus", 5600);
Conta person1 = new Conta(25, "Pedro Bobbi", 4600);

Console.WriteLine(person0);
Console.WriteLine(person1);
person1.SubtraMoney(300); // seubtrai 300
Console.WriteLine(person1);
person0.AddMoney(300); // Adiciona 300
Console.WriteLine(person0);
person1.Transfer(person0, 300); // transefre 300 para Jose Jesus
Console.WriteLine(person0);
Console.WriteLine(person1);