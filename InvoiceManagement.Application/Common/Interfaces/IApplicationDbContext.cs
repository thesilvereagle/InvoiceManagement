﻿using InvoiceManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace InvoiceManagement.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Invoice> Invoices { get; set; }
        DbSet<InvoiceItem> InvoiceItems { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
