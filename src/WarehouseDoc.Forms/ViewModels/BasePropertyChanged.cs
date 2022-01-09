using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using WarehouseDoc.Forms.Annotations;

namespace WarehouseDoc.Forms.ViewModels
{
    public class BasePropertyChanged : INotifyPropertyChanged
    {

        protected readonly SynchronizationContext _context;
        public event PropertyChangedEventHandler PropertyChanged;
        
        public BasePropertyChanged()
        {

            _context = SynchronizationContext.Current;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            _context.Post(_ => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)), null);
        }
    }
}