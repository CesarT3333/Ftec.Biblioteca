using System;
using System.IO;
using Newtonsoft.Json;

namespace Ftec.Biblioteca.UI.utils
{
    public class CredentialsUtils
    {
        public static String getPostgresConnectionString()
        {
            using (StreamReader r = new StreamReader("./credentials/postgres.json"))
            {
                string json = r.ReadToEnd();

                BdConnectionString bdc = JsonConvert
                    .DeserializeObject<BdConnectionString>(json);

                return bdc.ConnString;
            }
        }
    }
}

class BdConnectionString
{
    public String ConnString { get; set; }
}