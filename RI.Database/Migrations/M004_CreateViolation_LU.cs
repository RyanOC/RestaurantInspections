using FluentMigrator;

namespace RI.Database.Migrations
{
    [Migration(4)]
    public class M004_CreateViolation : Migration
    {
        public const string SchemaName = "ri";
        public const string TableName = "Violation";

        public override void Up()
        {
            Create.Table(TableName).InSchema(SchemaName)
               .WithColumn("Id").AsInt32().Identity().PrimaryKey()
               .WithColumn("Desc").AsAnsiString(200).NotNullable()
               .WithColumn("SourceIndex").AsInt32().NotNullable()
               .WithColumn("IsRiskFactor").AsBoolean().NotNullable()
               .WithColumn("IsPrimaryConcern").AsBoolean().NotNullable();
        }
        public override void Down()
        {
            Delete.Table(TableName).InSchema(SchemaName);
        }
    }
}