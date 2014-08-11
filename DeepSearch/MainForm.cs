using DeepSearchLib;
using System;
using System.Windows.Forms;

namespace DeepSearch
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      IDeepSearchOptions options = optSearch.Options;
      txtResults.Text = "Searching " + options.FileFilter + " for " + options.Text;
    }

  }
}
