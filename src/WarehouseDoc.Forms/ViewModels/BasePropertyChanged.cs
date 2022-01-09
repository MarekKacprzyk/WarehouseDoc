using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using WarehouseDoc.Forms.Annotations;

namespace WarehouseDoc.Forms.ViewModels
{
    public class BasePropertyChanged : INotifyPropertyChanged
    {
        protected readonly SynchronizationContext Context = SynchronizationContext.Current;
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //Context?.Post(_ => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)), null);
        }
    }
}