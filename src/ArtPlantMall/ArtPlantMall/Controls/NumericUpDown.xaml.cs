using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ArtPlantMall.Controls
{
    public partial class NumericUpDown : ContentView
    {
        public NumericUpDown()
        {
            InitializeComponent();
            ValueText.SetBinding(Label.TextProperty, new Binding(nameof(Value), BindingMode.TwoWay, source: this));
        }

        public static readonly BindableProperty ValueProperty =
            BindableProperty.Create(nameof(Value), typeof(double), typeof(NumericUpDown), 1.0,
                propertyChanged: (bindable, oldValue, newValue) =>
                    ((NumericUpDown)bindable).Value = (double)newValue,
                defaultBindingMode: BindingMode.TwoWay
            );

        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly BindableProperty MinimumProperty =
            BindableProperty.Create(nameof(Minimum), typeof(double), typeof(NumericUpDown), 0.0,
                propertyChanged: (bindable, oldValue, newValue) =>
                    ((NumericUpDown)bindable).Minimum = (double)newValue
            );

        public double Minimum
        {
            get { return (double)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        public static readonly BindableProperty MaximumProperty =
            BindableProperty.Create(nameof(Maximum), typeof(double), typeof(NumericUpDown), 100.0,
                propertyChanged: (bindable, oldValue, newValue) =>
                    ((NumericUpDown)bindable).Maximum = (double)newValue
            );

        public double Maximum
        {
            get { return (double)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        public static readonly BindableProperty StepProperty =
            BindableProperty.Create(nameof(Step), typeof(double), typeof(NumericUpDown), 1.0,
                propertyChanged: (bindable, oldValue, newValue) =>
                    ((NumericUpDown)bindable).Step = (double)newValue
            );

        public double Step
        {
            get { return (double)GetValue(StepProperty); }
            set { SetValue(StepProperty, value); }
        }

        // PROPERTIES:
        // - Minimum
        // - Maximum
        // - Value
        // - Step
        // OTHER POSSIBLE PROPERTIES:
        // - Animate
        // - NumericBackgroundColor
        // - NumericBorderColor
        // - NumericTextColor
        // - NumericBorderThickness
        // - NumericCornerRadius

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == ValueProperty.PropertyName)
                ValueText.Text = Value.ToString();
        }

        private async void MinusTapped(object sender, EventArgs e)
        {
            await AnimateAsync(MinusButton);

            if ((Value - Step) > Minimum)
                Value -= Step;
            else
                Value = Minimum;
        }

        private async void PlusTapped(object sender, EventArgs e)
        {
            await AnimateAsync(PlusButton);

            if (Value < Maximum)
                Value += Step;
        }

        private async Task AnimateAsync(VisualElement element)
        {
            await element.ScaleTo(0.9, 50, Easing.Linear);
            await Task.Delay(100);
            await element.ScaleTo(1, 50, Easing.Linear);
        }
    }
}