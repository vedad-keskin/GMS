﻿using IronVault.Model.Models;
using IronVault.Model.Requests;
using IronVault.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronVault.Services.Interfaces
{
    public interface ITrackerService 
    {
        public List<Tracker> GetAllTracker(TrackerSearchObject? search);
    }
}
