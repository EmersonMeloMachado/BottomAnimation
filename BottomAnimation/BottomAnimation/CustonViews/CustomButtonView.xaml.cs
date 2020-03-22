using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BottomAnimation.CustonViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomButtonView : ContentView
    {
        public CustomButtonView()
        {
            InitializeComponent();
        }

        #region Frame
        public int FrameHeightRequest
        {
            get { return (int)GetValue(FrameHeightRequestProperty); }
            set { SetValue(FrameHeightRequestProperty, value); }
        }
        public static readonly BindableProperty FrameHeightRequestProperty = BindableProperty.Create
            (
                nameof(FrameHeightRequestProperty),
                typeof(int),
                typeof(CustomButtonView),
                //defaultValue: 60,
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: OnFrameHeightRequestChange
            );

        private static void OnFrameHeightRequestChange(BindableObject bindable, object oldValue, object newValue)
        {
            var customButtonView = (CustomButtonView)bindable;
            customButtonView.CustomFrame.HeightRequest = (int)newValue;
        }

        public int FrameWidthRequest
        {
            get { return (int)GetValue(FrameWidthRequestProperty); }
            set { SetValue(FrameWidthRequestProperty, value); }
        }

        public static readonly BindableProperty FrameWidthRequestProperty = BindableProperty.Create
           (
               nameof(FrameWidthRequestProperty),
               typeof(int),
               typeof(CustomButtonView),
               //defaultValue: 60,
               defaultBindingMode: BindingMode.TwoWay,
               propertyChanged: OnFrameWidthRequestChange
           );

        private static void OnFrameWidthRequestChange(BindableObject bindable, object oldValue, object newValue)
        {
            var customButtonView = (CustomButtonView)bindable;
            customButtonView.CustomFrame.WidthRequest = (int)newValue;
        }

        public Color FrameBorderColor
        {
            get { return (Color)GetValue(FrameBorderColorProperty); }
            set { SetValue(FrameBorderColorProperty, value); }
        }

        public static readonly BindableProperty FrameBorderColorProperty = BindableProperty.Create
           (
               nameof(FrameBorderColor),
               typeof(Color),
               typeof(CustomButtonView),
               //defaultValue: Color.White,
               defaultBindingMode: BindingMode.TwoWay,
               propertyChanged: OnFrameBorderColorChange
           );

        private static void OnFrameBorderColorChange(BindableObject bindable, object oldValue, object newValue)
        {
            var customButtonView = (CustomButtonView)bindable;
            customButtonView.CustomFrame.BorderColor = (Color)newValue;
        }

        public Color FrameBackgroundColor
        {
            get { return (Color)GetValue(FrameBackgroundColorProperty); }
            set { SetValue(FrameBackgroundColorProperty, value); }
        }

        public static readonly BindableProperty FrameBackgroundColorProperty = BindableProperty.Create
           (
               nameof(FrameBackgroundColor),
               typeof(Color),
               typeof(CustomButtonView),
               //defaultValue: Color.White,
               defaultBindingMode: BindingMode.TwoWay,
               propertyChanged: OnFrameBackgroundColorChange
           );

        private static void OnFrameBackgroundColorChange(BindableObject bindable, object oldValue, object newValue)
        {
            var customButtonView = (CustomButtonView)bindable;
            customButtonView.CustomFrame.BackgroundColor = (Color)newValue;
        }
        #endregion

        #region Label

        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        public static readonly BindableProperty LabelTextProperty = BindableProperty.Create
            (
                nameof(LabelText),
                typeof(string),
                typeof(CustomButtonView),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: OnLabelTextChange
            );

        private static void OnLabelTextChange(BindableObject bindable, object oldValue, object newValue)
        {
            var customButtonView = (CustomButtonView)bindable;
            customButtonView.lblTexte.Text = (string)newValue;
        }

        public Color ColorText
        {
            get { return (Color)GetValue(ColorTextProperty); }
            set { SetValue(ColorTextProperty, value); }
        }

        public static readonly BindableProperty ColorTextProperty = BindableProperty.Create
            (
                nameof(ColorText),
                typeof(Color),
                typeof(CustomButtonView),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: OnColorTextChange
            );

        private static void OnColorTextChange(BindableObject bindable, object oldValue, object newValue)
        {
            var customButtonView = (CustomButtonView)bindable;
            customButtonView.lblTexte.TextColor = (Color)newValue;
        }

        public bool LabelIsVisible
        {
            get { return (bool)GetValue(LabelIsVisibleProperty); }
            set { SetValue(LabelIsVisibleProperty, value); }
        }

        public static readonly BindableProperty LabelIsVisibleProperty = BindableProperty.Create
            (
                nameof(LabelIsVisible),
                typeof(bool),
                typeof(CustomButtonView),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: OnLabelIsVisibleChange
            );

        private static void OnLabelIsVisibleChange(BindableObject bindable, object oldValue, object newValue)
        {
            var customButtonView = (CustomButtonView)bindable;
            customButtonView.lblTexte.IsVisible = (bool)newValue;
        }

        public TextAlignment LabelHorizontalTextAlignment
        {
            get { return (TextAlignment)GetValue(LabelHorizontalTextAlignmentProperty); }
            set { SetValue(LabelHorizontalTextAlignmentProperty, value); }
        }

        public static readonly BindableProperty LabelHorizontalTextAlignmentProperty = BindableProperty.Create
            (
                nameof(LabelHorizontalTextAlignment),
                typeof(TextAlignment),
                typeof(CustomButtonView),

                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: OnLabelHorizontalTextAlignmentTextChange
            );

        private static void OnLabelHorizontalTextAlignmentTextChange(BindableObject bindable, object oldValue, object newValue)
        {
            var customButtonView = (CustomButtonView)bindable;
            customButtonView.lblTexte.HorizontalTextAlignment = (TextAlignment)newValue;
        }

        public TextAlignment LabelVerticalTextAlignment
        {
            get { return (TextAlignment)GetValue(LabelVerticalTextAlignmentProperty); }
            set { SetValue(LabelVerticalTextAlignmentProperty, value); }
        }

        public static readonly BindableProperty LabelVerticalTextAlignmentProperty = BindableProperty.Create
            (
                nameof(LabelVerticalTextAlignment),
                typeof(TextAlignment),
                typeof(CustomButtonView),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: OnLabelVerticalTextAlignmentTextChange
            );

        private static void OnLabelVerticalTextAlignmentTextChange(BindableObject bindable, object oldValue, object newValue)
        {
            var customButtonView = (CustomButtonView)bindable;
            customButtonView.lblTexte.VerticalTextAlignment = (TextAlignment)newValue;
        }

        public LayoutOptions LabelHorizontalOptions
        {
            get { return (LayoutOptions)GetValue(LabelHorizontalOptionsProperty); }
            set { SetValue(LabelHorizontalOptionsProperty, value); }
        }

        public static readonly BindableProperty LabelHorizontalOptionsProperty = BindableProperty.Create
            (
                nameof(LabelHorizontalOptions),
                typeof(LayoutOptions),
                typeof(CustomButtonView),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: OnLabelHorizontalOptionsTextChange
            );

        private static void OnLabelHorizontalOptionsTextChange(BindableObject bindable, object oldValue, object newValue)
        {
            var customButtonView = (CustomButtonView)bindable;
            customButtonView.lblTexte.HorizontalOptions = (LayoutOptions)newValue;
        }

        public LayoutOptions LabelVerticalOptions
        {
            get { return (LayoutOptions)GetValue(LabelVerticalOptionsProperty); }
            set { SetValue(LabelVerticalOptionsProperty, value); }
        }

        public static readonly BindableProperty LabelVerticalOptionsProperty = BindableProperty.Create
            (
                nameof(LabelVerticalOptions),
                typeof(LayoutOptions),
                typeof(CustomButtonView),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: OnLabelVerticalOptionsTextChange
            );

        private static void OnLabelVerticalOptionsTextChange(BindableObject bindable, object oldValue, object newValue)
        {
            var customButtonView = (CustomButtonView)bindable;
            customButtonView.lblTexte.VerticalOptions = (LayoutOptions)newValue;
        }
        #endregion

        #region ActivityIndicator

        public Color ColorActivity
        {
            get { return (Color)GetValue(ColorActivityProperty); }
            set { SetValue(ColorActivityProperty, value); }
        }

        public static readonly BindableProperty ColorActivityProperty = BindableProperty.Create
            (
                nameof(ColorActivity),
                typeof(Color),
                typeof(CustomButtonView),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: OnColorActivityChange
            );

        private static void OnColorActivityChange(BindableObject bindable, object oldValue, object newValue)
        {
            var customButtonView = (CustomButtonView)bindable;
            customButtonView.IndicatorActive.Color = (Color)newValue;
        }

        public bool IsBusy
        {
            get { return (bool)GetValue(IsBusyActivityProperty); }
            set { SetValue(IsBusyActivityProperty, value); }
        }

        public static readonly BindableProperty IsBusyActivityProperty = BindableProperty.Create
            (
                nameof(IsBusy),
                typeof(bool),
                typeof(CustomButtonView),
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: OnIsBusyActivityChange
            );

        private static void OnIsBusyActivityChange(BindableObject bindable, object oldValue, object newValue)
        {
            var customButtonView = (CustomButtonView)bindable;
            customButtonView.IndicatorActive.IsVisible = (bool)newValue;
            customButtonView.IndicatorActive.IsRunning = (bool)newValue;
        }

        #endregion
    }
}