namespace GoogleMapsTool
{
    partial class MapTool
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapTool));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonEnable = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDisable = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonEnable,
            this.toolStripButtonDisable,
            this.toolStripButtonRefresh});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(315, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonEnable
            // 
            this.toolStripButtonEnable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEnable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEnable.Image")));
            this.toolStripButtonEnable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEnable.Name = "toolStripButtonEnable";
            this.toolStripButtonEnable.Size = new System.Drawing.Size(43, 22);
            this.toolStripButtonEnable.Text = "Enable";
            this.toolStripButtonEnable.Click += new System.EventHandler(this.toolStripButtonEnable_Click);
            // 
            // toolStripButtonDisable
            // 
            this.toolStripButtonDisable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDisable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDisable.Image")));
            this.toolStripButtonDisable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDisable.Name = "toolStripButtonDisable";
            this.toolStripButtonDisable.Size = new System.Drawing.Size(45, 22);
            this.toolStripButtonDisable.Text = "Disable";
            this.toolStripButtonDisable.Click += new System.EventHandler(this.toolStripButtonDisable_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonRefresh.Text = "Refresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 25);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(315, 125);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Url = new System.Uri("http://yourwebsite.com/map.html?x1=-100&y1=60&x2=-90&y2=65", System.UriKind.Absolute);
            // 
            // MapTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.toolStrip);
            this.Name = "MapTool";
            this.Size = new System.Drawing.Size(315, 150);
            this.ChangeProjection += new GeoEngine.Core.GXNetX.Windows.ChangeProjectionDelegate(this.MapTool_ChangeProjection);
            this.ChangeArea += new GeoEngine.Core.GXNetX.Windows.ChangeAreaDelegate(this.MapTool_ChangeArea);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonEnable;
        private System.Windows.Forms.ToolStripButton toolStripButtonDisable;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}
