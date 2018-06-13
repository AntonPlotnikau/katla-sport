namespace KatlaSport.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// migration for desription, mancode and price in the catalogue
    /// </summary>
    /// <seealso cref="System.Data.Entity.Migrations.DbMigration" />
    /// <seealso cref="System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata" />
    public partial class AddProductDescriptionManCodePrice : DbMigration
    {
        /// <summary>
        /// Operations to be performed during the upgrade process.
        /// </summary>
        public override void Up()
        {
            AddColumn("dbo.catalogue_products", "product_description", c => c.String(maxLength: 300));
            AddColumn("dbo.catalogue_products", "product_manufacturer_code", c => c.String(maxLength: 10));
            AddColumn("dbo.catalogue_products", "product_price", c => c.Decimal(precision: 18, scale: 2));
        }

        /// <summary>
        /// Operations to be performed during the downgrade process.
        /// </summary>
        public override void Down()
        {
            DropColumn("dbo.catalogue_products", "product_price");
            DropColumn("dbo.catalogue_products", "product_manufacturer_code");
            DropColumn("dbo.catalogue_products", "product_description");
        }
    }
}
