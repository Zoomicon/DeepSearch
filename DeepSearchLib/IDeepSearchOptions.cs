using System.ComponentModel;

namespace DeepSearchLib
{
  public interface IDeepSearchOptions : INotifyPropertyChanged
  {

    #region --- Properties ---

    string Text { get; set; }
    string FileFilter { get; set; }

    #endregion

  }

}
