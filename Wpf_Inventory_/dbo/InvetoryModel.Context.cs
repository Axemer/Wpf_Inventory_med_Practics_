﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wpf_Inventory_.dbo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InventoryRegistryDataBaseEntities3 : DbContext
    {
        public InventoryRegistryDataBaseEntities3()
            : base("name=InventoryRegistryDataBaseEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Block> Block { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<Device_Workplace> Device_Workplace { get; set; }
        public virtual DbSet<DeviceParts> DeviceParts { get; set; }
        public virtual DbSet<DeviceType> DeviceType { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Office> Office { get; set; }
        public virtual DbSet<Workplace> Workplace { get; set; }
    }
}
