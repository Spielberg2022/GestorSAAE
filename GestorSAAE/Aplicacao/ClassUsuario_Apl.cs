﻿using System;
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
    class ClassUsuario_Apl
    {
        public ClassUsuario_Dom usuario_Dom = new ClassUsuario_Dom();
        public ClassUsuario_Per usuario_Per = new ClassUsuario_Per();
        public SqlConnection sqlConnection = new SqlConnection();
        public string erro;

        public DataTable LocCod(int codigo)
        {
            usuario_Dom.Codigo = codigo;
            usuario_Per.sqlConnection = sqlConnection;
            usuario_Dom.Usuarios = usuario_Per.Localizar(usuario_Dom);
            erro = usuario_Per.erro;
            return usuario_Dom.Usuarios;
        }
    }
}
