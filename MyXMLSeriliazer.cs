using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace frmXmlSerilization
{
   public  class MyXMLSeriliazer
    {
        public void Serialize(string path, object obj)
        {
            System.Xml.Serialization.XmlSerializer serialize = new System.Xml.Serialization.XmlSerializer(obj.GetType());
            
            //serilize isleminde ilk once bizden kayit yolu istiyor ve hangi nesneyi ekleyecegini bizden istiyor.
            XmlWriter write = XmlWriter.Create(path);
            serialize.Serialize(write, obj);
            //serilize islemi bittikten sonra xml yazma dosyasını kapatmaliyiz ki bir sonraki yazma isleminde dosya acık hatası verecektir.
            write.Close();
            write.Dispose();
        }
        public object DeSerialize(string path,Type type)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(type);
            XmlReader reader = XmlReader.Create(path);
            object obj = serializer.Deserialize(reader);

            reader.Close();
            reader.Dispose();
            return obj;
        }

        public void Serialize<T>(string path,T obj)
        {
            System.Xml.Serialization.XmlSerializer serialize = new System.Xml.Serialization.XmlSerializer(typeof(T));

            //serilize isleminde ilk once bizden kayit yolu istiyor ve hangi nesneyi ekleyecegini bizden istiyor.
            XmlWriter write = XmlWriter.Create(path);
            serialize.Serialize(write, obj);
            //serilize islemi bittikten sonra xml yazma dosyasını kapatmaliyiz ki bir sonraki yazma isleminde dosya acık hatası verecektir.
            write.Close();
            write.Dispose();
        }
        public T DeSerialize<T>(string path)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
            XmlReader reader = XmlReader.Create(path);
            object obj = serializer.Deserialize(reader);

            reader.Close();
            reader.Dispose();
            return (T)obj;
        }
    }
}
