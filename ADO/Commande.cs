using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ADO
{
    public class Commande
    {
        [XmlAttribute]
        public int OrderId { get; set; }

        [XmlAttribute]
        public DateTime OrderDate { get; set; }

        [XmlAttribute]
        public DateTime EnvoieDate { get; set; }

        [XmlAttribute]
        public int NbrArticles { get; set; }

        [XmlAttribute]
        public decimal Frais { get; set; }

        [XmlAttribute]
        public decimal Montant { get; set; }

        [XmlAttribute]
        public string CustomerID { get; set; }

        [XmlAttribute]
        public DateTime RequiredDate { get; set; }

        [XmlAttribute]
        public int ShipVia { get; set; }

        [XmlAttribute]
        public string ShipAdress { get; set; }

        [XmlAttribute]
        public string ShipCity { get; set; }

        [XmlAttribute]
        public string ShipRegion { get; set; }

 
        public List<DetailCommande> DetailCommande { get; set; }

    }

    public class DetailCommande
    {
        [XmlAttribute]
        public int ProdId { get; set; }

        [XmlAttribute]
        public decimal UnitPrice { get; set; }

        [XmlAttribute]
        public Int16 Quantity { get; set; }

        [XmlAttribute]
        public float Discount { get; set; }

    }
}
