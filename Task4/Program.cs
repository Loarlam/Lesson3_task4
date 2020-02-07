/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создайте класс DocumentWorker. 
В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().   
В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт", "Редактирование документа доступно в версии Про", "Сохранение документа доступно в версии Про".   
Создайте производный класс ProDocumentWorker.  
Переопределите соответствующие методы, при переопределении методов выводите следующие строки: "Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт". 
Создайте производный  класс ExpertDocumentWorker от базового класса ProDocumentWorker. Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран "Документ сохранен в новом формате". 
В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса), 
если пользователь ввел номера ключа доступа pro и exp, то должен создаться экземпляр соответствующей версии класса, приведенный к базовому - DocumentWorker.  
*/
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyToCheck;

            Console.WriteLine("Введите ключ:");
            keyToCheck = Console.ReadLine();

            switch (keyToCheck)
            {
                case "&&&":
                    Console.WriteLine("\nАктивирую PRO-версию продукта.");
                    DocumentWorker shareawareProEdition = new ProDocumentWorker();
                    Console.ForegroundColor = ConsoleColor.Green;
                    shareawareProEdition.OpenDocument();
                    shareawareProEdition.EditDocument();
                    shareawareProEdition.SaveDocument();
                    Console.ResetColor();
                    break;
                case "***":
                    Console.WriteLine("\nАктивирую EXP-версию продукта.");
                    DocumentWorker sharewareExpEdition = new ExpertDocumentWorker();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    sharewareExpEdition.OpenDocument();
                    sharewareExpEdition.EditDocument();
                    sharewareExpEdition.SaveDocument();
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("\nНеверный ключ. Активирую FREE-версию продукта.");
                    DocumentWorker freeware = new DocumentWorker();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    freeware.OpenDocument();
                    freeware.EditDocument();
                    freeware.SaveDocument();
                    Console.ResetColor();
                    break;
            }

            Console.ReadKey();
        }
    }
}
