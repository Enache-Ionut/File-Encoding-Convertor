using System;

namespace FileEncodingConvertor
{
  public class CommandsController
  {
    #region Members

    private ConvertToUTF8 mConvertToUTF8Cmd = new ConvertToUTF8();

    #endregion



    #region Public Methods


    public void ChooseCommand(object sender, EventArgs args)
    {
      var menuCommand = sender as System.ComponentModel.Design.MenuCommand;
      if (menuCommand == null)
        return;

      switch (menuCommand.CommandID.ID)
      {
        case ExtensionConstants.UTF8_ID:
          mConvertToUTF8Cmd.Execute();
          break;

      }
    }


    #endregion
  }
}
