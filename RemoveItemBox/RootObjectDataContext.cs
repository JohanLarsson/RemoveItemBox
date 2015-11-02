using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using System.Xaml;

namespace RemoveItemBox
{
    [MarkupExtensionReturnType(typeof(BindingExpression))]
    public class RootObjectDataContext : MarkupExtension
    {
        private static readonly PropertyPath DataContextPath = new PropertyPath(FrameworkElement.DataContextProperty);

        public RootObjectDataContext()
        {
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            var rootObjectProvider = (IRootObjectProvider) serviceProvider.GetService(typeof (IRootObjectProvider));
            var binding = new Binding
            {
                Path = DataContextPath,
                Source = rootObjectProvider?.RootObject,
                Mode = BindingMode.OneWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            return binding.ProvideValue(serviceProvider);
        }
    }
}