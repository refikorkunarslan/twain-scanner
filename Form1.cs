// Using block at the top 
using System;
using System.IO;
using Leadtools;
using Leadtools.Codecs;
using Leadtools.Controls;
using Leadtools.Twain;
using System.Windows.Forms;
using System.Drawing;

namespace Acquire_an_Image_from_TWAIN_Source
{
   public partial class Form1 : Form
   {
      // Add this global variable 
      private ImageViewer _viewer;
      // Add this global variable
      private TwainSession _session;
      public Form1()
      {
         InitializeComponent();
         SetLicense();
      }

      static void SetLicense()
      {
         string license = @"C:\LEADTOOLS22\Support\Common\License\LEADTOOLS.LIC";
         string key = File.ReadAllText(@"C:\LEADTOOLS22\Support\Common\License\LEADTOOLS.LIC.KEY");
         RasterSupport.SetLicense(license, key);
         if (RasterSupport.KernelExpired)
            MessageBox.Show("License file invalid or expired.");
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         _viewer = new ImageViewer();
         _viewer.Dock = DockStyle.Fill;
         _viewer.BackColor = Color.DarkGray;
         Controls.Add(_viewer);
         _viewer.BringToFront();

         // This will start the Twain session
         _session = new TwainSession();
         _session.Startup(this.Handle, "manufacturer", "productFamily", "version", "application", TwainStartupFlags.None);
      }
      private void openToolStripMenuItem_Click(object sender, EventArgs e)
      {
         try
         {
            using (RasterCodecs codecs = new RasterCodecs())
            {
               OpenFileDialog dlg = new OpenFileDialog();
               dlg.InitialDirectory = @"C:\Users\Public\Documents\LEADTOOLS Images";
               if (dlg.ShowDialog(this) == DialogResult.OK)
               {
                  string inputFile = dlg.FileName;
                  _viewer.Image = codecs.Load(inputFile);
                  _viewer.Refresh();

               }
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
      }
      private void saveToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (_viewer.Image == null)
         {
            MessageBox.Show("Unable to save! Load an image first");
            return;
         }
         try
         {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "JPEG image|*.jpg";
            if (saveDlg.ShowDialog(this) != DialogResult.OK)
               return;
            using (RasterCodecs codecs = new RasterCodecs())
            {
               codecs.Save(_viewer.Image, saveDlg.FileName, RasterImageFormat.Jpeg, 0);
            }
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.ToString());
         }
      }
      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         _session.Shutdown();
      }

      private void selectSourceToolStripMenuItem_Click(object sender, EventArgs e)
      {
         _session.SelectSource(string.Empty);
      }
      private void acquirePageToolStripMenuItem_Click(object sender, EventArgs e)
      {
         _session.AcquirePage += new EventHandler<TwainAcquirePageEventArgs>(_session_AcquirePage);
         _session.Acquire(TwainUserInterfaceFlags.Show);
      }
      private void _session_AcquirePage(object sender, TwainAcquirePageEventArgs e)
      {
         _viewer.Image = e.Image;
      }
      private void nativeToolStripMenuItem_Click(object sender, EventArgs e)
      {
         TwainCapability capability = new TwainCapability();
         capability.Information.ContainerType = TwainContainerType.OneValue;
         capability.Information.Type = TwainCapabilityType.ImageTransferMechanism;
         capability.OneValueCapability.ItemType = TwainItemType.Uint16;
         capability.OneValueCapability.Value = (UInt16)TwainTransferMechanism.Native;
         _session.SetCapability(capability, TwainSetCapabilityMode.Set);
      }
      private void memoryToolStripMenuItem_Click(object sender, EventArgs e)
      {
         TwainCapability capability = new TwainCapability();
         capability.Information.ContainerType = TwainContainerType.OneValue;
         capability.Information.Type = TwainCapabilityType.ImageTransferMechanism;
         capability.OneValueCapability.ItemType = TwainItemType.Uint16;
         capability.OneValueCapability.Value = (UInt16)TwainTransferMechanism.Memory;
         _session.SetCapability(capability, TwainSetCapabilityMode.Set);
      }
      private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         TwainCapability capability = new TwainCapability();
         capability.Information.ContainerType = TwainContainerType.OneValue;
         capability.Information.Type = TwainCapabilityType.ImageTransferMechanism;
         capability.OneValueCapability.ItemType = TwainItemType.Uint16;
         capability.OneValueCapability.Value = (UInt16)TwainTransferMechanism.File;
         _session.SetCapability(capability, TwainSetCapabilityMode.Set);
      }
   }
}
