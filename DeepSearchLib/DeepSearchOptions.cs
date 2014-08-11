using System.ComponentModel;

namespace DeepSearchLib
{
  public class DeepSearchOptions : IDeepSearchOptions
  {

    #region --- Constants ---

    public const string PROPERTY_TEXT = "Text";
    public const string PROPERTY_FILE_FILTER = "FileFilter";

    public const string DEFAULT_TEXT = "";
    public const string DEFAULT_FILE_FILTER = "*";

    #endregion

    #region --- Fields ---

    private string text = DEFAULT_TEXT;
    private string fileFilter = DEFAULT_FILE_FILTER;

    #endregion

    #region --- Properties ---

    public string Text
    {
      get { return text; }
      set
      {
        if (text != value)
        {
          text = value;
          RaisePropertyChanged(PROPERTY_TEXT);
        }
      }
    }

    public string FileFilter
    {
      get { return fileFilter; }
      set
      {
        if (fileFilter != value)
        {
          fileFilter = value;
          RaisePropertyChanged(PROPERTY_FILE_FILTER);
        }
      }
    }
    
    #endregion

    #region --- Events ---

    //INotifyPropertyChanged//

    public event PropertyChangedEventHandler PropertyChanged;

    public void RaisePropertyChanged(string PropertyName)
    {
      if (PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
    }

    #endregion

  }

}
