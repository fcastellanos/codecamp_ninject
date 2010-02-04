using System;
using CodeCamp.Ninject.Logger;
using Ninject.Core;

namespace CodeCamp.Ninject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" CodeCamp 2009 Ninject Sample ");

            var module = new CustomModule();
            IKernel kernel = new StandardKernel(module);

            var logService = kernel.Get<TextLogService>();

            try
            {
                throw new Exception(" CodeCamp Ninject Sample ");
            }
            catch (Exception e)
            {
                logService.LogIt(DateTime.Now, e.Source, e.Message);
            }

            Console.ReadLine();
        }
    }
}
