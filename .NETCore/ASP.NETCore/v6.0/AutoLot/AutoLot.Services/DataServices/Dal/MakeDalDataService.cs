﻿// Copyright Information
// ==================================
// AutoLot - AutoLot.Services - MakeDalDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2022/08/09
// ==================================

namespace AutoLot.Services.DataServices.Dal;

public class MakeDalDataService : DalDataServiceBase<Make,MakeDalDataService>,IMakeDataService
{

    public MakeDalDataService(IAppLogging<MakeDalDataService> appLogging, IMakeRepo repo):base(appLogging, repo)
    {
    }
}