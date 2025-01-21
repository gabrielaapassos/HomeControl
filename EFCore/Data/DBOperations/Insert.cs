﻿using Microsoft.EntityFrameworkCore;
using Models.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Data.DBOperations
{
    public class Insert
    {
        private static readonly DataContext _context;
        public static void TbItem(string nome, int quantidade, string validade)
        {
            var item = new Item()
            {
                Nome = nome,
                Quantidade = quantidade,
                Validade = validade
            };
            _context.Itens.Add(item);
            _context.SaveChanges();
        }
    }
}
