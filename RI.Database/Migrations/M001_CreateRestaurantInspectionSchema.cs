using FluentMigrator;

namespace RI.Database.Migrations
{
    [Migration(1)]
    public class M001_CreateRestaurantInspectionSchema : Migration
    {
        //  https://github.com/fluentmigrator/fluentmigrator/wiki/Fluent-Interface

        public const string SchemaName = "ri";

        public override void Up()
        {
            Create.Schema(SchemaName);
        }
        public override void Down()
        {
            Delete.Schema(SchemaName);
        }
    }
}