using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Ef7.Console;

namespace Ef7.Console.Migrations
{
    [DbContext(typeof(Ef7Context))]
    partial class Ef7ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Annotation("ProductVersion", "7.0.0-beta8-15964")
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CityCode");

                    b.Property<int?>("CountryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("EF.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("EF.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int?>("StoreId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("EF.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<decimal>("Income");

                    b.Property<DateTime?>("LastUpdated");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");
                });

            modelBuilder.Entity("EF.Models.City", b =>
                {
                    b.HasOne("EF.Models.Country")
                        .WithMany()
                        .ForeignKey("CountryId");
                });

            modelBuilder.Entity("EF.Models.Product", b =>
                {
                    b.HasOne("EF.Models.Store")
                        .WithMany()
                        .ForeignKey("StoreId");
                });
        }
    }
}
