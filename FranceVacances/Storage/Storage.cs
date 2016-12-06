using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FranceVacances.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml.Serialization;
using Windows.Storage;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FranceVacances.Storage
{
    public class Storage
    {
        private ObservableCollection<RentalModel> _Offers;
        private static string _OffersPath = "Offers.json";

        public async void SaveOffers(ObservableCollection<RentalModel> Offers)
        {

            StorageFolder localFolder = ApplicationData.Current.LocalFolder;
            StorageFile file = await localFolder.CreateFileAsync(_OffersPath, CreationCollisionOption.ReplaceExisting);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObservableCollection<RentalModel>));

            using (Stream stream = await file.OpenStreamForWriteAsync())
            {
                xmlSerializer.Serialize(stream, Offers);
            }
        }

        public async Task<ObservableCollection<RentalModel>> LoadOffers()
        {
            StorageFolder localFolder = ApplicationData.Current.LocalFolder;
            StorageFile file = await localFolder.GetFileAsync(_OffersPath);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObservableCollection<RentalModel>));

            using (Stream stream = await file.OpenStreamForReadAsync())
            {
                _Offers = xmlSerializer.Deserialize(stream) as ObservableCollection<RentalModel>;
            }

            return _Offers;
        }







    }
}
