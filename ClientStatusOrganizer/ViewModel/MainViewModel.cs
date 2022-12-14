using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ClientStatusOrganizer.Data;
using ClientStatusOrganizer.Model;
using static ClientStatusOrganizer.ViewModel.MainViewModel;

namespace ClientStatusOrganizer.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IClientDataService _clientDataService;
        private Client _selectedClient;
        public MainViewModel(IClientDataService clientDataService)
        {
            Clients = new ObservableCollection<Client>();
            _clientDataService = clientDataService;
        }



        public void Load()
        {
            var clients = _clientDataService.GetAll();
            Clients.Clear();
            foreach (var client in clients)
            {
                Clients.Add(client);
            }
        }
        public ObservableCollection<Client> Clients { get; set; }

        public Client SelectedClient
        {
            get { return _selectedClient; }
            set
            {
                _selectedClient = value;
                OnPropertyChanged();
            }
        }
    }
}
