using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1
{
    public abstract class ButtonBase : System.Windows.Controls.ContentControl, System.Windows.Input.ICommandSource
    {
        public abstract ICommand Command { get; }
        public abstract object CommandParameter { get; }
        public abstract IInputElement CommandTarget { get; }
        public static readonly RoutedEvent ClickEvent = EventManager.RegisterRoutedEvent(
            "Click", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ButtonBase));
        public event RoutedEventHandler Click
        {
            add { this.AddHandler(ClickEvent, value); }
            remove { this.RemoveHandler(ClickEvent, value); }
        }
        protected virtual void OnClick()
        {
            RoutedEventArgs newEvent = new RoutedEventArgs(ButtonBase.ClickEvent, this);
            this.RaiseEvent(newEvent);
        }
    }
}
