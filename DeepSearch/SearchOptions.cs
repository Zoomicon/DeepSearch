using DeepSearchLib;
using System.Windows.Forms;

namespace DeepSearch
{
  public partial class SearchOptions : UserControl
  {

    #region --- Initialization ---

    public SearchOptions()
    {
      InitializeComponent();
      Options = new DeepSearchOptions();
    }

    #endregion

    #region --- Properties ---

    public IDeepSearchOptions Options
    {
      get { return (IDeepSearchOptions)srcDeepSearchOptions.DataSource; }
      set { srcDeepSearchOptions.DataSource = value; }
    }

    #endregion

  }
}
