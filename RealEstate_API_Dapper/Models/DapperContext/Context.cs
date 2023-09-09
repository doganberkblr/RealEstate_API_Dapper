﻿using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace RealEstate_API_Dapper.Models.DapperContext
{
	public class Context
	{
	    private readonly IConfiguration _configuration;

        private readonly string _connectionString;

        public Context(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("connection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
     
		
	}
}

