﻿#pragma checksum "E:\VS Projects\To-Do\To-Do\NavigationPages\PendingTasks.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F4EAC6E18E78F8A985A097261FC677F356FD259DD6D2EF50A03A2F1BB03172A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace To_Do.NavigationPages
{
    partial class PendingTasks : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
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

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class PendingTasks_obj35_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPendingTasks_Bindings
        {
            private global::To_Do.NavigationPages.TODOTask dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj35;
            private global::Windows.UI.Xaml.Controls.TextBlock obj41;
            private global::Windows.UI.Xaml.Controls.TextBlock obj43;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj41TextDisabled = false;
            private static bool isobj43TextDisabled = false;

            private PendingTasks_obj35_BindingsTracking bindingsTracking;

            public PendingTasks_obj35_Bindings()
            {
                this.bindingsTracking = new PendingTasks_obj35_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 397 && columnNumber == 148)
                {
                    isobj41TextDisabled = true;
                }
                else if (lineNumber == 410 && columnNumber == 189)
                {
                    isobj43TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 35: // NavigationPages\PendingTasks.xaml line 388
                        this.obj35 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.UserControl)target);
                        break;
                    case 41: // NavigationPages\PendingTasks.xaml line 397
                        this.obj41 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        this.bindingsTracking.RegisterTwoWayListener_41(this.obj41);
                        break;
                    case 43: // NavigationPages\PendingTasks.xaml line 410
                        this.obj43 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj35.Target as global::Windows.UI.Xaml.Controls.UserControl).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::To_Do.NavigationPages.TODOTask) item, 1 << phase);
            }

            public void Recycle()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // IPendingTasks_Bindings

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

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::To_Do.NavigationPages.TODOTask)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::To_Do.NavigationPages.TODOTask obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Description(obj.Description, phase);
                        this.Update_Date(obj.Date, phase);
                    }
                }
            }
            private void Update_Description(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // NavigationPages\PendingTasks.xaml line 397
                    if (!isobj41TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj41, obj, null);
                    }
                }
            }
            private void Update_Date(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // NavigationPages\PendingTasks.xaml line 410
                    if (!isobj43TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj43, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_41_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.Description = this.obj41.Text;
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class PendingTasks_obj35_BindingsTracking
            {
                private global::System.WeakReference<PendingTasks_obj35_Bindings> weakRefToBindingObj; 

                public PendingTasks_obj35_BindingsTracking(PendingTasks_obj35_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<PendingTasks_obj35_Bindings>(obj);
                }

                public PendingTasks_obj35_Bindings TryGetBindingObject()
                {
                    PendingTasks_obj35_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    PendingTasks_obj35_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::To_Do.NavigationPages.TODOTask obj = sender as global::To_Do.NavigationPages.TODOTask;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_Description(obj.Description, DATA_CHANGED);
                                bindings.Update_Date(obj.Date, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Description":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Description(obj.Description, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Date":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Date(obj.Date, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::To_Do.NavigationPages.TODOTask obj)
                {
                    PendingTasks_obj35_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
                public void RegisterTwoWayListener_41(global::Windows.UI.Xaml.Controls.TextBlock sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.TextBlock.TextProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_41_Text();
                        }
                    });
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class PendingTasks_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IPendingTasks_Bindings
        {
            private global::To_Do.NavigationPages.PendingTasks dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj33;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj33ItemsSourceDisabled = false;

            public PendingTasks_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 385 && columnNumber == 207)
                {
                    isobj33ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 33: // NavigationPages\PendingTasks.xaml line 385
                        this.obj33 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IPendingTasks_Bindings

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

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::To_Do.NavigationPages.PendingTasks)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::To_Do.NavigationPages.PendingTasks obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_TaskItems(obj.TaskItems, phase);
                    }
                }
            }
            private void Update_TaskItems(global::System.Collections.ObjectModel.ObservableCollection<global::To_Do.NavigationPages.TODOTask> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // NavigationPages\PendingTasks.xaml line 385
                    if (!isobj33ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj33, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 26: // NavigationPages\PendingTasks.xaml line 384
                {
                    this.scroll = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 27: // NavigationPages\PendingTasks.xaml line 456
                {
                    this.AllDone = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 28: // NavigationPages\PendingTasks.xaml line 464
                {
                    this.NewTaskBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.NewTaskBox).GotFocus += this.NewTaskBox_GotFocus;
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.NewTaskBox).LostFocus += this.NewTaskBox_LostFocus;
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.NewTaskBox).KeyDown += this.NewTaskBox_KeyDown;
                }
                break;
            case 29: // NavigationPages\PendingTasks.xaml line 465
                {
                    this.boxIcon = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                }
                break;
            case 30: // NavigationPages\PendingTasks.xaml line 470
                {
                    this.notif = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 31: // NavigationPages\PendingTasks.xaml line 478
                {
                    this.confirmDoneNotif = (global::Microsoft.UI.Xaml.Controls.InfoBar)(target);
                }
                break;
            case 32: // NavigationPages\PendingTasks.xaml line 481
                {
                    global::Windows.UI.Xaml.Controls.Button element32 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element32).Click += this.UndoDelete;
                }
                break;
            case 33: // NavigationPages\PendingTasks.xaml line 385
                {
                    this.listOfTasks = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.listOfTasks).LayoutUpdated += this.listOfTasks_LayoutUpdated;
                }
                break;
            case 35: // NavigationPages\PendingTasks.xaml line 388
                {
                    global::Windows.UI.Xaml.Controls.UserControl element35 = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                    ((global::Windows.UI.Xaml.Controls.UserControl)element35).PointerEntered += this.UserControl_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.UserControl)element35).PointerExited += this.UserControl_PointerExited;
                }
                break;
            case 37: // NavigationPages\PendingTasks.xaml line 395
                {
                    global::Windows.UI.Xaml.Controls.CheckBox element37 = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element37).PointerCaptureLost += this.CheckBox_PointerCaptureLost;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)element37).Checked += this.CheckBox_Checked;
                }
                break;
            case 39: // NavigationPages\PendingTasks.xaml line 425
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element39 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element39).Click += this.LaunchEditBox;
                }
                break;
            case 40: // NavigationPages\PendingTasks.xaml line 431
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element40 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element40).Click += this.MenuFlyoutItem_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // NavigationPages\PendingTasks.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    PendingTasks_obj1_Bindings bindings = new PendingTasks_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 35: // NavigationPages\PendingTasks.xaml line 388
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element35 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    PendingTasks_obj35_Bindings bindings = new PendingTasks_obj35_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element35.DataContext);
                    element35.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element35, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element35, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

