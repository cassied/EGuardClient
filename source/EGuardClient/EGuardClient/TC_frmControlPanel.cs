using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.IO;
using System.Data.SqlClient;
using System.Collections;

namespace EGuardClient
{
    public partial class TC_frmControlPanel : Form
    {
        public TC_frmControlPanel()
        {
            InitializeComponent();
        }

         private void btnExit_Click(object sender, EventArgs e)
        {
            
            
            this.Close();

            
        }

 
        private void btnTimeControl_Click(object sender, EventArgs e)
        {
            String path = @"C:\\Temp\\TimeControlSettings.txt";
            StreamWriter sw = new StreamWriter(path, false);

            // Get start time
            //String startTime = comboBoxStartTime.GetItemText(this.comboBoxStartTime.SelectedItem);
            String startTime = timeStart.Value.ToString();

            // Get end time
            //String endTime = comboBoxEndTime.GetItemText(this.comboBoxEndTime.SelectedItem);
            String endTime = timeEnd.Value.ToString() + "\r\n";

            // Get the days of the week
            IEnumerator myEnumerator;
            myEnumerator = checkedListBox1.CheckedIndices.GetEnumerator();
            int y;
            String weekDays = ",";
            while (myEnumerator.MoveNext() != false)
            {
                y = (int)myEnumerator.Current;
                //checkedListBox1.SetItemChecked(y, false);
                if (checkedListBox1.GetItemCheckState(y) == CheckState.Checked)
                {
                    weekDays += checkedListBox1.GetItemText(myEnumerator.Current) + ",";
                }

            }

            sw.Write(startTime + "," + endTime + weekDays);
            sw.Close();
            MessageBox.Show("The new Time Control settings have been saved.");

        }

        private void FillTimeControlSettings()
        {
            string fileName = "TimeControlSettings.txt";
            string sourcePath = @".\";
            string targetPath = @"C:\Temp";

            // Use Path class to manipulate file and directory paths. 
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location: 
            // Create a new target folder, if necessary. 
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);

                if (!System.IO.File.Exists(destFile))
                {
                    // To copy a file to another location and  
                    // overwrite the destination file if it already exists.
                    System.IO.File.Copy(sourceFile, destFile, true);
                }
            }          
            
            // Get Seetings from file and fill the form
            String startEndTimesFromFile;
            String daysOfWeekFromFile;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(destFile);

            startEndTimesFromFile = file.ReadLine();
            daysOfWeekFromFile = file.ReadLine();

            // Close file
            file.Close();

            String[] startEndTime = startEndTimesFromFile.Split(new char[] { ',' });
            String[] daysOfWeek = daysOfWeekFromFile.Split(new char[] { ',' });

            // Fill start time
            timeStart.Value = Convert.ToDecimal(startEndTime[0]);
            // Fill end time
            timeEnd.Value = Convert.ToDecimal(startEndTime[1]);

            int index;
            // Fill days of the week
            foreach (String element in daysOfWeek)
            {
                if (element != "")
                {
                    index = Convert.ToInt32(element);
                    checkedListBox1.SetItemCheckState(index, CheckState.Checked);
                }
            }

        }

        private void lblTimeEnd_Click(object sender, EventArgs e)
        {

        }

        private void timeEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblTime1_Click(object sender, EventArgs e)
        {

        }

        private void timeStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDays_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTimeControl_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
            this.Hide();
        }

    

    }
}


