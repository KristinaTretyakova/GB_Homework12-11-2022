/* Программа с бесконечным циклом. Как только пользователь введет Exit программа остановится. */ 

Console.WriteLine("Нажмите Enter для запуска программы:)");
        string? Enter = Console.ReadLine();

Method(Enter);

void Method(string? text)   
    {
        Console.WriteLine("Напишите Exit для остановки программы... ");
        string? input = Console.ReadLine();
        if (input == "Exit") return;
        else Method(Enter);
    }   

