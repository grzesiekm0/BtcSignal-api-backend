﻿using Btcsignal.Core.Models.Dao;
using Btcsignal.Core.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Btcsignal.Core.Inerfaces.Repositories
{
    public interface IAlertRepository
    {
        Task<IEnumerable<Alert>> GetAlertsAdmin();
        Task<IEnumerable<Alert>> GetAlertsUser(string userId);
        Task<AlertCreateResponse> AddAlert(Alert item);
        Task<AlertCreateResponse> UpdateAlert(Alert item);
        Task<Alert> GetAlert(int alertId);
        Task<IEnumerable<Alert>> GetTest(int alertId);
        Task<Boolean> OnOffAlert(int alertId, bool onOff);
    }
}
