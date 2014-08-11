namespace DeepSearch
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
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
      this.txtResults = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnSearch = new System.Windows.Forms.Button();
      this.optSearch = new DeepSearch.SearchOptions();
      this.SuspendLayout();
      // 
      // txtResults
      // 
      this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtResults.Location = new System.Drawing.Point(12, 132);
      this.txtResults.Multiline = true;
      this.txtResults.Name = "txtResults";
      this.txtResults.Size = new System.Drawing.Size(390, 183);
      this.txtResults.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 116);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Results:";
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(326, 89);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 23);
      this.btnSearch.TabIndex = 3;
      this.btnSearch.Text = "Search";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // optSearch
      // 
      this.optSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.optSearch.AutoScroll = true;
      this.optSearch.Location = new System.Drawing.Point(3, 12);
      this.optSearch.Name = "optSearch";
      this.optSearch.Size = new System.Drawing.Size(408, 70);
      this.optSearch.TabIndex = 0;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(414, 327);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtResults);
      this.Controls.Add(this.optSearch);
      this.Name = "MainForm";
      this.Text = "DeepSearch";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private SearchOptions optSearch;
    private System.Windows.Forms.TextBox txtResults;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSearch;

  }
}

