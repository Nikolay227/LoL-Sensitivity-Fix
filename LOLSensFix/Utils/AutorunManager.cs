using System;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.Win32;

namespace LOLSensFix.Utils
{
    internal class AutorunManager
    {
        public static bool IsAutorunning()
        {
            return HasValue(
                OpenKeyRecursive(Registry.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", false),
                "LSF");
        }

        public static void SetAutorunning(bool autorun)
        {
            if (!IsAdministrator())
            {
                MessageBox.Show("Administrator privileges are required.\n" +
                                "Please restart this application 'As Administrator'.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            var runKey = OpenKeyRecursive(Registry.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            var hasValue = HasValue(runKey, "LSF");

            if (autorun)
            {
                if (!hasValue)
                {
                    runKey.SetValue("LSF", Environment.GetCommandLineArgs()[0]);
                }
            }
            else
            {
                if (hasValue)
                {
                    runKey.DeleteValue("LSF");
                }
            }
        }

        private static RegistryKey OpenKeyRecursive(RegistryKey root, string path, bool writeable)
        {
            var k = root;
            var subkeys = path.Split('\\');
            return subkeys.Aggregate(k,
                (current, subkey) =>
                    current.OpenSubKey(subkey, writeable));
        }

        private static bool HasValue(RegistryKey key, string value)
        {
            return key.GetValueNames().Any(x => x.Equals(value));
        }

        public static bool IsAdministrator()
        {
            using (var identity = WindowsIdentity.GetCurrent())
            {
                var principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
    }
}
