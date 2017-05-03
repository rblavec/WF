using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ADO
{
    public static class DAL
    {

        public static void RegionList()
        {
            var connectString = Properties.Settings.Default.NorthwindConnectionString;

            // On écrit la requête SQL à exécuter
            string queryString = "select RegionID, RegionDescription from Region";


            // On crée une connexion à partir de la chaîne de connexion
            using (var connect = new SqlConnection(connectString))
            {
                // On créé une commande à partir de la requête,
                // et en utilisant la connexion définies précédemment
                var command = new SqlCommand(queryString, connect);

                // On ouvre la connexion
                connect.Open();

                // On exécute la requête en récupérant son résultat 
                // dans un objet SqlDataRedader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // On lit et on affiche les lignes de résultat en boucle
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}, {1}",
                           reader[0], reader[1]));
                    }
                }
            }
            // Le fait d'avoir créé la connexion dans une instruction using
            // permet de la fermer automatiquement à la fin du bloc using
        }

        public static List<Fournisseur> ListFournisseur()
        {
            var ListDeFournisseur = new List<Fournisseur>();

            var connectString = Properties.Settings.Default.NorthwindConnectionString;

            // On écrit la requête SQL à exécuter
            string queryString = @"select SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country  from Suppliers";


            // On crée une connexion à partir de la chaîne de connexion

            // On crée une connexion à partir de la chaîne de connexion
            using (var connect = new SqlConnection(connectString))
            {
                // On créé une commande à partir de la requête,
                // et en utilisant la connexion définies précédemment
                var command = new SqlCommand(queryString, connect);


                // On ouvre la connexion
                connect.Open();

                // On exécute la requête en récupérant son résultat 
                // dans un objet SqlDataRedader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // On lit et on affiche les lignes de résultat en boucle
                    while (reader.Read())
                    {
                        GetFournisseursFromDataReader(ListDeFournisseur, reader);

                    }
                }
            }
            // Le fait d'avoir créé la connexion dans une instruction using
            // permet de la fermer automatiquement à la fin du bloc using

            return ListDeFournisseur;
        }

        public static List<Fournisseur> ListFournisseur(string NomPays)
        {
            var ListDeFournisseur = new List<Fournisseur>();

            var connectString = Properties.Settings.Default.NorthwindConnectionString;

            // On écrit la requête SQL à exécuter
            string queryString = @"select SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country  from Suppliers 
                                 where Country = @parametre";

            var param = new SqlParameter("@parametre", DbType.String);
            param.Value = NomPays;

            // On crée une connexion à partir de la chaîne de connexion
            using (var connect = new SqlConnection(connectString))
            {
                // On créé une commande à partir de la requête,
                // et en utilisant la connexion définies précédemment
                var command = new SqlCommand(queryString, connect);
                command.Parameters.Add(param);

                // On ouvre la connexion
                connect.Open();

                // On exécute la requête en récupérant son résultat 
                // dans un objet SqlDataRedader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // On lit et on affiche les lignes de résultat en boucle
                    while (reader.Read())
                    {
                        GetFournisseursFromDataReader(ListDeFournisseur, reader);
                    }
                }
            }
            // Le fait d'avoir créé la connexion dans une instruction using
            // permet de la fermer automatiquement à la fin du bloc using

            return ListDeFournisseur;
        }


        private static void GetFournisseursFromDataReader(List<Fournisseur> lstPersonnes, SqlDataReader reader)
        {
            //on créé un nouveau fournisseur, on lui renseigne ses propriétés grâce au DataReader et on l'ajoute à notre collection.
            var pers = new Fournisseur();
            pers.SupplierId = (int)reader["SupplierId"];
            pers.CompanyName = (string)reader["CompanyName"];


            if (reader["ContactName"] != DBNull.Value)
                pers.ContactName = (string)reader["ContactName"];

            if (reader["ContactTitle"] != DBNull.Value)
                pers.ContactTitle = (string)reader["ContactTitle"];

            if (!reader.IsDBNull(4))
                pers.Address = (string)reader["Address"]; ;

            if (!reader.IsDBNull(5))
                pers.City = (string)reader["City"]; ;

            if (!reader.IsDBNull(6))
                pers.Region = (string)reader["Region"]; ;

            if (!reader.IsDBNull(7))
                pers.PostalCode = (string)reader["PostalCode"];

            if (!reader.IsDBNull(8))
                pers.Country = (string)reader["Country"];

            lstPersonnes.Add(pers);

        }


        public static List<string> PaysList()
        {
            var listePays = new List<string>();

            var connectString = Properties.Settings.Default.NorthwindConnectionString;

            // On écrit la requête SQL à exécuter
            string queryString = "select distinct Country from Suppliers order by 1";

            // On crée une connexion à partir de la chaîne de connexion
            using (var connect = new SqlConnection(connectString))
            {
                // On créé une commande à partir de la requête,
                // et en utilisant la connexion définies précédemment
                var command = new SqlCommand(queryString, connect);

                // On ouvre la connexion
                connect.Open();

                // On exécute la requête en récupérant son résultat 
                // dans un objet SqlDataRedader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // On lit et on affiche les lignes de résultat en boucle
                    while (reader.Read())
                    {
                        listePays.Add((string)reader["Country"]);
                    }
                }

            }
            // Le fait d'avoir créé la connexion dans une instruction using
            // permet de la fermer automatiquement à la fin du bloc using

            return listePays;
        }

        public static int NbProdFourni(string NomPays)
        {
            var connectString = Properties.Settings.Default.NorthwindConnectionString;

            // On écrit la requête SQL à exécuter
            string queryString = @"select COUNT(*)Produits from Products p inner join Suppliers s on s.SupplierID = p.SupplierID 
                                 where country = @parameter";

            var param = new SqlParameter("@parameter", DbType.String);
            param.Value = NomPays;

            // On crée une connexion à partir de la chaîne de connexion
            using (var connect = new SqlConnection(connectString))
            {
                // On créé une commande à partir de la requête,
                // et en utilisant la connexion définies précédemment
                var command = new SqlCommand(queryString, connect);
                command.Parameters.Add(param);

                // On ouvre la connexion
                connect.Open();

                int res = (int)command.ExecuteScalar();
                return res;
                // le scalaire remplace le using (SQLDataReader reader = ....)

            }
            // Le fait d'avoir créé la connexion dans une instruction using
            // permet de la fermer automatiquement à la fin du bloc using


        }


        public static List<Commande> ListClients(string IdCLient)
        {
            var ListDeClients = new List<Commande>();

            var connectString = Properties.Settings.Default.NorthwindConnectionString;

            // On écrit la requête SQL à exécuter
            string queryString = @"select * from ufn_Client(@parameter)";

            var param = new SqlParameter("@parameter", DbType.String);
            param.Value = IdCLient;

            // On crée une connexion à partir de la chaîne de connexion

            // On crée une connexion à partir de la chaîne de connexion
            using (var connect = new SqlConnection(connectString))
            {
                // On créé une commande à partir de la requête,
                // et en utilisant la connexion définies précédemment
                var command = new SqlCommand(queryString, connect);
                command.Parameters.Add(param);

                // On ouvre la connexion
                connect.Open();

                // On exécute la requête en récupérant son résultat 
                // dans un objet SqlDataRedader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // On lit et on affiche les lignes de résultat en boucle
                    while (reader.Read())
                    {
                        GetClientsFromDataReader(ListDeClients, reader);

                    }

                }

            }

            return ListDeClients;
        }

        private static void GetClientsFromDataReader(List<Commande> lstPersonnes, SqlDataReader reader)
        {
            var pers = new Commande();

            pers.OrderId = (int)reader["Id"];

            if (reader["DateCommande"] != DBNull.Value)
                pers.OrderDate = (DateTime)reader["DateCommande"];

            if (reader["DateEnvoie"] != DBNull.Value)
                pers.EnvoieDate = (DateTime)reader["DateEnvoie"];


            if (reader["Articles"] != DBNull.Value)
                pers.NbrArticles = (int)reader["Articles"];

            if (reader["Frais"] != DBNull.Value)
                pers.Frais = (decimal)reader["Frais"];


            if (reader["Montant"] != DBNull.Value)
                pers.Montant = (decimal)reader["Montant"];


            lstPersonnes.Add(pers);
        }


        //Récupération de la liste des produits
        public static BindingList<Produit> Produits()
        {

            var ListeProd = new BindingList<Produit>();

            //on recupere la chaine de connection pour pouvoir faire les requetes.
            //Ici le scope (la portée) est l'application.
            var connectString = Properties.Settings.Default.NorthwindConnectionString;

            string queryString = @"select  ProductID, ProductName, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, SupplierID 
                                 from Products where Discontinued = 0";


            using (var connect = new SqlConnection(connectString))
            {

                var command = new SqlCommand(queryString, connect);

                connect.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        GetListProd(ListeProd, reader);
                    }

                }

            }

            return ListeProd;

        }

        private static void GetListProd(BindingList<Produit> dicoProd, SqlDataReader reader)
        {
            //on créé un nouveau fournisseur, on lui renseigne ses propriétés grâce au DataReader et on l'ajoute à notre collection.
            var prod = new Produit();
            prod.NomProduit = (string)reader["ProductName"];
            prod.ProduitId = (int)reader["ProductID"];

            if (reader["CategoryID"] != DBNull.Value)
                prod.Categorie = (int)reader["CategoryID"];

            if (reader["QuantityPerUnit"] != DBNull.Value)
                prod.QuantiteUnitaire = (string)reader["QuantityPerUnit"];

            if (reader["UnitPrice"] != DBNull.Value)
                prod.PrixUnit = (decimal)reader["UnitPrice"];

            if (reader["UnitsInStock"] != DBNull.Value)
                prod.PrixUnit = reader.GetInt16(5);

            if (reader["SupplierID"] != DBNull.Value)
                prod.Fournisseur = (int)reader["SupplierID"];

            dicoProd.Add(prod);
        }


        // Methode de suppression d'un produit de la liste selectionné
        public static void SuppressionProduit(Produit prod)
        {
            var connectString = Properties.Settings.Default.NorthwindConnectionString;

            string queryString = @"Delete Products where ProductID = @param";
            var param = new SqlParameter("@param", DbType.Int32);
            param.Value = prod.ProduitId;

            using (var connect = new SqlConnection(connectString))
            {
                connect.Open();

                var command = new SqlCommand(queryString, connect);
                command.Parameters.Add(param);

                // On execute une requete non select donc on utilise un nonquery.
                command.ExecuteNonQuery();

            }

        }

        // Methode de d'ajout d'un produit de la liste selectionné
        public static void AjoutProduit(Produit prod)
        {
            var connectString = Properties.Settings.Default.NorthwindConnectionString;

            string queryString = @"insert Products (ProductName, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, SupplierID)
                                 values (@param1, @param2, @param3, @param4, @param5, @param6)";


            //Requete if not exist pour vérifier si la catégorie n'existe pas.
            // TODO Ajout de if exist
            string queryString1 = @"insert Categories(CategoryName) values ('Autreproduit')";

            var param1 = new SqlParameter("@param1", DbType.String);
            param1.Value = prod.NomProduit;

            var param2 = new SqlParameter("@param2", DbType.Int32);
            param2.Value = prod.Categorie;

            var param3 = new SqlParameter("@param3", DbType.String);
            param3.Value = prod.QuantiteUnitaire;

            var param4 = new SqlParameter("@param4", DbType.Decimal);
            param4.Value = prod.PrixUnit;

            var param5 = new SqlParameter("@param5", DbType.Int16);
            param5.Value = prod.UnitinStock;

            var param6 = new SqlParameter("@param6", DbType.Int32);
            param6.Value = prod.Fournisseur;

            using (var connect = new SqlConnection(connectString))
            {
                connect.Open();

                SqlTransaction tran = connect.BeginTransaction();

                // Création et execution de la commande.
                var command = new SqlCommand(queryString, connect, tran);
                var command1 = new SqlCommand(queryString1, connect, tran);

                command.Parameters.Add(param1);
                command.Parameters.Add(param2);
                command.Parameters.Add(param3);
                command.Parameters.Add(param4);
                command.Parameters.Add(param5);
                command.Parameters.Add(param6);

                //command1.Parameters.Add("Autreproduit");

                try
                {

                    command.ExecuteNonQuery();
                    command1.ExecuteNonQuery();

                    // On valide la transaction.
                    tran.Commit();
                }

                catch (Exception)

                {
                    // On ne valide pas la transaction (retour à l'état pré-transaction).
                    tran.Rollback();
                    throw;
                }


            }


        }

        public static void InsertionProdMAsse(List<Produit> ListeProd)
        {
            // Création de la requête d'insertion en masse où @table contiendra les enregistrements à insérer dans la table Products.
            string requete = @"insert Products (ProductName, SupplierID, CategoryID, QuantityPerUnit,UnitPrice,UnitsInStock, Discontinued)
                             select ProductName, SupplierID, CategoryID, QuantityPerUnit,UnitPrice,UnitsInStock,Discontinued from @table";

            // On instancie ici un paramètre de type sqlParameter avec comme paramètre le nom du paramètre et son type.
            // NB : structured signifie que le type va être complexe concrêtement une table dans le cas présent.
            var param = new SqlParameter("@table", SqlDbType.Structured);

            // On créé un objet de type DataTable (using system.Data;) et on appel la méthode GetProduitsForProducts avec en paramètre la liste des produits
            // afin de rentrer la liste des produits dans tableProduit.
            DataTable tableProduits = GetProduitsForProducts(ListeProd);

            // On specifie le type de notre paramètre en lui donnant le type TypeTableProduit  créé de prime abord dans la base de donnée ssms.
            param.TypeName = "TypeTableProduit ";

            // On donne au paramètre la valeur de la listeProd.
            param.Value = tableProduits;


            // On crée une connection SqlConnection avec comme chemin Properties.Settings.Default.NorthwindConnectionString.
            // A la fin du using, la connection sera automatiquement fermée (connect.Close())
            using (var connection = new SqlConnection(Properties.Settings.Default.NorthwindConnectionString))
            {

                // On ouvre la connection.
                connection.Open();

                // On crée une transaction.
                SqlTransaction tran = connection.BeginTransaction();


                // On va utiliser un try catch pour valider la transaction ou revenir en arrière en cas d'erreur.
                try
                {
                    // On crée une commande avec notre requete sql, notre connection et la transaction pour indiquer qu'on veut soit commit soit rollback celle-ci.
                    var command = new SqlCommand(requete, connection, tran);
                    command.Parameters.Add(param);
                    command.ExecuteNonQuery();

                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();
                    throw;
                }

            }

        }

        private static DataTable GetProduitsForProducts(List<Produit> ListeProduit)
        {
            // On instancie l'objet table de type DataTable --> création d'une table mémoire
            DataTable table = new DataTable();


            ////////////////////////////////////////////////////////////////////////////////////////////////
            // On crée les nouvelles colonnes.
            ////////////////////////////////////////////////////////////////////////////////////////////////


            // Comme la colonne produit est not null, on le specifie grâce à AllowDBNull.
            // NB : rentrer les colonnes dans le bon ordre.

            var colonnePName = new DataColumn("ProductName", typeof(string));
            colonnePName.AllowDBNull = false;
            table.Columns.Add(colonnePName);

            var colonneFournisseur = new DataColumn("SupplierID", typeof(int));
            colonneFournisseur.AllowDBNull = false;
            table.Columns.Add(colonneFournisseur);

            // Comme CategoryID peut être nul, on peut simplifier la création de la colonne
            table.Columns.Add(new DataColumn("CategoryID", typeof(Int32)));

            table.Columns.Add(new DataColumn("QuantityPerUnit", typeof(string)));

            table.Columns.Add(new DataColumn("UnitPrice", typeof(decimal)));

            table.Columns.Add(new DataColumn("UnitsInStock", typeof(Int16)));

            var colonneObsolete = new DataColumn("Discontinued", typeof(bool));
            colonneObsolete.AllowDBNull = false;
            table.Columns.Add(colonneObsolete);


            foreach (var a in ListeProduit)
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////
                // On crée les nouvelles lignes.
                ////////////////////////////////////////////////////////////////////////////////////////////////

                DataRow ligne = table.NewRow();

                // On assigne aux lignes les valeurs saisies par l'utilisateur.

                ligne["ProductName"] = a.NomProduit;


                ligne["Discontinued"] = a.Obsolete;

                // Pour une colonne nullable dans la base nous devons affecter la valeur DbNull à la place de null.

                if (a.Categorie != null)
                    ligne["CategoryID"] = a.Categorie;
                else ligne["CategoryID"] = DBNull.Value;


                if (a.QuantiteUnitaire != null)
                    ligne["QuantityPerUnit"] = a.QuantiteUnitaire;
                else ligne["QuantityPerUnit"] = DBNull.Value;


                if (a.PrixUnit != null)
                    ligne["UnitPrice"] = a.PrixUnit;
                else ligne["UnitPrice"] = DBNull.Value;


                if (a.UnitinStock != null)
                    ligne["UnitsInStock"] = a.UnitinStock;
                else ligne["UnitsInStock"] = DBNull.Value;


                if (a.Fournisseur != null)
                    ligne["SupplierID"] = a.Fournisseur;
                else ligne["SupplierID"] = DBNull.Value;


                // On ajoute la ligne à la table.
                table.Rows.Add(ligne);

            }

            return table;
        }

        // TODO créer une liste de productID.
        public static void SupressionDeMasse(IEnumerable<int?> ListeId)
        {
            // Création de la requête d'insertion en masse où @table contiendra les enregistrements à insérer dans la table Products.
            string requete = @"update Products set Discontinued = 1 from Products p
                             inner join @TableId t on p.ProductID = t.ProductID";

            // On instancie ici un paramètre de type sqlParameter avec comme paramètre le nom du paramètre et son type.
            // NB : structured signifie que le type va être complexe concrêtement une table dans le cas présent.
            var param = new SqlParameter("@TableId", SqlDbType.Structured);

            // On créé un objet de type DataTable (using system.Data;) et on appel la méthode GetProduitsForProducts avec en paramètre la liste des produits
            // afin de rentrer la liste des produits dans tableProduit.
            DataTable tableProduitsID = GetProduitsIDForProducts(ListeId);

            // On specifie le type de notre paramètre en lui donnant le type TypeTableProduit  créé de prime abord dans la base de donnée ssms.
            param.TypeName = "TypeTableProdId ";

            // On donne au paramètre la valeur de la listeProd.
            param.Value = tableProduitsID;


            // On crée une connection SqlConnection avec comme chemin Properties.Settings.Default.NorthwindConnectionString.
            // A la fin du using, la connection sera automatiquement fermée (connect.Close())
            using (var connection = new SqlConnection(Properties.Settings.Default.NorthwindConnectionString))
            {

                // On ouvre la connection.
                connection.Open();

                // On crée une transaction.
                SqlTransaction tran = connection.BeginTransaction();


                // On va utiliser un try catch pour valider la transaction ou revenir en arrière en cas d'erreur.
                try
                {
                    // On crée une commande avec notre requete sql, notre connection et la transaction pour indiquer qu'on veut soit commit soit rollback celle-ci.
                    var command = new SqlCommand(requete, connection, tran);
                    command.Parameters.Add(param);
                    command.ExecuteNonQuery();

                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();
                    throw;
                }

            }

        }



        private static DataTable GetProduitsIDForProducts(IEnumerable<int?> ListeId)
        {
            // On instancie l'objet table de type DataTable --> création d'une table mémoire
            DataTable table = new DataTable();


            ////////////////////////////////////////////////////////////////////////////////////////////////
            // On crée les nouvelles colonnes.
            ////////////////////////////////////////////////////////////////////////////////////////////////


            // Comme la colonne produit est not null, on le specifie grâce à AllowDBNull.
            // NB : rentrer les colonnes dans le bon ordre.

            var colonnePID = new DataColumn("ProductID", typeof(int));
            colonnePID.AllowDBNull = false;
            table.Columns.Add(colonnePID);


            foreach (var a in ListeId)
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////
                // On crée les nouvelles lignes.
                ////////////////////////////////////////////////////////////////////////////////////////////////

                DataRow ligne = table.NewRow();

                // On assigne aux lignes les valeurs saisies par l'utilisateur.

                ligne["ProductID"] = a.Value;

                // On ajoute la ligne à la table.
                table.Rows.Add(ligne);

            }

            return table;
        }



        public static List<Commande> ListeCommande()
        {
            var ListeCommande = new List<Commande>();

            var connectString = Properties.Settings.Default.NorthwindConnectionString;

            // On écrit la requête SQL à exécuter
            string queryString = @"select o.OrderID, CustomerID, OrderDate, ShippedDate, RequiredDate, ShipVia, ShipAddress, ShipCity, ShipRegion, od.ProductID,
                                 od.Quantity, od.UnitPrice from Orders o inner join Order_Details OD ON od.OrderID = o.OrderID order by o.OrderID";

            // On crée une connexion à partir de la chaîne de connexion
            using (var connect = new SqlConnection(connectString))
            {
                // On créé une commande à partir de la requête,
                // et en utilisant la connexion définies précédemment
                var command = new SqlCommand(queryString, connect);

                // On ouvre la connexion
                connect.Open();

                // On exécute la requête en récupérant son résultat 
                // dans un objet SqlDataRedader
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // On lit et on affiche les lignes de résultat en boucle
                    while (reader.Read())
                    {
                        GetCommandesFromDataReader(ListeCommande, reader);
                    }
                }

            }
            // Le fait d'avoir créé la connexion dans une instruction using
            // permet de la fermer automatiquement à la fin du bloc using

            return ListeCommande;
        }

        private static void GetCommandesFromDataReader(List<Commande> ListeCommande, SqlDataReader reader)
        {

            int IdCommande = (int)reader["OrderID"];


            //Si l'id de la commande courrante est != de la derniere commande de la liste on créé un nouvel objet commande.
            Commande com = null;
            if (ListeCommande.Count == 0 || ListeCommande[ListeCommande.Count - 1].OrderId != IdCommande)
            {
                com = new Commande();
                com.OrderId = (int)reader["orderID"];
                com.CustomerID = (string)reader["CustomerID"];
                com.OrderDate = (DateTime)reader["OrderDate"];

                if (reader["ShippedDate"] != DBNull.Value)
                    com.EnvoieDate = (DateTime)reader["ShippedDate"];

                com.RequiredDate = (DateTime)reader["RequiredDate"];
                com.ShipVia = (int)reader["ShipVia"];

                if (reader["ShipAddress"] != DBNull.Value)
                    com.ShipAdress = (string)reader["ShipAddress"];

                com.ShipCity = (string)reader["ShipCity"];

                if (reader["ShipRegion"] != DBNull.Value)
                    com.ShipRegion = (string)reader["ShipRegion"];

                com.DetailCommande = new List<DetailCommande>();

                ListeCommande.Add(com);

            }

            else com = ListeCommande[ListeCommande.Count - 1];

            DetailCommande l = new DetailCommande();
            l.ProdId = (int)reader["ProductId"];
            l.UnitPrice = (decimal)reader["UnitPrice"];
            l.Quantity = (Int16)reader["Quantity"];
            //if (reader["Discount"] != DBNull.Value)
            //    l.Discount = (float)reader["Discount"];

            com.DetailCommande.Add(l);

        }

        // On veut exporter un fichier XML à partir d'une arborescence d'objets .NET.
        public static void ExporterXml(List<Commande> listCom)
        {
            // On crée un sérialiseur, en spécifiant le type de l'objet à sérialiser, ici une list de commande et le nom de l'élément xml racine
            XmlSerializer serializer = new XmlSerializer(typeof(List<Commande>), new XmlRootAttribute("Commandes"));

            using (StreamWriter streamW = new StreamWriter(@"D:\Exercices\XML\Commandes.xml"))
            {
                serializer.Serialize(streamW, listCom);
            }
        }

        // On veut importer une arborescence d'objets .NET à partir d'un fichier XML.
        public static List<Commande> ImporterXml()
        {
            List<Commande> listCom = null;

            // On specifie le type d'objet qu'on va utiliser et le fichier racine.
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Commande>), new XmlRootAttribute("Commandes"));

            using (StreamReader streamW = new StreamReader(@"D:\Exercices\XML\Commandes.xml"))
            {
                // Deserialize renvoie un type object, qu'il faut transtyper 
                listCom = (List<Commande>)deserializer.Deserialize(streamW);
            }

            return listCom;
        }

        public static void ExporterXml_XmlWriter(List<Commande> listCom)
        {
            // Définit les paramètres pour l'indentation du flux xml généré. Sans sa on aurais un fichier linéaire, sans identations.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";

            // Utilisation d'un XmlWriter avec les paramètres définis précédemment pour écrire un fichier Commandes_Writer.xml.
            // Dans la méthode static create, un new se fait automatiquement, on a donc pas a faire de = new . . .
            using (XmlWriter writer = XmlWriter.Create(@"D:\Exercices\XML\Commandes_Writer.xml", settings))
            {
                // Ecriture du prologue.
                writer.WriteStartDocument();

                // Ecriture de l'élément racine "DatesCommandes".
                writer.WriteStartElement("DatesCommandes");


                // On créé une variable afin de savoir si la date rentréé précédemment est identique à celle rentrée actuellement.
                // Si la date est identique on conserve la même indentation, sinon, on en créera une nouvelle.
                DateTime dateVerif = DateTime.MinValue;


                // Ecriture du contenu interne, avec une structure différente de celle de la collection d'objets passée en paramètre.
                // On va classer la liste en fonction de la date de commande. Pour cela, on utilise un OrderBy.
                foreach (Commande a in listCom.OrderBy(c => c.OrderDate).ToList())
                {
                    // On cherche a verifier que la date rentrée précedemment est différente de celle qu'on souhaite rentrée.
                    // On utilise donc une condition : Si la date est identique, on ne rentre pas dans la boucle sinon, on y rentre.
                    // dateVerif == DateTime.MinValue signifie que la premiere date rentrée rentrera forcement dans la boucle.
                    if (dateVerif == DateTime.MinValue || dateVerif.Month != a.OrderDate.Month || dateVerif.Year != a.OrderDate.Year)
                    {
                        // On souhaite faire en sorte que lors de l'insertion de la premiere valeur, le writeEnd ne s'applique pas.
                        // Cependant, on souhaite qu'il s'execute quand il ne s'agit pas du premier élément entré, ce qui va 
                        // fermer le writer.WriteStartElement("DatesCommandes");
                        // Si on rentre une arrive à une nouvelle date de commande on ferme la précédente et on ouvre une nouvelle.
                        if (dateVerif != DateTime.MinValue)
                        {
                            writer.WriteEndElement();
                        }

                        dateVerif = a.OrderDate;

                        writer.WriteStartElement("DateCommande");
                        writer.WriteAttributeString("annee", a.OrderDate.Year.ToString());
                        writer.WriteAttributeString("mois", a.OrderDate.Month.ToString());

                    }
                    else { }


                    writer.WriteStartElement("Commande");
                    writer.WriteAttributeString("Id", a.OrderId.ToString());



                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    ///// Méthode Foreach (pour trouver le montant)
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                    // Creation d'une variable montant initialisée à 0. 
                    //decimal montant = 0;

                    // On calcul le montant on utilisant une boucle foreach. On peut également utiliser une requete link.
                    //foreach (var b in a.DetailCommande)
                    //{
                    //    montant += b.Quantity * b.UnitPrice * (1 - (decimal)b.Discount);
                    //}

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    ///// FIN Méthode Foreach (pour trouver le montant)
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    ///// Méthode Requete Link (pour trouver le montant)
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    var montant = a.DetailCommande.Sum(f => ((double)(f.Quantity * f.UnitPrice)) * (1 - f.Discount));

                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    ///// FIN Méthode Requete Link (pour trouver le montant)
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                    writer.WriteAttributeString("montant", montant.ToString());

                    // writer.WriteEndElement(). Ferme le dernier élément ouvert.
                    writer.WriteEndElement();


                }


                // Écriture de la balise fermante de l'élément racine et fin du document.
                writer.WriteEndElement();
                // Ferme les éléments encore ouverts.
                writer.WriteEndDocument();
            }
        }

        public static List<Commande> ImporterXmlWithLink()
        {

            List<Commande> listCom = new List<Commande>();

            // Chargement du fichier Xml en mémoire.
            XDocument doc = XDocument.Load(@"D:\Exercices\XML\Commandes.xml");

            // récupération de la liste des comandes
            var comandes = doc.Descendants("Commande");

            foreach (var a in comandes)
            {
                var c = new Commande();
                c.OrderId = int.Parse(a.Attribute("OrderId").Value);
                c.ShipAdress = a.Attribute("ShipAdress").Value;
               

                // Liste des DetailCommande de la collection.
                c.DetailCommande = new List<DetailCommande>();
                foreach (var b in a.Descendants("DetailCommande"))
                {
                    c.DetailCommande.Add(new DetailCommande { Quantity = Int16.Parse(b.Value)});
                    c.DetailCommande.Add(new DetailCommande { UnitPrice = decimal.Parse(b.Value)});
                    c.DetailCommande.Add(new DetailCommande { Discount = float.Parse(b.Value)});

                }

            }
            
            return listCom;
        }

    }
}
