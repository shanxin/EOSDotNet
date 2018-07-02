﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOSLib
{
    public class EOSProducer_row : IEOSTable
    {
        public string owner;
        public string total_votes;
        public string producer_key;
        public bool is_active;
        public long unpaid_blocks;
        public string url;

        public double total_votes_long
        {
            get
            {
                return double.Parse(total_votes);
            }
        }
        public EOSTableMetadata getMetadata()
        {

            var meta = new EOSTableMetadata
            {
                primaryKey = "owner",
                contract = "eosio",
                scope = "eosio",
                table = "producers"
            };

            return meta;
        }

    }
}
