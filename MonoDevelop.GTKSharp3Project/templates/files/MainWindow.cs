using System;
using Gtk;

namespace ${Namespace}
{
    public class MainWindow : Gtk.Window
    {
        [Builder.ObjectAttribute]
        private Button button1;
        [Builder.ObjectAttribute]
        private Label label1;

        private Builder _builder;
        private int _clickedTimes;

        public MainWindow() : this(new Builder(null, "MainWindow.glade", null)) { }

        private MainWindow(Builder builder) : base(builder.GetObject("window1").Handle)
        {
            _builder = builder;
            _builder.Autoconnect(this);

            DeleteEvent += OnDeleteEvent;
            button1.Clicked += onButtonClick;
        }

        private void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        private void onButtonClick(object sender, EventArgs a)
        {
            _clickedTimes++;
            label1.Text = string.Format("Hello World! This button has been clicked {0} time(s).", _clickedTimes);
        }
    }
}

