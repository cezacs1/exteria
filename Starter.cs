using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Threading;

public class Start
{
	private static void Main()
	{
		Start.StartAsAdmin();
		Start.RenameRunner();
		Entry.DLLMain(null, Start.CallReason.DLL_PROCESS_START, Start.IsUnderDebugger());
		Environment.Exit(0);
	}

	private static void StartAsAdmin()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("Exteria yönetici olarak tekrar başlatılıyor..");
		Thread.Sleep(1500);
		ProcessStartInfo startInfo = new ProcessStartInfo
		{
			FileName = Process.GetCurrentProcess().MainModule.FileName,
			Verb = "runas",
			Arguments = string.Join(" ", Environment.GetCommandLineArgs().Skip(1))
		};
		try
		{
			Process.Start(startInfo);
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		Environment.Exit(0);
		Process.GetCurrentProcess().Kill();
	}

	public static void RenameRunner()
	{
		new AssemblyName().Name = Entry.Undetected.RandomString();
		Console.Title = Entry.Undetected.RandomString();
		string location = Assembly.GetExecutingAssembly().Location;
		if (location == "" || location == null)
		{
			location = Assembly.GetEntryAssembly().Location;
		}
		Process.Start(new ProcessStartInfo
		{
			FileName = "cmd.exe",
			Arguments = string.Concat(new string[]
			{
				"/C ren \"",
				location,
				"\" ",
				Entry.Undetected.RandomString(),
				".exe"
			}),
			CreateNoWindow = true,
			WindowStyle = ProcessWindowStyle.Hidden
		});
	}

	private static bool IsUnderDebugger()
	{
		return Debugger.IsAttached || Debugger.IsLogging();
	}

	private static int reason_for_start = 1;

	public static string licence;

	public enum CallReason
	{
		DLL_PROCESS_START_ADMIN,
		DLL_PROCESS_START,
		DLL_THREAD_START,
		DLL_PROCESS_STOP,
		DLL_PROCESS_ERROR
	}
}

//CEZA
