<<<<<<< HEAD
﻿using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
=======
﻿using System;
>>>>>>> fbccb78aa3ea25cdd5cd36b2a63c353ebb74cb7f
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
<<<<<<< HEAD
    public interface ISqlConnectionFactory
    {
        SqlConnection Create();
    }
    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly string _cs;
        public SqlConnectionFactory(IConfiguration configuration)
        {
            _cs = configuration.GetConnectionString("Default")
             ?? throw new InvalidOperationException("Missing ConnectionStrings:Default");
        }
        public SqlConnection Create()
        {
            return new SqlConnection(_cs);
        }
=======
    internal class SqlConnectionFactory
    {
>>>>>>> fbccb78aa3ea25cdd5cd36b2a63c353ebb74cb7f
    }
}
