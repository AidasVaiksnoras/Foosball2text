using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Foosball2text
{
    public class Login
    {
        public String _teamA { get; set; }
        public String _teamB { get; set; }

        private Database1DataSet _dataset;
        private Database1DataSetTableAdapters.UserTableAdapter _tableAdapter;

        public Login(Database1DataSet dataset, Database1DataSetTableAdapters.UserTableAdapter tableAdapter)
        {
            _dataset = dataset;
            _tableAdapter = tableAdapter;
        }

        public int Loginas(String name)//Grazina 1 jeigu vartotojas yra naujas, 0 jeigu jau senas
        {
            _tableAdapter.Fill(_dataset.User);
            for (int i = 0; i < _dataset.User.Count; i++)
            {
                if(_dataset.User[i].Name.Contains(name))
                {
                    return 0;
                }
            }
            Register(name);
            return 1;
        }

        public void Register(String name)
        {
            DataRow row = _dataset.User.NewRow();
            row[0] = generateId();
            row[1] = name;
            row[2] = 0;
            row[3] = 0;
            _dataset.User.Rows.Add(row);
            _tableAdapter.Update(_dataset);
            _tableAdapter.Fill(_dataset.User);
        }

        private int generateId()
        {
            int i;
            int id = 0;
            for (i = 0; i < _dataset.User.Count; i++)
            {
                if ((int)_dataset.User[i][0] == id)
                {
                    id++;
                }
                else
                {
                    return id;
                }
            }
            return id;
        }
    }
}
