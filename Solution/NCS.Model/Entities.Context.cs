﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersianProcess.NCS.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SequenceNumber> SequenceNumbers { get; set; }
        public virtual DbSet<EvenNumber> EvenNumbers { get; set; }
        public virtual DbSet<FibonacciNumber> FibonacciNumbers { get; set; }
        public virtual DbSet<MultipleBy3Numbers> MultipleBy3Numbers { get; set; }
        public virtual DbSet<MultipleBy5Numbers> MultipleBy5Numbers { get; set; }
        public virtual DbSet<OddNumber> OddNumbers { get; set; }
    
        public virtual int SequenceNumber_Insert(Nullable<int> number)
        {
            var numberParameter = number.HasValue ?
                new ObjectParameter("Number", number) :
                new ObjectParameter("Number", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SequenceNumber_Insert", numberParameter);
        }
    }
}
