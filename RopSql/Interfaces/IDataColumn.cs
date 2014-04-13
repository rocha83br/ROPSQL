﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Data.RopSql.Interfaces
{
    public interface IDataColumn
    {
        bool IsPrimaryKey();
        bool IsRequired();
        bool IsListable();
        bool IsFilterable();
        bool IsListLabel();
        string GetColumnName();
    }
}
