#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.NativeUI;
using FTOptix.UI;
using FTOptix.CoreBase;
using FTOptix.Alarm;
using FTOptix.Recipe;
using FTOptix.EventLogger;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.Modbus;
using FTOptix.Retentivity;
using FTOptix.CommunicationDriver;
using FTOptix.NetLogic;
using FTOptix.Core;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void CreateObject()
    {
        var model = Project.Current.Get("Model");
        int count = model.Children.Count;
        var newObject = InformationModel.MakeObject("Object" + (count + 1));
        model.Add(newObject);

        var dataGrid = Owner.Get<DataGrid>("DataGrid1");
        dataGrid.Refresh();
    }

    [ExportMethod]
    public void CreateSubObject()
    {
        var model = Project.Current.Get("Model/sub-tree");
        int count = model.Children.Count;
        var newObject = InformationModel.MakeObject("Object" + (count + 1));
        model.Add(newObject);

        var dataGrid = Owner.Get<DataGrid>("DataGrid1");
        dataGrid.Refresh();
    }
}
