using Newtonsoft.Json;
using System;
using System.Xml;

namespace JsonConvertExercie
{
    class Program
    {
        static void Main(string[] args)
        {

            ParseToJson();
            ParseToXml();


            Console.ReadLine();

            #region ConvertXmlToJson

            void ParseToJson()
            {

                string xmlData = @"<root>
                                  <writing>danger</writing>
                                  <tried>
                                    <coal>1941373649.8522449</coal>
                                    <slide>1418876285</slide>
                                    <topic>-1204089022</topic>
                                    <particles>-164796100</particles>
                                    <before>-1450047874.0208964</before>
                                    <boat>-2081113923.925571</boat>
                                  </tried>
                                  <ability>exciting</ability>
                                  <tired>730089034</tired>
                                  <was>161813948</was>
                                  <leader>cheese</leader>
                                </root>";
                string result = "";

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(xmlData);
                var jsonData = JsonConvert.SerializeXmlNode(xml, Newtonsoft.Json.Formatting.Indented).Normalize();
                result = jsonData;

                Console.WriteLine("Xml convertido a Json:");
                Console.WriteLine(result);
            }
            #endregion
            #region ConvertJsonToXml
            void ParseToXml()
            {
                string JsonData = @"{
                                  'root': {
                                    'writing': 'danger',
                                    'tried': {
                                        'coal': '1941373649.8522449',
                                        'slide': '1418876285',
                                        'topic': '-1204089022',
                                        'particles': '-164796100',
                                        'before': ' - 1450047874.0208964',
                                        'boat': '-2081113923.925571'},
                                    'ability': 'exciting',
                                    'tired': '730089034',
                                    'was': '161813948',
                                    'leader': 'cheese'}
                                }";

                var xmldata = JsonConvert.DeserializeXNode(JsonData);
                var result = xmldata;

                Console.WriteLine("Json convertido a Xml:");
                Console.WriteLine(result);

            }
            #endregion

        }
    }
}
