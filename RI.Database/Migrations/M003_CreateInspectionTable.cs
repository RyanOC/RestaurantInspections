using FluentMigrator;

namespace RI.Database.Migrations
{
    [Migration(3)]
    public class M003_Create_InspectionTable : Migration
    {
        public const string SchemaName = "ri";
        public const string TableName = "Inspection";
        public const string FKName = "FK_Inspection_RestaurantId_Restaurant_Id";

        public override void Up()
        {
            Create.Table(TableName).InSchema(SchemaName)
               .WithColumn("Id").AsInt32().Identity().PrimaryKey()
               .WithColumn("RestaurantId").AsInt32().NotNullable() //.ForeignKey("Restaurant", "Id").InSchema(SchemaName)
               .WithColumn("InspectionNumber").AsInt32().NotNullable()
               .WithColumn("VisitNumber").AsInt32().NotNullable()
               .WithColumn("InspectionType").AsAnsiString(100).NotNullable()
               .WithColumn("InspectionDisposition").AsAnsiString(100).NotNullable()
               .WithColumn("InspectionDate").AsDate().NotNullable()
               .WithColumn("CriticalViolationCountLegacy").AsInt32().NotNullable()
               .WithColumn("NonCriticalViolationCountLegacy").AsInt32().NotNullable()
               .WithColumn("TotalViolations").AsInt32().NotNullable()
               .WithColumn("HighPriorityViolationCount").AsInt32().NotNullable()
               .WithColumn("IntermediatePriorityViolationCount").AsInt32().NotNullable()
               .WithColumn("BasicPriorityViolationCount").AsInt32().NotNullable()
               .WithColumn("InspectionVisitId").AsAnsiString(10).NotNullable();

            Create.ForeignKey(FKName) // You can give the FK a name or just let Fluent Migrator default to one
                .FromTable("Inspection").InSchema(SchemaName).ForeignColumn("RestaurantId")
                .ToTable("Restaurant").InSchema(SchemaName).PrimaryColumn("Id");
        }
        public override void Down()
        {
            Delete.ForeignKey(FKName);
            Delete.Table(TableName).InSchema(SchemaName);
        }
    }
}