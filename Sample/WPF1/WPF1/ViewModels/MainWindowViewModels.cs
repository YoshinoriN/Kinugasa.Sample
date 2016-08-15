using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Kinugasa.Mvvm;

namespace WPF1.ViewModels
{
    public class MainWindowViewModels : Kinugasa.Mvvm.BindableBase
    {
        private bool _isVisible = false;
        public bool IsVisible
        {
            get { return this.IsVisible; }
            set
            {
                this.SetProperty(ref this._isVisible, value);
            }
        }

        public MainWindowViewModels()
        {
            this.CommandVisible = new Kinugasa.Mvvm.DelegateCommand(Visible, () => { return this._isVisible == false; });
            this.CommandCollaps = new Kinugasa.Mvvm.DelegateCommand(Collaps, () => { return this._isVisible == true; });
        }

        public ICommand CommandVisible { get; private set; }

        public ICommand CommandCollaps { get; private set; }

        public void Visible()
        {
            this.IsVisible = true;
        }

        public void Collaps()
        {
            this.IsVisible = false;
        }

    }
}
