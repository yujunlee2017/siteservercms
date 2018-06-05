﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;

namespace SiteServer.Cli.Updater.Model36
{
    public partial class TableAdministratorsInRoles
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }
    }

    public partial class TableAdministratorsInRoles
    {
        public const string OldTableName = "AdministratorsInRoles";

        public static readonly string NewTableName = DataProvider.AdministratorsInRolesDao.TableName;

        public static readonly List<TableColumnInfo> NewColumns = DataProvider.AdministratorsInRolesDao.TableColumns;

        public static readonly Dictionary<string, string> ConvertDict = null;
    }
}