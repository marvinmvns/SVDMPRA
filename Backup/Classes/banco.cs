using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace tela.Classes
{
    class banco
    {
             public string b2()
        {
             string banks = @"Data Source=MVNS\sqlexpress;Database = SVDPMRA; Integrated Security = SSPI;";
             return banks;
            
        }
    }
}
