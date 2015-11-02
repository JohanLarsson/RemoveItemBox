using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RemoveItemBox
{
    public class ViewModel
    {
        public ViewModel()
        {
            AddCommand = new RelayCommand(_ => Persons.Add(new Person($"Person {Persons.Count + 1}")));
            RemoveCommand = new RelayCommand(p => Persons.Remove((Person)p), _ => Persons.Count > 0);
        }

        public ObservableCollection<Person> Persons { get; } = new ObservableCollection<Person>();

        public ICommand AddCommand { get; }

        public ICommand RemoveCommand { get; }
    }
}
