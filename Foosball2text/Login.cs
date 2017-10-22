using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;

namespace Foosball2text
{
    public class Login
    {
        private Database1DataSet _dataset;
        private Database1DataSetTableAdapters.UserTableAdapter _tableAdapter;

        public Login(Database1DataSet dataset, Database1DataSetTableAdapters.UserTableAdapter tableAdapter)
        {
            _dataset = dataset;
            _tableAdapter = tableAdapter;
        }

        public bool IsNameFree(String name)//Grazina true jeigu vartotojas yra naujas, false jeigu jau senas
        {
            _tableAdapter.Fill(_dataset.User);
            int nn = _dataset.User[0].Name.Length;
            int n = name.Length;
            for (int i = 0; i < nn - n; i++)
            {
                name += " ";
            }
            for (int i = 0; i < _dataset.User.Count; i++)
            {
                Match match = Regex.Match(name, _dataset.User[i].Name);
                if(match.Success)
                {
                    return false;
                }
            }
            Register(name);
            return true;
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
