using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using GeoEngine.Core.GXNet;
using Geosoft.Desktop.GXNet;

namespace OMScript
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class OMScript : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button tbExecute;
      private System.Windows.Forms.Button tbExit;
      private System.Windows.Forms.TextBox tbCmd;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public OMScript()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         //
         // TODO: Add any constructor code after InitializeComponent call
         //
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose(bool disposing)
      {
         if (disposing)
         {
            if (components != null)
            {
               components.Dispose();
            }
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.tbCmd = new System.Windows.Forms.TextBox();
         this.tbExecute = new System.Windows.Forms.Button();
         this.tbExit = new System.Windows.Forms.Button();
         this.SuspendLayout();
         //
         // label1
         //
         this.label1.Location = new System.Drawing.Point(8, 8);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(96, 24);
         this.label1.TabIndex = 0;
         this.label1.Text = "GX or GS To Run";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         //
         // tbCmd
         //
         this.tbCmd.Location = new System.Drawing.Point(8, 32);
         this.tbCmd.Name = "tbCmd";
         this.tbCmd.Size = new System.Drawing.Size(368, 20);
         this.tbCmd.TabIndex = 1;
         this.tbCmd.Text = "";
         //
         // tbExecute
         //
         this.tbExecute.Location = new System.Drawing.Point(256, 56);
         this.tbExecute.Name = "tbExecute";
         this.tbExecute.Size = new System.Drawing.Size(56, 24);
         this.tbExecute.TabIndex = 2;
         this.tbExecute.Text = "Execute";
         this.tbExecute.Click += new System.EventHandler(this.tbExecute_Click);
         //
         // tbExit
         //
         this.tbExit.Location = new System.Drawing.Point(320, 56);
         this.tbExit.Name = "tbExit";
         this.tbExit.Size = new System.Drawing.Size(56, 24);
         this.tbExit.TabIndex = 3;
         this.tbExit.Text = "Exit";
         this.tbExit.Click += new System.EventHandler(this.tbExit_Click);
         //
         // fOMScript
         //
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(384, 118);
         this.ControlBox = false;
         this.Controls.Add(this.tbExit);
         this.Controls.Add(this.tbExecute);
         this.Controls.Add(this.tbCmd);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "fOMScript";
         this.Text = "OM Script";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.Run(new OMScript());
      }

      private void tbExecute_Click(object sender, System.EventArgs e)
      {
         // --- Create the Geosoft System ---
         CGX_NET pGeo = new CGX_NET("OMScript", "1.0", 0, this, 0);

         if (pGeo != null)
         {
            // --- Is this a GX or a GS ? ---
            // --- Run the GX or Script ---
            string cmd = tbCmd.Text.ToUpper();

            if (cmd.EndsWith(".GX"))
            {
               CSYS.iRunGX(cmd);
            }
            else
            {
               CSYS.iRunGS(cmd);
            }


            // --- Cleanup The Geosoft Object ---

            CGX_NET.ShowError();


            // --- Cleanup ---

            pGeo.Dispose();
         }
      }

      private void tbExit_Click(object sender, System.EventArgs e)
      {
         this.Close();
      }
   }
}
