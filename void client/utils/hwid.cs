using System;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace void_client.utils
{
    class methods
    {
        static string SHA1(string input)
        {
            var hash = (new SHA1Managed()).ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Join("", hash.Select(b => b.ToString("x2")).ToArray());
        }
        public static string get_hwid = SHA1(GetHDDSerial() + GetMotherBoardID() + GetProcessorID());
        public static string GetHDDSerial()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM win32_logicaldisk");
            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                if (wmi_HD["VolumeSerialNumber"] != null) return wmi_HD["VolumeSerialNumber"].ToString();
            }
            return string.Empty;
        }
        public static string GetMotherBoardID()
        {
            string mbInfo = string.Empty;
            ManagementScope scope = new ManagementScope("\\\\" + Environment.MachineName + "\\root\\cimv2");
            scope.Connect();
            ManagementObject wmiClass = new ManagementObject(scope, new ManagementPath("Win32_BaseBoard.Tag=\"Base Board\""), new ObjectGetOptions());

            foreach (PropertyData propData in wmiClass.Properties)
            {
                if (propData.Name == "SerialNumber")
                    mbInfo = string.Format("{0,-25}{1}", propData.Name, Convert.ToString(propData.Value));
            }
            return mbInfo.Replace("SerialNumber ", "").Replace("            ", "");
        }
        public static string GetProcessorID()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach(ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["processorID"].Value.ToString();
                break;
            }
            return cpuInfo;
        }
    }
}
