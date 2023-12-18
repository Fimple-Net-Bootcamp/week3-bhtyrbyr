using System;

namespace WebAPI.Services
{
    public class ConsoleLogger : ILogService
    {
        public void Write(params object[] messageParams)
        {
            for (int i = 0; i < messageParams.Length; i += 2)
            {
                ConsoleColor color = (ConsoleColor)messageParams[i];
                string text = messageParams[i + 1].ToString();

                Console.ForegroundColor = color;
                Console.Write(text);
            }

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}