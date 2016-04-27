using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProcessCardDataManagerLibrary;

namespace ProcessCardDataManagerIntegrationTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading DataContext");
            var context = new ProcessDocumentDataContainer();
            Console.WriteLine("Context Successfully Loaded.");

            var presentation = new ProcessDocumentPresenter();
            foreach (var document in presentation.DocumentTitles)
            {
                Console.WriteLine(document);
            }
            foreach (var document in presentation.TemplateTypes)
            {
                Console.WriteLine(document);
            }

            try
            {
                presentation.Documents.CreateNewDocument("Cows", "Test");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //foreach (var item in collection)
            //{
                
            //}
           
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();

        }
    }
}
