using EnvDTE;
using EnvDTE80;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEncodingConvertor
{
  public class BasicCommand
  {

    #region Protected Methods

    /// <summary>
    /// Get all the selected files from Solution Explorer
    /// </summary>
    /// <returns>Selected files from Solution Explorer</returns>
    protected IEnumerable<string> GetSelectedFiles()
    {
      Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();

      if (!VsServiceProvider.TryGetService(typeof(DTE), out object dte))
        return new List<string>();

      var dte2 = dte as DTE2;
      var items = (Array)dte2.ToolWindows.SolutionExplorer.SelectedItems;

      return from item in items.Cast<UIHierarchyItem>()
             let projectItem = item.Object as ProjectItem
             select projectItem.FileNames[1];
    }

    #endregion

  }
}
