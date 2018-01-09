using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEMG
{

    public enum GenderType { Masculino, Feminino };
    public class Cliente
    {
        List<ExameLista> exameLista;

        String name;

        DateTime dateTime;

        long id;

        float peso;

        bool praticaDesporto = false;

        GenderType gender;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }

            set
            {
                dateTime = value;
            }
        }

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public List<ExameLista> ExameLista
        {
            get
            {
                return exameLista;
            }

            set
            {
                exameLista = value;
            }
        }

        public float Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public bool PraticaDesporto
        {
            get
            {
                return praticaDesporto;
            }

            set
            {
                praticaDesporto = value;
            }
        }

        public Cliente(String name, DateTime dateTime, GenderType gender, float peso, bool praticaDesporto)
        {
            this.name = name;
            this.dateTime = dateTime;
            this.gender = gender;
            this.peso = peso;
            this.praticaDesporto = praticaDesporto;
            this.id = Tempo.CurrentTimeMillis();
        }

        public Cliente(String name, DateTime dateTime, GenderType gender, long id, float peso, bool praticaDesporto)
        {
            this.name = name;
            this.dateTime = dateTime;
            this.gender = gender;
            this.id = id;
            this.peso = peso;
            this.praticaDesporto = praticaDesporto;
        }

        //CRUD

        //CREATE
        public static void addToDataBase(Dados datahelper, Cliente client)
        {
            DataRow datarow = datahelper.TableClients.NewRow();

            datarow[Dados.CLIENTS_NAME] = client.Name;
            datarow[Dados.CLIENTS_BIRTHDAY] = client.DateTime;
            datarow[Dados.CLIENTS_GENDER] = client.Gender;
            datarow[Dados.CLIENTS_ID] = client.Id;
            datarow[Dados.CLIENTS_PESO] = client.peso;
            datarow[Dados.CLIENTS_PRATICADESPORTO] = client.praticaDesporto;

            datahelper.TableClients.Rows.Add(datarow);
            datahelper.save();
        }

        //READ
        public static Cliente readOnDataBase(Dados datahelper, int index)
        {
            Cliente cliente;

            DataRow datarow = datahelper.TableClients.Rows[index];

            cliente = new Cliente(

            (String)datarow[Dados.CLIENTS_NAME],
             DateTime.Parse((String)datarow[Dados.CLIENTS_BIRTHDAY]),
            parseGender((String)datarow[Dados.CLIENTS_GENDER]),
            long.Parse((String)datarow[Dados.CLIENTS_ID]),
            float.Parse((String)datarow[Dados.CLIENTS_PESO]),
            bool.Parse((String)datarow[Dados.CLIENTS_PRATICADESPORTO]));

            return cliente;
        }

        //update
        public static void editOnDataBase(Dados dados, Cliente client, int indexEditar)
        {
            DataRow datarow = dados.TableClients.Rows[indexEditar];

            datarow[Dados.CLIENTS_NAME] = client.Name;
            datarow[Dados.CLIENTS_BIRTHDAY] = client.DateTime;
            datarow[Dados.CLIENTS_GENDER] = client.Gender;
            datarow[Dados.CLIENTS_ID] = client.Id;
            datarow[Dados.CLIENTS_PESO] = client.Peso;
            datarow[Dados.CLIENTS_PRATICADESPORTO] = client.PraticaDesporto;

            dados.save();
        }

        //DELETE
        public static void removeFromDataBase(Dados dataHelper, int indexToRemove)
        {
            dataHelper.TableClients.Rows.RemoveAt(indexToRemove);
            dataHelper.save();
        }


        public static List<Cliente> getClientsList(Dados datahelper)
        {
            List<Cliente> clients = new List<Cliente>();

            foreach (DataRow dataRow in datahelper.TableClients.Rows)
            {
                String name = (String)dataRow[Dados.CLIENTS_NAME];
                DateTime datetime = (DateTime)dataRow[Dados.CLIENTS_BIRTHDAY];
                GenderType gender = (GenderType)dataRow[Dados.CLIENTS_GENDER];
                float peso = (float)dataRow[Dados.CLIENTS_PESO];
                bool praticaDesporto = (bool)dataRow[Dados.CLIENTS_PRATICADESPORTO];

                clients.Add(new Cliente(name, datetime, gender,peso, praticaDesporto));
            }
            return clients;
        }

        public static GenderType parseGender(String strGender)
        {
            if (strGender.CompareTo("Masculino") == 0)
            {
                return GenderType.Masculino;
            }
            else
            {
                return GenderType.Feminino;
            }

        }
        
    }
}
