﻿using Jambo.Core.Interfaces.Entities;
using System;
using System.Collections.Generic;

namespace Jambo.Infrastructure.EF.Entities
{
    public class Lote : ILote
    {
        public Guid ID { get; set; }
        public Guid IDEvento { get; set; }
        public DateTime DataLimite { get; set; }
        public int Quantidade { get; set; }

        public virtual Evento EventoNavigation { get; set; }
        public virtual ICollection<Pedido> PedidosNavigation { get; set; }
    }
}