using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vanilla.CheatEngine;

namespace Tremor
{

    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress,
               [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern int OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] buffer, int size, int lpNumberOfBytesWritten);

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        Process[] processes = Process.GetProcessesByName("WoW");

        List<Data> Items = new List<Data>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateMapList();
        }

        private void PopulateMapList()
        {
            // get initial data
            lv_maps.Items.Clear();
            Items = new List<Data>(){
            new Data(){ Name="Stormwind", Y="-8913.23", X="554.633", Z="94.7944", Map="0"},
            new Data(){ Name="Lakeshire", Y="-9282.98", X="-2269.64", Z="70.39", Map="0"},
            new Data(){ Name="GMIsland", Y="16222.6", X="16265.9", Z="14.2085", Map="1"},
            /*
            new Data(){ Name="", Y="", X="", Z="", Map=""}, 
            */
        };

            // adding initial data
            lv_maps.Items.AddRange(Items.Select(c => new ListViewItem(c.Name)).ToArray());
        }

        private void PopulatePlayerList()
        {
            // get initial data
            lv_maps.Items.Clear();
            Items = new List<Data>(){
            new Data(){ Name="1", Y="-8913.23", X="554.633", Z="94.7944", Map="0"},
            new Data(){ Name="2", Y="-9282.98", X="-2269.64", Z="70.39", Map="0"},
            new Data(){ Name="3", Y="16222.6", X="16265.9", Z="14.2085", Map="1"},
            /*
            new Data(){ Name="", Y="", X="", Z="", Map=""},   
            */
        };

            // adding initial data
            lv_maps.Items.AddRange(Items.Select(c => new ListViewItem(c.Name)).ToArray());
        }

        private void lv_maps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lv_maps.Items.Clear(); // clear list items before adding 
                                   // filter the items match with search key and add result to list view 
            lv_maps.Items.AddRange(Items.Where(i => string.IsNullOrEmpty(tb_mapsearch.Text) || i.Name.StartsWith(tb_mapsearch.Text))
                .Select(c => new ListViewItem(c.Name)).ToArray());
        }

        private void b_defaultlist_Click(object sender, EventArgs e)
        {
            PopulateMapList();
        }

        private void b_playerlist_Click(object sender, EventArgs e)
        {
            PopulatePlayerList();
        }

        //IntPtr address = memory.GetAddress("\"WoW.exe\"+000AE4EC+68+5C4+120+C+2C8");
        private void b_teleport_Click(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("WoW");
            Console.WriteLine(p[0]);
            uint DELETE = 0x00010000;
            uint READ_CONTROL = 0x00020000;
            uint WRITE_DAC = 0x00040000;
            uint WRITE_OWNER = 0x00080000;
            uint SYNCHRONIZE = 0x00100000;
            uint END = 0xFFF; //if you have Windows XP or Windows Server 2003 you must change this to 0xFFFF
            uint PROCESS_ALL_ACCESS = (DELETE | READ_CONTROL | WRITE_DAC | WRITE_OWNER | SYNCHRONIZE | END);

            int processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, p[0].Id);
            int processSize = GetObjectSize("12");

            float x = (float)-4332.891113;
            float y = (float)-761.9750366;
            float z = (float)53.79263687;

            using (Memory memory = new Memory(processes[0]))
            {
                IntPtr addressy = memory.GetAddress("\"WoW.exe\"+000AE4EC+68+5C4+120+C+2C8");
                IntPtr addressx = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+708+C+2A8");
                IntPtr addressz = memory.GetAddress("\"WoW.exe\"+000AE4EC+68+690+C+C+318");

                memory.WriteFloat(addressx, x);
                memory.WriteFloat(addressy, y);
                memory.WriteFloat(addressz, z);
            }
        }

        private static IntPtr GetModuleBaseAddress(string AppName, string ModuleName)
        {
            IntPtr BaseAddress = IntPtr.Zero;
            Process[] myProcess = null;
            ProcessModule myProcessModule = null;

            myProcess = Process.GetProcessesByName(AppName);

            if (myProcess.Length > 0)
            {
                ProcessModuleCollection myProcessModuleCollection;

                try
                {
                    myProcessModuleCollection = myProcess[0].Modules;
                }
                catch { return IntPtr.Zero; /*Maybe would be ok show the exception after/instead return*/ }

                for (int i = 0; i < myProcessModuleCollection.Count; i++)
                {
                    myProcessModule = myProcessModuleCollection[i];
                    if (myProcessModule.ModuleName.Contains(ModuleName))
                    {
                        BaseAddress = myProcessModule.BaseAddress;
                        break;
                    }
                }
            }

            return BaseAddress;
        }

        public int GetObjectSize(object TestObject)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            byte[] Array;
            bf.Serialize(ms, TestObject);
            Array = ms.ToArray();
            return Array.Length;
        }

        private void b_grave_Click(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("WoW");
            Console.WriteLine(p[0]);
            uint DELETE = 0x00010000;
            uint READ_CONTROL = 0x00020000;
            uint WRITE_DAC = 0x00040000;
            uint WRITE_OWNER = 0x00080000;
            uint SYNCHRONIZE = 0x00100000;
            uint END = 0xFFF; //if you have Windows XP or Windows Server 2003 you must change this to 0xFFFF
            uint PROCESS_ALL_ACCESS = (DELETE | READ_CONTROL | WRITE_DAC | WRITE_OWNER | SYNCHRONIZE | END);

            int processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, p[0].Id);
            int processSize = GetObjectSize("12");

            float x = (float)-4332.891113;
            float y = (float)-761.9750366;
            float z = (float)53.79263687;

            using (Memory memory = new Memory(processes[0]))
            {
                // Read Corpse Location
                IntPtr corpsex = memory.GetAddress("00B4E288");
                IntPtr corpsey = memory.GetAddress("00B4E284");
                IntPtr corpsez = memory.GetAddress("00B4E28C");
                float cor_x = Convert.ToSingle(memory.ReadFloat(corpsex));
                float cor_y = Convert.ToSingle(memory.ReadFloat(corpsey));
                float cor_z = Convert.ToSingle(memory.ReadFloat(corpsez));



                ///Write Memeory
                IntPtr addressy = memory.GetAddress("\"WoW.exe\"+000AE4EC+68+5C4+120+C+2C8");
                IntPtr addressx = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+708+C+2A8");
                IntPtr addressz = memory.GetAddress("\"WoW.exe\"+000AE4EC+68+690+C+C+318");

                memory.WriteFloat(addressx, x);
                memory.WriteFloat(addressy, y);
                memory.WriteFloat(addressz, z);
            }
        }
    }



    class Data
    {
        public string Name { get; set; }
        public string Y { get; set; }
        public string X { get; set; }
        public string Z { get; set; }
        public string Map { get; set; }
    }
}
