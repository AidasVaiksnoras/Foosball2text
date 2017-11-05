using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
namespace Logic
{
    static public class ServiceClient
    {
        static HttpClient client = new HttpClient();
        static StringBuilder stringBuilder = new StringBuilder();
        static ServiceClient()
        {
            client.BaseAddress = new Uri("http://localhost:53506/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
        }
    }
}
