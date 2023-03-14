using Exteria.NET;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Threading;

public class Start
{
    public enum CallReason
    {
        DLL_PROCESS_START_ADMIN,
        DLL_PROCESS_START,
        DLL_THREAD_START,
        DLL_PROCESS_STOP,
        DLL_PROCESS_ERROR,
    }

    private static void Main()
    {
        StartAsAdmin();
        RenameRunner();

        switch (reason_for_start)
        {
            case (int)CallReason.DLL_PROCESS_START_ADMIN:
                {
                    Entry.DLLMain("CEZA", CallReason.DLL_PROCESS_START_ADMIN, false);
                    break;
                }

            case (int)CallReason.DLL_PROCESS_START:
                {
                    Console.WriteLine("Lisansınızı veya sipariş id'nizi girin:");
                    licence = Console.ReadLine();

                    Entry.DLLMain(licence, CallReason.DLL_PROCESS_START, IsUnderDebugger());
                    break;
                }

            case (int)CallReason.DLL_THREAD_START:
                {
                    Console.WriteLine("Lisansınızı veya sipariş id'nizi girin:");
                    licence = Console.ReadLine();

                    new Thread(() =>
                    {
                        Entry.DLLMain(licence, CallReason.DLL_THREAD_START, IsUnderDebugger());
                    }).Start();
                    break;
                }

            default:
                break;
        }

        
        //Console.WriteLine("DLL Closed?");
        //Console.ReadKey();
        Environment.Exit(0);
    }

    static int reason_for_start = 1;

    static void StartAsAdmin()
    {
        if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
        {
            // İşlem yönetici olarak başlatılmış, burada yapılacak işlemler
            return;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Exteria yönetici olarak tekrar başlatılıyor..");
            Thread.Sleep(1500);

            // Yönetici olarak başlatılmamış, yönetici olarak yeniden başlatmak için
            // aynı dosya yolu ve komut satırı argümanları kullanarak yeni bir işlem oluştur
            var startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName,
                Verb = "runas", // Bu yönetici olarak çalıştırmayı sağlar
                Arguments = string.Join(" ", Environment.GetCommandLineArgs().Skip(1))
            };

            try
            {
                System.Diagnostics.Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                // İşlem oluşturulurken hata oluştu
                // Hata mesajını göstermek için ex.Message kullanılabilir
                Console.WriteLine(ex);
            }

            // Şu anki işlemi sonlandır
            Environment.Exit(0);
            //yada
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
    public static void RenameRunner()
    {
        AssemblyName myAssemblyName = new AssemblyName();
        myAssemblyName.Name = Entry.Undetected.RandomString();
        Console.Title = Entry.Undetected.RandomString();
        string location = Assembly.GetExecutingAssembly().Location;
        if (location == "" || location == null)
        {
            location = Assembly.GetEntryAssembly().Location;
        }
        System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
        start.FileName = "cmd.exe";
        start.Arguments = "/C ren \"" + location + "\" " + Entry.Undetected.RandomString() + ".exe";
        start.CreateNoWindow = true;
        start.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
        System.Diagnostics.Process.Start(start);
    }

    public static string licence;
    static bool IsUnderDebugger() => Debugger.IsAttached || Debugger.IsLogging();
}
