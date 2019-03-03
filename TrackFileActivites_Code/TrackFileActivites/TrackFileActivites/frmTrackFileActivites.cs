using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TrackFileActivites
{




    public partial class frmTrackFileActivites : Form
    {
        //Import this function
        [DllImport("user32.dll")]
        public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

        //This flag is for closing the application if it is raised from context menu.
        bool boolContextFormClose = false;
        string strWorkPath = "";   //path of the log file
        private int hwdfrmTrackLog;


        public frmTrackFileActivites()
        {
            InitializeComponent();
            //Initialize the handle value for frmTrackLog
            hwdfrmTrackLog = -1;
          
            //Set the default location of the window
            this.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - 250, System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - 300);

            RegistryKey rk = Registry.LocalMachine;
            RegistryKey rkOpenTrack = rk.OpenSubKey("SOFTWARE\\" + "TrackFileActivitesSumit\\TrackPath"); /*Registory Path = My Computer\HKEY_LOCAL_MACHINE\SOFTWARE\TrackFileActivitesSumit\*/
            if (rkOpenTrack != null)
            {
                txtSetPath.Text = rkOpenTrack.GetValue("Path").ToString();  //If path is already defined, then display it in the track textbox
            }
            else
            {
                txtSetPath.Text = "Null  " ;
            }

          
            RegistryKey rkOpenWork = rk.OpenSubKey("SOFTWARE\\" + "TrackFileActivitesSumit\\WorkPath");
            if (rkOpenWork != null)
            {
                txtWorkPath.Text = rkOpenWork.GetValue("Path").ToString();  //path already defined so display it in the work textbox.  (E:\Desktop\Travail\Videos)

                //Set the Directory Path based on the date (3-3-2019 folder name) (E:\Desktop\Travail\Videos\3-3-2019)
                strWorkPath = txtWorkPath.Text + "\\" + System.DateTime.Now.Day.ToString() + "-" + System.DateTime.Now.Month.ToString() + "-" + System.DateTime.Now.Year.ToString();
                if (!Directory.Exists(strWorkPath))  //Create the directory if it is not created
                {
                    Directory.CreateDirectory(strWorkPath);  
                }
                 
                //Set the File Name
                strWorkPath = strWorkPath + "\\TrackFileActivities.log";
                if (!File.Exists(strWorkPath))   //Create the file if it is not created
                {
                    TextWriter tw = new StreamWriter(strWorkPath);
                    tw.Close();
                }
            }
            else
            {
                txtWorkPath.Text = "Null  ";
            }

        }

        private void btnSetPath_Click(object sender, EventArgs e)
        {
            try
            {
                //path ( already defined or not ) set the selected path for folderBrowserDialog control
                this.folderBrowserDialog.SelectedPath = txtSetPath.Text;

                //If OK is selected then display the path in textbox and update the Registry Key
                folderBrowserDialog.Description = "HI ! Please select the path for tracking !";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSetPath.Text = folderBrowserDialog.SelectedPath;
                    RegistryKey rk = Registry.LocalMachine;
                    RegistryKey rkCreate = rk.CreateSubKey("SOFTWARE\\" + "TrackFileActivitesSumit\\TrackPath");
                    rkCreate.SetValue("Path", txtSetPath.Text);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWorkPath_Click(object sender, EventArgs e)
        {
            try
            {

                this.folderBrowserDialog.SelectedPath = txtWorkPath.Text;

                //If OK is selected then display the path in textbox and update the Registry Key
                folderBrowserDialog.Description = "Please select the path for working.";
                folderBrowserDialog.ShowNewFolderButton = true;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtWorkPath.Text = folderBrowserDialog.SelectedPath;
                    RegistryKey rk = Registry.LocalMachine;
                    RegistryKey rkCreate = rk.CreateSubKey("SOFTWARE\\" + "TrackFileActivitesSumit\\WorkPath");
                    rkCreate.SetValue("Path", txtWorkPath.Text);
                }

                //Set the Directory Path based on the date
                strWorkPath = txtWorkPath.Text + "\\" + System.DateTime.Now.Day.ToString() + "-" + System.DateTime.Now.Month.ToString() + "-" + System.DateTime.Now.Year.ToString();
                //Create the directory if it is not created
                if (!Directory.Exists(strWorkPath))
                {
                    Directory.CreateDirectory(strWorkPath);
                }
                //Set the File Name
                strWorkPath = strWorkPath + "\\TrackFileActivities.log";
                //Create the file if it is not created
                if (!File.Exists(strWorkPath))
                {
                    TextWriter tw = new StreamWriter(strWorkPath);
                    tw.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStartTracking_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtSetPath.Text.Length != 0) && (txtWorkPath.Text.Length != 0))
                {
                    notifyIcon.Text = "Track File Activites [running]";
                    btnStartTracking.Enabled = false;
                    btnStopTracking.Enabled = true;
                    txtSetPath.Enabled = false;
                    txtWorkPath.Enabled = false;
                    btnSetPath.Enabled = false;
                    btnWorkPath.Enabled = false;
                    cmbFilters.Enabled = false;
                    chkIncludeSubdirectories.Enabled = false;
                    gbNotifyFilter.Enabled = false;

                    fileSystemWatcher.EnableRaisingEvents = false;
                    fileSystemWatcher.Path = txtSetPath.Text;
                    fileSystemWatcher.Filter = cmbFilters.Text;
                    fileSystemWatcher.IncludeSubdirectories = chkIncludeSubdirectories.Checked;
                    fileSystemWatcher.EnableRaisingEvents = true;
                }
                else
                {
                    MessageBox.Show("Either of the path is not defined. Please define the path for Track File Activities and Working Path for Log.", "Please define Tracking and Working path ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnStopTracking_Click(object sender, EventArgs e)
        {
            notifyIcon.Text = "Track File Activites [not running]";
            btnStartTracking.Enabled = true;
            btnStopTracking.Enabled = false;
            txtSetPath.Enabled = true;
            txtWorkPath.Enabled = true;
            btnSetPath.Enabled = true;
            btnWorkPath.Enabled = true;
            cmbFilters.Enabled = true;
            chkIncludeSubdirectories.Enabled = true;
            gbNotifyFilter.Enabled = true;


            fileSystemWatcher.EnableRaisingEvents = false;
        }

        private void frmTrackFileActivites_FormClosing(object sender, FormClosingEventArgs e)
        {
            //If the flag is "false", then it means that it is not raised from context menu and it is raised by clicking X button in the form
            if (boolContextFormClose == false)
            {
                e.Cancel = true;
                TopMost = false;
                this.WindowState = FormWindowState.Minimized;

                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.BalloonTipTitle = "Track File Activity ...";
                notifyIcon.BalloonTipText = "Track File Activity is still running in background.\nDouble click me to open options again.";
                notifyIcon.ShowBalloonTip(5);
            }
            //Otherwise the close event is raised from context menu and ask the user whether he wants to close the application
            else
            {
                if (MessageBox.Show("Do you want to close \"Track File Activites\"?", "Track File Activites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }


        }



    }


}

