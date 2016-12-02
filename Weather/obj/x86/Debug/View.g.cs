﻿#pragma checksum "I:\Projects\Weather\Weather\View.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BEC721CBC5F868A326BAA8CAA9B01C82"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weather
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class MainPage_obj9_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::Weather.MyListViewObject dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj10;
            private global::Windows.UI.Xaml.Controls.TextBlock obj11;
            private global::Windows.UI.Xaml.Controls.TextBlock obj12;
            private global::Windows.UI.Xaml.Controls.TextBlock obj13;
            private global::Windows.UI.Xaml.Controls.TextBlock obj14;
            private global::Windows.UI.Xaml.Controls.TextBlock obj15;

            public MainPage_obj9_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10:
                        this.obj10 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 11:
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 12:
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 13:
                        this.obj13 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 14:
                        this.obj14 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 15:
                        this.obj15 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::Weather.MyListViewObject data = args.NewValue as global::Weather.MyListViewObject;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::Weather.MyListViewObject was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::Weather.MyListViewObject);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.StackPanel)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Weather.MyListViewObject) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
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
            }

            // MainPage_obj9_Bindings

            public void SetDataRoot(global::Weather.MyListViewObject newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Weather.MyListViewObject obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Image(obj.Image, phase);
                        this.Update_Description(obj.Description, phase);
                        this.Update_MaxTemperature(obj.MaxTemperature, phase);
                        this.Update_MinTemperature(obj.MinTemperature, phase);
                        this.Update_DayOfTheWeek(obj.DayOfTheWeek, phase);
                        this.Update_Day(obj.Day, phase);
                    }
                }
            }
            private void Update_Image(global::Windows.UI.Xaml.Media.Imaging.BitmapImage obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj10, obj, null);
                }
            }
            private void Update_Description(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj, null);
                }
            }
            private void Update_MaxTemperature(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj, null);
                }
            }
            private void Update_MinTemperature(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj13, obj, null);
                }
            }
            private void Update_DayOfTheWeek(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj14, obj, null);
                }
            }
            private void Update_Day(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj15, obj, null);
                }
            }
        }

        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::Weather.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj4;

            public MainPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.ListView)target;
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
            }

            // MainPage_obj1_Bindings

            public void SetDataRoot(global::Weather.MainPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Weather.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_MyController(obj.MyController, phase);
                    }
                }
            }
            private void Update_MyController(global::Weather.Controller obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_MyController_ForecastDays(obj.ForecastDays, phase);
                    }
                }
            }
            private void Update_MyController_ForecastDays(global::System.Collections.ObjectModel.ObservableCollection<global::Weather.MyListViewObject> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj4, obj, null);
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
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 11 "..\..\..\View.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.PageLoaded;
                    #line 11 "..\..\..\View.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).PointerMoved += this.Page_PointerMoved;
                    #line default
                }
                break;
            case 2:
                {
                    this.DirectXPanel = (global::DirectXPanels.D2DPanel)(target);
                }
                break;
            case 3:
                {
                    this.ProgressRing_Load = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 4:
                {
                    this.ListView_Forecast = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 155 "..\..\..\View.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ListView_Forecast).SelectionChanged += this.ListView_Forecast_SelectionChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.Grid_Graph = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6:
                {
                    this.WebView_Map = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            case 7:
                {
                    this.TextBlock_DailyTemperature = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.LineChart = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.Chart)(target);
                }
                break;
            case 16:
                {
                    this.ToggleButton_Switcher = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 101 "..\..\..\View.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.ToggleButton_Switcher).Click += this.ToggleButton_Switcher_Click;
                    #line default
                }
                break;
            case 17:
                {
                    this.TextBlock_WeatherName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.Image_Pressure = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 19:
                {
                    this.TextBlock_Pressure = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20:
                {
                    this.Image_Humidity = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 21:
                {
                    this.TextBlock_Humidity = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22:
                {
                    this.Image_Rain = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 23:
                {
                    this.TextBlock_Rain = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24:
                {
                    this.Image_Clouds = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 25:
                {
                    this.TextBlock_Clounds = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 26:
                {
                    this.Image_Wind = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 27:
                {
                    this.TextBlock_Wind = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 28:
                {
                    this.Image_MapUndo = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 80 "..\..\..\View.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.Image_MapUndo).PointerPressed += this.Image_MapUndo_PointerPressed;
                    #line default
                }
                break;
            case 29:
                {
                    this.Image_MapDo = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 82 "..\..\..\View.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.Image_MapDo).PointerPressed += this.Image_PointerPressed;
                    #line default
                }
                break;
            case 30:
                {
                    this.Button_Search = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 76 "..\..\..\View.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Button_Search).Click += this.Button_Search_Click;
                    #line default
                }
                break;
            case 31:
                {
                    this.TextBox_InputCity = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 32:
                {
                    this.ListBox_Cities = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 73 "..\..\..\View.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.ListBox_Cities).DoubleTapped += this.ListBox_Cities_DoubleTapped;
                    #line default
                }
                break;
            case 33:
                {
                    this.TextBlock_Description = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 34:
                {
                    this.TextBlock_Date = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 35:
                {
                    this.Image_WeatherIcon = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 36:
                {
                    this.TextBlock_WeatherTemperature = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 37:
                {
                    this.TextBlock_Latitude = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 38:
                {
                    this.TextBlock_Longitude = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 39:
                {
                    this.Image_Country = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 40:
                {
                    this.TextBlock_CityName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element9 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    MainPage_obj9_Bindings bindings = new MainPage_obj9_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::Weather.MyListViewObject) element9.DataContext);
                    element9.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element9, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
