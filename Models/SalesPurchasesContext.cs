using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using System.IO;

#nullable disable

namespace Sales.Models
{
    public partial class SalesPurchasesContext : DbContext
    {
        public SalesPurchasesContext()
        {
        }

        public SalesPurchasesContext(DbContextOptions<SalesPurchasesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ABrand> ABrands { get; set; }
        public virtual DbSet<ACategory> ACategories { get; set; }
        public virtual DbSet<ACountry> ACountries { get; set; }
        public virtual DbSet<AProduct> AProducts { get; set; }
        public virtual DbSet<AProductLog> AProductLogs { get; set; }
        public virtual DbSet<AStaff> AStaffs { get; set; }
        public virtual DbSet<AStock> AStocks { get; set; }
        public virtual DbSet<AStockLog> AStockLogs { get; set; }
        public virtual DbSet<ASupplier> ASuppliers { get; set; }
        public virtual DbSet<AUnit> AUnits { get; set; }
        public virtual DbSet<Agender> Agenders { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<AstaffImage> AstaffImages { get; set; }
        public virtual DbSet<AstaffRole> AstaffRoles { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SalesLog> SalesLogs { get; set; }
        public virtual DbSet<TblErrorLog> TblErrorLogs { get; set; }
        public virtual DbSet<ViewPurchase> ViewPurchases { get; set; }
        public virtual DbSet<ViewSale> ViewSales { get; set; }
        public virtual DbSet<ViewUserManagement> ViewUserManagements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                                              .SetBasePath(Directory.GetCurrentDirectory())
                                              .AddJsonFile("appsettings.json")
                                              .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ABrand>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.ToTable("A_Brand");

                entity.Property(e => e.BrandId)
                    .HasMaxLength(50)
                    .HasColumnName("Brand_Id");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .HasColumnName("Brand_Name");
            });

            modelBuilder.Entity<ACategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("A_Category");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("Category_Id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("Category_Name");
            });

            modelBuilder.Entity<ACountry>(entity =>
            {
                entity.HasKey(e => e.CountryCode)
                    .HasName("PK_Country");

                entity.ToTable("A_Country");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CountryName).HasMaxLength(50);
            });

