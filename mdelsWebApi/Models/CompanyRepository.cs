﻿using System.Collections.Generic;

namespace mdelsWebApi.Models
{
    public class CompanyRepository : ICompanyRepository
    {
        // We are using the list and _fakeDatabaseID to represent what would
    // most likely be a database of some sort, with an auto-incrementing ID field:
        private List<Company> companies = new List<Company>();
        private Company company = new Company();
    DBConnection dbConnection = new DBConnection("en");


    public IEnumerable<Company> GetAll()
    {
        companies = dbConnection.GetAllCompany();

        return companies;
    }


    public Company Get(int id)
    {
        company = dbConnection.GetCompanyById(id);
        return company;
    }


    }
}