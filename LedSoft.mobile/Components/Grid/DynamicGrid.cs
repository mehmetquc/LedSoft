﻿using LedSoft.Application.DTOs.Other;
using Radzen.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.mobile.Components.Grid
{
    public class DynamicGrid<T>
    {
        public List<RadzenDataGridColumn<T>> Columns { get; set; }
        public DynamicGrid()
        {
            Columns = new List<RadzenDataGridColumn<T>>();
        }
        public void AddColumn(string propertyName, string title, RadzenDataGridColumn<T>? grd)
        {
            var column = new RadzenDataGridColumn<T>();
            column.Property = propertyName;
            column.Title = title;
            if (grd != null)
            {
                Columns.Add(grd);
            }
            else
            {
                Columns.Add(column);
            }
        }

        public void GenerateColumnsFromType(RadzenDataGridColumn<T>? grd, List<ColumnConfig> columnConfig)
        {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            foreach (var property in properties)
            {
                var Config = columnConfig.FirstOrDefault(c => c.Property == property.Name);
                string title = Config?.Title ?? property.Name;
                if (property.Name == "Photo")
                {
                    AddColumn(property.Name, title, grd);
                }
                else
                {
                    AddColumn(property.Name, title, null);
                }

            }
        }
    }
}
