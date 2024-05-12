using System;
using System.Threading;

object locker = new object();
Console.Clear();
Thread system1Thread = new Thread(System1);
Thread system2Thread = new Thread(System2);

system1Thread.Start();
system2Thread.Start();


void System1()
{
   int i = 0;
   while (true)
   {
      if(i == 5){ i = 0; Console.Clear(); }

      string log = "Log do Sistema 1 - " + DateTime.Now.ToString();
      lock (locker)
      {
         Console.SetCursorPosition(0, i);
         Console.WriteLine(log);
      }

      i++;
      Thread.Sleep(5000); // Simulando algum processamento
   }
}

void System2()
{
   int i = 0;
   while (true)
   {
      i = i == 5 ? 0 : i;
      string log = "Log do Sistema 2 - " + DateTime.Now.ToString();
      lock (locker)
      {
         Console.SetCursorPosition(40, i);
         Console.WriteLine(log);
      }
       
      i++;
      Thread.Sleep(5500); // Simulando algum processamento
    }
}

/*
Faça um codigo em C# para criar 2 quadros na tela do pronpt de comando do windows e logar os repectivos logs em tempo real no seu quadro correto de 2 sistemas que estão sendo executados em threads paralelas ao mesmo tempo
*/