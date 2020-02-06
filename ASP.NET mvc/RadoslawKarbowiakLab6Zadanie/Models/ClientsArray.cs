using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadoslawKarbowiakLab6Zadanie.Models
{
    public class ClientsArray
    {
        private static ClientsArray instance = new ClientsArray();

        public List<ClientViewModel> clientViewModels { get; set; }

        public static ClientsArray GetInstance()
        {
            return instance;
        }

        private ClientsArray()
        {
            clientViewModels = new List<ClientViewModel>();

            clientViewModels.Add(new ClientViewModel("Grzegorz", "Baran", "Pizza Carbonara", 23));
            clientViewModels.Add(new ClientViewModel("Tomasz", "Paw", "Pizza Prosciutto", 23));
            clientViewModels.Add(new ClientViewModel("Iza", "Bohan", "Pizza Vege", 23));
        }

        public void Add(ClientViewModel client)
        {
            clientViewModels.Add(client);
        }
        public void Remove(ClientViewModel client)
        {
            foreach (ClientViewModel clientIter in clientViewModels)
            {
                if (clientIter.FirstName.Equals(client.FirstName) && clientIter.SecondName.Equals(client.SecondName))
                {
                    clientViewModels.Remove(clientIter);
                    return;
                }
            }
        } 
        public Boolean Contains(ClientViewModel client)
        {
            foreach(ClientViewModel clientIter in clientViewModels)
            {
                if (clientIter.FirstName.Equals(client.FirstName) && clientIter.SecondName.Equals(client.SecondName)) return true;
            }
            return false;
        }
    }
}
