﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DukesAPI.Models;

namespace DukesAPI.DataAccess
{
    public interface IESPNDataAccess
    {
        Task<NewsResponse> GetCollegeFootballDataAsync();
    }
}
