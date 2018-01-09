using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEMG
{
    public class ExameLista
    {
        String name;

        long id;

        long clientId;

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

        public long ClientId
        {
            get
            {
                return clientId;
            }

            set
            {
                clientId = value;
            }
        }

        public ExameLista(String name, long clientId)
        {
            this.name = name;
            this.clientId = clientId;
            this.id = Tempo.CurrentTimeMillis();
        }
        public ExameLista(String name, long clientId, long id)
        {
            this.name = name;
            this.clientId = clientId;
            this.id = id;
        }

    }
}
