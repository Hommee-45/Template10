﻿#pragma checksum "C:\git.repos\Template10\Samples\PageHeaderSample\Views\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8113E09927169D5311C178AEC512F7DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Template10.Samples.PageHeaderSample.Views
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Template10_Controls_PageHeader_Frame(global::Template10.Controls.PageHeader obj, global::Windows.UI.Xaml.Controls.Frame value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Controls.Frame) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Controls.Frame), targetNullValue);
                }
                obj.Frame = value;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ListViewBase_SelectionMode(global::Windows.UI.Xaml.Controls.ListViewBase obj, global::Windows.UI.Xaml.Controls.ListViewSelectionMode value)
            {
                obj.SelectionMode = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
        };

        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::Template10.Samples.PageHeaderSample.Views.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Template10.Controls.PageHeader obj5;
            private global::Template10.Controls.PageHeader obj6;
            private global::Windows.UI.Xaml.Controls.ListView obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj9;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj10;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj11;
            private global::Windows.UI.Xaml.Controls.AppBarButton obj12;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5:
                        this.obj5 = (global::Template10.Controls.PageHeader)target;
                        break;
                    case 6:
                        this.obj6 = (global::Template10.Controls.PageHeader)target;
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9:
                        this.obj9 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object param0, global::Windows.UI.Xaml.RoutedEventArgs param1) =>
                        {
                        this.dataRoot.ViewModel.StopSelectionMode();
                        };
                        break;
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        break;
                    case 11:
                        this.obj11 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object param0, global::Windows.UI.Xaml.RoutedEventArgs param1) =>
                        {
                        this.dataRoot.ViewModel.StartSelectionMode();
                        };
                        break;
                    case 12:
                        this.obj12 = (global::Windows.UI.Xaml.Controls.AppBarButton)target;
                        ((global::Windows.UI.Xaml.Controls.AppBarButton)target).Click += (global::System.Object param0, global::Windows.UI.Xaml.RoutedEventArgs param1) =>
                        {
                        this.dataRoot.ViewModel.ResetItems();
                        };
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // MainPage_obj1_Bindings

            public void SetDataRoot(global::Template10.Samples.PageHeaderSample.Views.MainPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Template10.Samples.PageHeaderSample.Views.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Frame(obj.Frame, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_Frame(global::Windows.UI.Xaml.Controls.Frame obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Template10_Controls_PageHeader_Frame(this.obj5, obj, null);
                    XamlBindingSetters.Set_Template10_Controls_PageHeader_Frame(this.obj6, obj, null);
                }
            }
            private void Update_ViewModel(global::Template10.Samples.PageHeaderSample.ViewModels.MainPageViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_PageHeaderVisibility(obj.PageHeaderVisibility, phase);
                        this.Update_ViewModel_SelectionPageHeaderVisibility(obj.SelectionPageHeaderVisibility, phase);
                        this.Update_ViewModel_Items(obj.Items, phase);
                        this.Update_ViewModel_SelectionMode(obj.SelectionMode, phase);
                        this.Update_ViewModel_SelectionText(obj.SelectionText, phase);
                        this.Update_ViewModel_DeleteIsEnabled(obj.DeleteIsEnabled, phase);
                    }
                }
            }
            private void Update_ViewModel_PageHeaderVisibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj5, obj);
                }
            }
            private void Update_ViewModel_SelectionPageHeaderVisibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj6, obj);
                }
            }
            private void Update_ViewModel_Items(global::System.Collections.ObjectModel.ObservableCollection<global::System.String> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj7, obj, null);
                }
            }
            private void Update_ViewModel_SelectionMode(global::Windows.UI.Xaml.Controls.ListViewSelectionMode obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ListViewBase_SelectionMode(this.obj7, obj);
                }
            }
            private void Update_ViewModel_SelectionText(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                }
            }
            private void Update_ViewModel_DeleteIsEnabled(global::System.Boolean obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj10, obj);
                }
            }

            private class MainPage_obj1_BindingsTracking
            {
                global::System.WeakReference<MainPage_obj1_Bindings> WeakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::Template10.Samples.PageHeaderSample.ViewModels.MainPageViewModel obj = sender as global::Template10.Samples.PageHeaderSample.ViewModels.MainPageViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_ViewModel_PageHeaderVisibility(obj.PageHeaderVisibility, DATA_CHANGED);
                                    bindings.Update_ViewModel_SelectionPageHeaderVisibility(obj.SelectionPageHeaderVisibility, DATA_CHANGED);
                                    bindings.Update_ViewModel_Items(obj.Items, DATA_CHANGED);
                                    bindings.Update_ViewModel_SelectionMode(obj.SelectionMode, DATA_CHANGED);
                                    bindings.Update_ViewModel_SelectionText(obj.SelectionText, DATA_CHANGED);
                                    bindings.Update_ViewModel_DeleteIsEnabled(obj.DeleteIsEnabled, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "PageHeaderVisibility":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_PageHeaderVisibility(obj.PageHeaderVisibility, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectionPageHeaderVisibility":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_SelectionPageHeaderVisibility(obj.SelectionPageHeaderVisibility, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Items":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Items(obj.Items, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectionMode":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_SelectionMode(obj.SelectionMode, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectionText":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_SelectionText(obj.SelectionText, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "DeleteIsEnabled":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_DeleteIsEnabled(obj.DeleteIsEnabled, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Template10.Samples.PageHeaderSample.ViewModels.MainPageViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::Template10.Samples.PageHeaderSample.ViewModels.MainPageViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_Items(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::System.String> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::System.String>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_ViewModel_Items(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::System.String> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::System.String>;
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 3:
                {
                    this.NormalState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.NarrowState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7:
                {
                    this.ListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 112 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ListView).SelectionChanged += this.ListView_SelectionChanged;
                    #line default
                }
                break;
            case 8:
                {
                    this.TextBlockSelectionInfo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element9 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 10:
                {
                    this.DeleteButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 98 "..\..\..\Views\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.DeleteButton).Click += this.DeleteButton_Click;
                    #line default
                }
                break;
            case 11:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element11 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 12:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element12 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
