using System;
using System.Threading;

// object locker = new object();
// Console.Clear();
// Thread system1Thread = new Thread(System1);
// Thread system2Thread = new Thread(System2);

// system1Thread.Start();
// system2Thread.Start();


// void System1()
// {
//    int i = 0;
//    while (true)
//    {
//       if(i == 5){ i = 0; Console.Clear(); }

//       string log = "Log do Sistema 1 - " + DateTime.Now.ToString();
//       lock (locker)
//       {
//          Console.SetCursorPosition(0, i);
//          Console.WriteLine(log);
//       }

//       i++;
//       Thread.Sleep(5000); // Simulando algum processamento
//    }
// }

// void System2()
// {
//    int i = 0;
//    while (true)
//    {
//       i = i == 5 ? 0 : i;
//       string log = "Log do Sistema 2 - " + DateTime.Now.ToString();
//       lock (locker)
//       {
//          Console.SetCursorPosition(40, i);
//          Console.WriteLine(log);
//       }
       
//       i++;
//       Thread.Sleep(5500); // Simulando algum processamento
//     }
// }

/*
Faça um codigo em C# para criar 2 quadros na tela do pronpt de comando do windows e logar os repectivos logs em tempo real no seu quadro correto de 2 sistemas que estão sendo executados em threads paralelas ao mesmo tempo
*/

   Thread thread1 = new Thread(Thread1Function);
   Thread thread2 = new Thread(Thread2Function);

   thread1.Start();
   thread2.Start();

    static void Thread1Function()
    {
        // Abre uma nova tela de console para a thread 1
        Console.WriteLine("Tela de Console para Thread 1");
        Console.WriteLine("-----------------------------");

        // Log na tela de console da thread 1
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Thread 1 - Log " + i);
            Thread.Sleep(1000); // Espera 1 segundo
        }
    }

    static void Thread2Function()
    {
        // Abre uma nova tela de console para a thread 2
        Console.WriteLine("Tela de Console para Thread 2");
        Console.WriteLine("-----------------------------");

        // Log na tela de console da thread 2
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Thread 2 - Log " + i);
            Thread.Sleep(1500); // Espera 1.5 segundos
        }
    }