            modelBuilder.Entity<AProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("A_Product");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .HasColumnName("Product_Id");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Added_By");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Added_Date");

                entity.Property(e => e.BrandId)
                    .HasMaxLength(50)
                    .HasColumnName("Brand_Id");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("Category_Id");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Expiry_Date");

                entity.Property(e => e.ManufactureDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Manufacture_Date");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductPurchasePrice)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Product_PurchasePrice");

                entity.Property(e => e.ProductSellingPrice)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Product_SellingPrice");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Purchase_Date");

                entity.Property(e => e.PurchasedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Purchased_By");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SellingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Selling_Date");

                entity.Property(e => e.SoldBy)
                    .HasMaxLength(50)
                    .HasColumnName("Sold_By");

                entity.Property(e => e.UnitId).HasMaxLength(50);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.AProducts)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_A_Product_A_Brand");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AProducts)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_A_Product_A_Category");

                entity.HasOne(d => d.ProductNameNavigation)
                    .WithMany(p => p.AProducts)
                    .HasForeignKey(d => d.ProductName)
                    .HasConstraintName("FK_A_Product_A_Stock");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.AProducts)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_A_Product_A_Unit");
            });

            modelBuilder.Entity<AProductLog>(entity =>
            {
                entity.HasKey(e => e.ProductLogId)
                    .HasName("PK_A_ProductLog_1");

                entity.ToTable("A_ProductLog");

                entity.Property(e => e.ProductLogId).HasMaxLength(50);

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Added_By");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Added_Date");

                entity.Property(e => e.BrandId)
                    .HasMaxLength(50)
                    .HasColumnName("Brand_Id");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("Category_Id");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Deleted_By");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_Date");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Expiry_Date");

                entity.Property(e => e.ManufactureDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Manufacture_Date");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .HasColumnName("Product_Id");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductPurchasePrice)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Product_PurchasePrice");

                entity.Property(e => e.ProductSellingPrice)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Product_SellingPrice");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Purchase_Date");

                entity.Property(e => e.PurchasedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Purchased_By");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SellingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Selling_Date");

                entity.Property(e => e.SoldBy)
                    .HasMaxLength(50)
                    .HasColumnName("Sold_By");

                entity.Property(e => e.UnitId).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_Date");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.AProductLogs)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_A_ProductLog_A_Product");
            });

            modelBuilder.Entity<AStaff>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("A_Staff");

                entity.Property(e => e.StaffId).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(200);

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(2000);

                entity.Property(e => e.NationalityId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NinNumber).HasMaxLength(1000);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.StaffName).HasMaxLength(4000);

                entity.Property(e => e.StaffRoleId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tele).HasMaxLength(50);

                entity.Property(e => e.Town).HasMaxLength(200);

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.AStaffs)
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("FK_A_Staff_A_Country");

                entity.HasOne(d => d.StaffRole)
                    .WithMany(p => p.AStaffs)
                    .HasForeignKey(d => d.StaffRoleId)
                    .HasConstraintName("FK_A_Staff_AStaffRole");
            });

            modelBuilder.Entity<AStock>(entity =>
            {
                entity.HasKey(e => e.StockProductId);

                entity.ToTable("A_Stock");

                entity.Property(e => e.StockProductId)
                    .HasMaxLength(50)
                    .HasColumnName("StockProduct_Id");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Added_By");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Added_Date");

                entity.Property(e => e.QuantityAvailable).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.QuantitySold).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StockProductName)
                    .HasMaxLength(50)
                    .HasColumnName("StockProduct_Name");

                entity.Property(e => e.UnitId).HasMaxLength(50);

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.AStocks)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_A_Stock_A_Unit");
            });

            modelBuilder.Entity<AStockLog>(entity =>
            {
                entity.HasKey(e => e.StockLogId);

                entity.ToTable("A_StockLog");

                entity.Property(e => e.StockLogId)
                    .HasMaxLength(50)
                    .HasColumnName("StockLog_Id");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Added_By");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Added_Date");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Deleted_By");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_Date");

                entity.Property(e => e.QuantityAvailable).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.QuantitySold).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StockProductId)
                    .HasMaxLength(50)
                    .HasColumnName("StockProduct_Id");

                entity.Property(e => e.StockProductName)
                    .HasMaxLength(50)
                    .HasColumnName("StockProduct_Name");

                entity.Property(e => e.UnitId).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_Date");

                entity.HasOne(d => d.StockProduct)
                    .WithMany(p => p.AStockLogs)
                    .HasForeignKey(d => d.StockProductId)
                    .HasConstraintName("FK_A_StockLog_A_Stock");
            });

            modelBuilder.Entity<ASupplier>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("A_Supplier");

                entity.Property(e => e.DateOrderPlaced)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Order_Placed");

                entity.Property(e => e.ExpectedSupplyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Expected_Supply_Date");

                entity.Property(e => e.OrderPlacedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Order_Placed_By");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .HasColumnName("Product_Id");

                entity.Property(e => e.SupplierEmail)
                    .HasMaxLength(50)
                    .HasColumnName("Supplier_Email");

                entity.Property(e => e.SupplierId)
                    .HasMaxLength(50)
                    .HasColumnName("Supplier_Id");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .HasColumnName("Supplier_Name");

                entity.Property(e => e.SupplierTelephone).HasColumnName("Supplier_Telephone");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_A_Supplier_A_Product");
            });

            modelBuilder.Entity<AUnit>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("A_Unit");

                entity.Property(e => e.UnitId).HasMaxLength(50);

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Added_By");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Added_Date");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Deleted_By");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_Date");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<Agender>(entity =>
            {
                entity.HasKey(e => e.GenderId);

                entity.ToTable("AGender");

                entity.Property(e => e.GenderId).ValueGeneratedNever();

                entity.Property(e => e.GenderName).HasMaxLength(50);
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.StaffId).HasMaxLength(200);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AstaffImage>(entity =>
            {
                entity.HasKey(e => e.StaffId);

                entity.ToTable("AStaffImage");

                entity.Property(e => e.StaffId).HasMaxLength(200);

                entity.Property(e => e.ImageName).HasMaxLength(2000);

                entity.Property(e => e.ImageType)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Staff)
                    .WithOne(p => p.AstaffImage)
                    .HasForeignKey<AstaffImage>(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AStaffImage_A_Staff");
            });

            modelBuilder.Entity<AstaffRole>(entity =>
            {
                entity.HasKey(e => e.StaffRoleId);

                entity.ToTable("AStaffRole");

                entity.Property(e => e.StaffRoleId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StaffRole).HasMaxLength(2000);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasKey(e => e.SalesId);

                entity.Property(e => e.SalesId).HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BalanceReturned).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MoneyReceived).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Product).HasMaxLength(50);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.QuantityRemaining).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SellingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Selling_Date");

                entity.Property(e => e.SoldBy)
                    .HasMaxLength(50)
                    .HasColumnName("Sold_By");

                entity.Property(e => e.UnitId).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 0)");

                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.Product)
                    .HasConstraintName("FK_Sales_A_Product");

                entity.HasOne(d => d.Product1)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.Product)
                    .HasConstraintName("FK_Sales_A_Stock");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("FK_Sales_A_Unit");
            });

            modelBuilder.Entity<SalesLog>(entity =>
            {
                entity.ToTable("SalesLog");

                entity.Property(e => e.SalesLogId).HasMaxLength(50);

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Added_By");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Added_Date");

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Deleted_By");

                entity.Property(e => e.DeletedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Deleted_Date");

                entity.Property(e => e.Product).HasMaxLength(50);

                entity.Property(e => e.PurchaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Purchase_Date");

                entity.Property(e => e.PurchasedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Purchased_By");

                entity.Property(e => e.SalesId).HasMaxLength(50);

                entity.Property(e => e.SellingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Selling_Date");

                entity.Property(e => e.SoldBy)
                    .HasMaxLength(50)
                    .HasColumnName("Sold_By");

                entity.Property(e => e.UnitId).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Updated_Date");

                entity.HasOne(d => d.Sales)
                    .WithMany(p => p.SalesLogs)
                    .HasForeignKey(d => d.SalesId)
                    .HasConstraintName("FK_SalesLog_Sales");
            });

            modelBuilder.Entity<TblErrorLog>(entity =>
            {
                entity.ToTable("tblErrorLog");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewPurchase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Purchases");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Added_By");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Added_Date");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Expiry_Date");

                entity.Property(e => e.ManufactureDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Manufacture_Date");

                entity.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Product_Id");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .HasColumnName("Product_Name");

                entity.Property(e => e.ProductPurchasePrice)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Product_PurchasePrice");

                entity.Property(e => e.ProductSellingPrice)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Product_SellingPrice");

                entity.Property(e => e.ProfitorLoss).HasColumnType("numeric(19, 0)");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Purchase_Date");

                entity.Property(e => e.PurchasedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Purchased_By");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.QuantityDetails).HasMaxLength(81);

                entity.Property(e => e.SellingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Selling_Date");

                entity.Property(e => e.SoldBy)
                    .HasMaxLength(50)
                    .HasColumnName("Sold_By");

                entity.Property(e => e.StockProductName)
                    .HasMaxLength(50)
                    .HasColumnName("StockProduct_Name");

                entity.Property(e => e.UnitId).HasMaxLength(50);

                entity.Property(e => e.UnitName).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Sales");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BalanceReturned).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.MoneyReceived).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Product).HasMaxLength(50);

                entity.Property(e => e.ProductPurchasePrice)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Product_PurchasePrice");

                entity.Property(e => e.ProductSellingPrice)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Product_SellingPrice");

                entity.Property(e => e.ProductsUnitName).HasMaxLength(50);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.QuantityAvailable).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.QuantityRemaining).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SalesId).HasMaxLength(50);

                entity.Property(e => e.SalesUnitName).HasMaxLength(50);

                entity.Property(e => e.SellingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Selling_Date");

                entity.Property(e => e.SoldBy)
                    .HasMaxLength(50)
                    .HasColumnName("Sold_By");

                entity.Property(e => e.StockProductId)
                    .HasMaxLength(50)
                    .HasColumnName("StockProduct_Id");

                entity.Property(e => e.StockProductName)
                    .HasMaxLength(50)
                    .HasColumnName("StockProduct_Name");

                entity.Property(e => e.UnitId).HasMaxLength(50);

                entity.Property(e => e.UnitPrice).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<ViewUserManagement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewUserManagement");

                entity.Property(e => e.City).HasMaxLength(200);

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(2000);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.NationalityId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NinNumber).HasMaxLength(1000);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.StaffId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StaffName).HasMaxLength(4000);

                entity.Property(e => e.StaffRoleId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tele).HasMaxLength(50);

                entity.Property(e => e.Town).HasMaxLength(200);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
