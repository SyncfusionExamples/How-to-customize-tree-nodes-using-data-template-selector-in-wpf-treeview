# How to customize tree nodes using data template selector in WPF TreeView

This repository describes how to customize tree nodes using data template selector in [WPF TreeView](https://www.syncfusion.com/wpf-controls/treeview) (SfTreeView)

The TreeView allows you to customize the appearance of each item with different templates based on specific constraints by using the [ItemTemplateSelector](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.TreeView.SfTreeView.html#Syncfusion_UI_Xaml_TreeView_SfTreeView_ItemTemplateSelector). You can choose a [DataTemplate](https://docs.microsoft.com/en-us/dotnet/api/system.windows.datatemplate?view=netcore-3.1) for each item at runtime based on the value of data-bound property using `ItemTemplateSelector`.

#### XAML

``` xml
<Window x:Class="NodeWithImageDemo.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:NodeWithImageDemo"
        xmlns:syncfusion="http://schemas.syncfusion.com/wpf"
        mc:Ignorable="d">

    <Window.DataContext>
        <local:FileManagerViewModel/>
    </Window.DataContext>
    <Window.Resources>
        <local:ItemTemplateSelector x:Key="itemTemplateSelector"/>
    </Window.Resources>
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition/>
        </Grid.RowDefinitions>

        <syncfusion:SfTreeView x:Name="sfTreeView" 
		                       Grid.Row="1"
                               ChildPropertyName="SubFiles"
                               FullRowSelect="True"
                               ItemTemplateDataContextType="Node"
                               ItemsSource="{Binding ImageNodeInfo}" 
							   ItemTemplateSelector="{StaticResource itemTemplateSelector}" >
        </syncfusion:SfTreeView>
    </Grid>
</Window>
```

#### C#

``` csharp
class ItemTemplateSelector : DataTemplateSelector
{
    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        var treeviewNode = item as TreeViewNode;
        if (treeviewNode == null)
            return null;
        if (treeviewNode.Level == 0)
            return Application.Current.MainWindow.FindResource("RootTemplate") as DataTemplate;
        else
            return Application.Current.MainWindow.FindResource("ChildTemplate") as DataTemplate;
    }
}
```