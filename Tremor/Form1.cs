using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Vanilla.CheatEngine;

namespace Tremor
{

    public partial class Form1 : Form
    {
        #region TopMost
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        #endregion

        #region Main Kernel Imports
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
        #endregion

        #region Globals
        Process[] processes = Process.GetProcessesByName("WoW");

        DataTable DefaultLocations;
        DataTable PlayerLocations;
        #endregion
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lv_maps.GridLines = true;

            lv_maps.Items.Clear();
            DefaultLocations = new DataTable();
            PlayerLocations = new DataTable();

            DefaultLocations.Columns.Add("Name", typeof(string));
            DefaultLocations.Columns.Add("X", typeof(float));
            DefaultLocations.Columns.Add("Y", typeof(float));
            DefaultLocations.Columns.Add("Z", typeof(float));
            DefaultLocations.Columns.Add("Map", typeof(int));

            DefaultLocations.Rows.Add("Stormwind", "554.633", "-8913.23", "94.7944", "0");

            lv_maps.View = View.Details;
            lv_maps.Columns.Add("Name");
            lv_maps.Columns.Add("X");
            lv_maps.Columns.Add("Y");
            lv_maps.Columns.Add("Z");
            lv_maps.Columns.Add("Map");


            tb_mapsearch.TextChanged += new EventHandler(tb_mapsearch_TextChanged);

            PopulateMapList();
        }

        private void PopulateMapList()
        {
            lv_maps.Items.Clear(); //Clear all the Data in the ListView

            foreach (DataRow row in DefaultLocations.Rows)
            {

                if (row["Name"].ToString().StartsWith(tb_mapsearch.Text)) //If the cell value is start with the value in the TextBox
                {
                    ListViewItem item = new ListViewItem(row["Name"].ToString());

                    item.SubItems.Add(row["Name"].ToString());

                    lv_maps.Items.Add(item); //Add this row to the ListView
                }
            }
        }

        private void PopulatePlayerList()
        {
            // adding initial data
           // lv_maps.Items.Clear();
            //lv_maps.Items.AddRange(PlayerLocations.Select(c => new ListViewItem(c.Name)).ToArray());
        }

        private void AddPlayerLocation()
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

            using (Memory memory = new Memory(processes[0]))
            {
                // Read Current Location
                IntPtr spotx = memory.GetAddress("00C7B548");
                IntPtr spoty = memory.GetAddress("00C7B544");
                IntPtr spotz = memory.GetAddress("00C7B54C");
                float x = Convert.ToSingle(memory.ReadFloat(spotx));
                float y = Convert.ToSingle(memory.ReadFloat(spoty));
                float z = Convert.ToSingle(memory.ReadFloat(spotz));

               // PlayerLocations.Add(new Data() { Name = tb_telename.Text, Y = Convert.ToString(y), X = Convert.ToString(x), Z = Convert.ToString(z), Map = "0" });
            }

            // get initial data
            lv_maps.Items.Clear();
           // lv_maps.Items.AddRange(PlayerLocations.Select(c => new ListViewItem(c.Name)).ToArray());
        }

        private void lv_maps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void b_defaultlist_Click(object sender, EventArgs e)
        {

        }

        private void b_playerlist_Click(object sender, EventArgs e)
        {

        }

        //IntPtr address = memory.GetAddress("\"WoW.exe\"+000AE4EC+68+5C4+120+C+2C8");
        private void b_teleport_Click(object sender, EventArgs e)
        {
            if (lv_maps.SelectedItems.Count > 0)
            {
                var item = lv_maps.SelectedItems[0].Text;
                Console.WriteLine(item);

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
                    IntPtr addressy = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+6B4+3C+2C8");
                    IntPtr addressx = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+708+C+2A8");
                    IntPtr addressz = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+7C8+1A4+54");

                    memory.WriteFloat(addressx, x);
                    memory.WriteFloat(addressy, y);
                    memory.WriteFloat(addressz, z);
                }
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
                IntPtr addressy = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+6B4+3C+2C8");
                IntPtr addressx = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+708+C+2A8");
                IntPtr addressz = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+7C8+1A4+54");

                memory.WriteFloat(addressx, cor_x);
                memory.WriteFloat(addressy, cor_y);
                memory.WriteFloat(addressz, cor_z);
            }
        }

        private void b_addcurrent_Click(object sender, EventArgs e)
        {
            if (tb_telename.Text == "")
            {
                SystemSounds.Beep.Play();
                tb_error_save.ForeColor = Color.Red;
                tb_error_save.Text = "Must enter name to save!";
                return;
            }
            else
            {
                tb_error_save.Text = "";
                AddPlayerLocation();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void aTimer_Tick(object sender, EventArgs e)
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

            using (Memory memory = new Memory(processes[0]))
            {
                // Read Current Location
                IntPtr spotx = memory.GetAddress("00C7B548");
                IntPtr spoty = memory.GetAddress("00C7B544");
                IntPtr spotz = memory.GetAddress("00C7B54C");
                tb_x.Text = Convert.ToString(Convert.ToSingle(memory.ReadFloat(spotx)));
                tb_y.Text = Convert.ToString(Convert.ToSingle(memory.ReadFloat(spoty)));
                tb_z.Text = Convert.ToString(Convert.ToSingle(memory.ReadFloat(spotz)));
            }
        }

        private void OnTop_Tick(object sender, EventArgs e)
        {
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }

        private void tb_mapsearch_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tb_mapsearch_TextChanged(object sender, EventArgs e)
        {
            PopulateMapList();
        }

        private void b_manual_Click(object sender, EventArgs e)
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

            float x = Convert.ToSingle(tb_manual_x.Text);
            float y = Convert.ToSingle(tb_manual_y.Text);
            float z = Convert.ToSingle(tb_manual_z.Text);

            using (Memory memory = new Memory(processes[0]))
            {
                IntPtr addressy = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+6B4+3C+2C8");
                IntPtr addressx = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+708+C+2A8");
                IntPtr addressz = memory.GetAddress("\"WoW.exe\"+0087BCD4+88+28+7C8+1A4+54");

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
