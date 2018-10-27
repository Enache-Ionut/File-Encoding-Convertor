using System.IO;
using System.Text;

namespace FileEncodingConvertor
{
  /// <summary>
  /// Command handler
  /// </summary>
  public sealed class ConvertToUTF8 : BasicCommand
  {
    #region Public Methods


    /// <summary>
    /// Rewrite all the file in the UTF-8 encoding
    /// </summary>
    public void Execute()
    {
      var selectedItems = GetSelectedFiles();

      foreach (var item in selectedItems)
      {
        var fileContent = File.ReadAllText(item);
        File.WriteAllText(item, fileContent, Encoding.UTF8);
      }

      #endregion

    }
  }
}
