#region USING
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Battleships_v2._0
{
    public partial class ReplaySelector : Form
    {
        #region CLASS VARIABLES
        private readonly string source = Settings.ReplayPath;
        private static MergeSort mergeSort = new MergeSort();
        private ConsoleOutputs consoleOutputs = new ConsoleOutputs();
        private List<string> filesFull = new List<string>();
        private List<string> files = new List<string>();
        private int[] filesInt;
        private int[] sorted;
        #endregion

        #region FORM FUNCTIONS
        public ReplaySelector() { InitializeComponent(); }
        private void ReplaySelector_Load(object _sender, EventArgs _e) { Init(); }
        private void SelectorListView_SelectedIndexChanged(object _sender, EventArgs _e) { }
        private void OpenButton_Click(object _sender, EventArgs _e) { OpenFile(); }
        private void m_OpenButton_Click(object _sender, EventArgs _e) { OpenFile(); }
        private void m_MenuButton_Click(object sender, EventArgs e) { ShowMenu(); }
        #endregion

        #region SELECTOR FUNCTIONS
        private void Init()
        {
            GetFiles();
            OrganiseFiles();
            PopulateViewer();
        }
        private void OpenFile()
        {
            int selectedFile= SelectorListView.FocusedItem.Index;
            string file = files[selectedFile];

            Console.WriteLine(file);

            var nextForm = new Replay(file);
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        private void GetFiles()
        {
            foreach (string item in Directory.GetFiles(source))
            {
                FileInfo fileInfo = new FileInfo(item);
                filesFull.Add(fileInfo.FullName);
                files.Add(fileInfo.Name);
            }
            consoleOutputs.List1D(files);
        }
        private void OrganiseFiles()
        {
            string[,] formatted = new string[files.Count, 2];

            for (int i = 0; i < files.Count; i++)
            {
                string[] split = files[i].Split('.');

                for (int j = 0; j < 2; j++)
                {
                    formatted[i, j] = split[j];
                }
            }

            filesInt = new int[files.Count];

            for (int i = 0; i < filesInt.Length; i++)
            {
                filesInt[i] = Convert.ToInt32(formatted[i, 0]);
            }

            sorted = mergeSort.Run(filesInt);

            //consoleOutputs.Console2D(formatted);
            //consoleOutputs.Console1D(filesInt);
            //consoleOutputs.Console1D(sorted);
        }
        private void PopulateViewer()
        {
            for (int i = 0; i < files.Count; i++)
            {
                SelectorListView.Items.Add(sorted[i].ToString());
            }
        }
        #endregion

        #region NAVIGATION
        private void ShowMenu()
        {
            var nextForm = new Menu();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
            this.Dispose();
        }
        #endregion
    }
}
