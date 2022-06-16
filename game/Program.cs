// See https://aka.ms/new-console-template for more information
using game;
Console.WriteLine("Hello, World!");

Menu Menu = new Menu();

bool displayMenu = true;

while (displayMenu)
{
    displayMenu = Menu.actualMenu();
}
