using FluentMigrator;

namespace RI.Database.Migrations
{
    [Migration(2)]
    public class M002_CreateRestaurantTable : Migration
    {
        public const string SchemaName = "ri";
        public const string TableName = "Restaurant";

        public override void Up()
        {
            Create.Table(TableName).InSchema(SchemaName)
               .WithColumn("Id").AsInt32().Identity().PrimaryKey()
               .WithColumn("District").AsAnsiString(5).NotNullable()
               .WithColumn("CountyNumber").AsAnsiString(5).NotNullable()
               .WithColumn("CountyName").AsAnsiString(50).NotNullable()
               .WithColumn("LicenceNumber").AsAnsiString(200).NotNullable()
               .WithColumn("BusinessName").AsAnsiString(200).NotNullable()
               .WithColumn("Address").AsAnsiString(200).NotNullable()
               .WithColumn("City").AsAnsiString(50).NotNullable()
               .WithColumn("Zip").AsAnsiString(10).NotNullable()
               .WithColumn("Lat").AsDecimal().Nullable()
               .WithColumn("Lon").AsDecimal().Nullable();

            //Create.Index().OnTable(TableName).InSchema(SchemaName).OnColumn("BusinessName").Unique();
        }
        public override void Down()
        {
            Delete.Table(TableName).InSchema(SchemaName);
        }
    }
}