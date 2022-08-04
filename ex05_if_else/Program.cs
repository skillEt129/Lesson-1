Console.WriteLine("Введите имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "роман") // ToLower - позволяет ысе символы строки перевести в нижний регистр.
{
    Console.WriteLine("Ура, это же Роман!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}