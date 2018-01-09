using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEMG
{
    public class Dados
    {
        public static string DATATABLE_CLIENTS = "Clientes";
        public static string CLIENTS_NAME = "Nome";
        public static string CLIENTS_BIRTHDAY = "Data de Nascimento";
        public static string CLIENTS_GENDER = "Género";
        public static string CLIENTS_ID = "ID Do Cliente";


        public static string DATATABLE_EXAMES = "Exames";
        public static string EXAMES_NAME = "Nome Do Exame";
        public static string EXAMES_CLIENT_ID = "ID Do Cliente";
        public static string EXAMES_ID = "ID";



        DataSet dataSet;
        DataTable tableClients;
        DataTable tableExames;


        String filePath = "EMGClientes.xml";


        public DataTable TableClients
        {
            get
            {
                return tableClients;
            }

            set
            {
                tableClients = value;
            }
        }

        public DataTable TableExames
        {
            get
            {
                return tableExames;
            }

            set
            {
                tableExames = value;
            }
        }

        public DataSet DataSet
        {
            get
            {
                return dataSet;
            }

            set
            {
                dataSet = value;
            }
        }



        public Dados()
        {
            DataSet = new DataSet("clientes_Dataset");

            TableClients = new DataTable(DATATABLE_CLIENTS);

            TableClients.Columns.Add(CLIENTS_NAME);
            TableClients.Columns.Add(CLIENTS_BIRTHDAY);
            TableClients.Columns.Add(CLIENTS_GENDER);
            TableClients.Columns.Add(CLIENTS_ID);


            TableExames = new DataTable(DATATABLE_EXAMES);

            TableExames.Columns.Add(EXAMES_NAME);
            TableExames.Columns.Add(EXAMES_CLIENT_ID);
            TableExames.Columns.Add(EXAMES_ID);

            DataSet.Tables.Add(TableClients);
            DataSet.Tables.Add(TableExames);

            load();
        }



        public void save()
        {
            DataSet.WriteXml(filePath);
        }

        public void load()
        {
            try
            {
                DataSet.ReadXml(filePath);
            }
            catch (FileNotFoundException e)
            {

            }
        }

    }
}
