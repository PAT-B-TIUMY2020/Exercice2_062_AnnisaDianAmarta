using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace WcfServiceMahasiswa
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "Mahasiswa", ResponseFormat = WebMessageFormat.Json)] // untuk membuat salah, selalu relative
        List<Mahasiswa> GetAllMahasiswa(); //mendapatkan kumpulan mahasiswa atau seluruh data mahasiswa

        [OperationContract]         /*nama method*/
        [WebGet(UriTemplate = "Mahasiswa/nim = {nim}", ResponseFormat = WebMessageFormat.Json)] //untuk get
        Mahasiswa GetMahasiswaByNIM(string nim); // mengambil data berdasarkan nim

        //void CreateMahasiswa(Mahasiswa mhs); tidak ada pengembalian atau respond balik

        [OperationContract]         /*nama method*/
        [WebInvoke(Method = "POST", UriTemplate = "Mahasiswa", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string CreateMahasiswa(Mahasiswa mhs);

        [OperationContract] /*nama method*/
        [WebInvoke(Method = "DELETE", UriTemplate = "Mahasiswa", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string DeleteMahasiswa(string nim);

        [OperationContract] /*nama method*/
        [WebInvoke(Method = "UPDATE", UriTemplate = "Mahasiswa", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string UpdateMahasiswa(string nim, string nama);



        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServiceRest_062_Annisa_Dian_Amarta.ContractType".

    [DataContract]
    public class Mahasiswa
    {
        private string _nim, _nama, _prodi, _angkatan; // _ adalah konvensi atau kesepakatan //variabel lokal
        [DataMember(Order = 1)] //mengirim data untuk mengurutkan
        public string nim
        {
            get { return _nim; }
            set { _nim = value; }
        }

        [DataMember(Order = 2)]
        public string nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        [DataMember(Order = 3)]
        public string prodi
        {
            get { return _prodi; }
            set { _prodi = value; }
        }

        [DataMember(Order = 4)]
        public string angkatan
        {
            get { return _angkatan; }
            set { _angkatan = value; }
        }
    }
}
