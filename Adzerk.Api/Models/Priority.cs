﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adzerk.Api.Models
{
    public enum SelectionAlgorithm : int
    {
        Lottery = 0,
        Auction = 1,
        AdchainOrdered = 2,
        AdchainOptimized = 3
    }

    public class Priority
    {
        public long Id;
        public string Name;
        public long ChannelId;
        public int Weight;
        public bool IsDeleted;
        public SelectionAlgorithm? SelectionAlgorithm;
    }

    public class PriorityDTO
    {
        public long Id;
        public string Name;
        public long ChannelId;
        public int Weight;
        public bool IsDeleted;
        public int? SelectionAlgorithm;

        public Priority ToPriority()
        {
            var p = new Priority();

            p.Id = Id;
            p.Name = Name;
            p.ChannelId = ChannelId;
            p.Weight = Weight;
            p.IsDeleted = IsDeleted;
            p.SelectionAlgorithm = (SelectionAlgorithm)SelectionAlgorithm;

            return p;
        }
    }
}
