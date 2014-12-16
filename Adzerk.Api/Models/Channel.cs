﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adzerk.Api.Models
{
    public enum Engine
    {
        Unknown,
        CPM,
        CPI,
        FIXED
    }

    public class Channel
    {
        public long Id;
        public string Title;
        public bool IsDeleted;
        public decimal Commission;
        public Engine Engine;
        public IEnumerable<string> Keywords;
        public decimal CPM;
        public IEnumerable<long> AdTypeIds;
    }

    public class ChannelDTO
    {
        public long Id;
        public string Title;
        public bool IsDeleted;
        public decimal Commission;
        public string Engine;
        public string Keywords;
        public decimal CPM;
        public IEnumerable<long> AdTypes;

        public Channel ToChannel()
        {
            var c = new Channel();

            c.Id = Id;
            c.Title = Title;
            c.IsDeleted = IsDeleted;
            c.Commission = Commission;
            c.Keywords = (Keywords ?? "").Split(',').Select(s => s.Trim());
            c.CPM = CPM;
            c.AdTypeIds = AdTypes;

            switch (Engine.ToUpper())
            {
                case "CPM":
                    c.Engine = Models.Engine.CPM;
                    break;
                case "CPI":
                    c.Engine = Models.Engine.CPI;
                    break;
                case "FIXED":
                    c.Engine = Models.Engine.FIXED;
                    break;
                default:
                    c.Engine = Models.Engine.Unknown;
                    break;
            }

            return c;
        }
    }
}
