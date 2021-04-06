using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using GestorSAAE.Dominio;
using GestorSAAE.Persistencia;

namespace GestorSAAE.Aplicacao
{
    class ClassGestorWslyS_Apl
    {
        public ClassGestorWslyS_Dom gestorWslyS_Dom = new ClassGestorWslyS_Dom();
        public ClassGestorWslyS_Per gestorWslyS_Per = new ClassGestorWslyS_Per();
        public SqlConnection sqlConnection = new SqlConnection();
        public string erro;

        public bool PrimeiroAcesso()
        {
            gestorWslyS_Per.sqlConnection = sqlConnection;

            if (gestorWslyS_Per.ContarUsuarios() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
