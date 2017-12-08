using FluentMigrator;

namespace RI.Database.Migrations
{
    [Migration(5)]
    public class M005_CreateInspectionViolationTable : Migration
    {
        //junction table for Inspections to Violations...

        public const string SchemaName = "ri";
        public const string TableName = "InspectionViolation";
        public const string FKName1 = "FK_InspectionViolation_InspectionId_Inspection_Id";
        public const string FKName2 = "FK_InspectionViolation_ViolationId_Violation_Id";

        public override void Up()
        {
            Create.Table(TableName).InSchema(SchemaName)
               .WithColumn("Id").AsInt32().Identity().PrimaryKey()
               .WithColumn("InspectionId").AsInt32().NotNullable()
               .WithColumn("ViolationId").AsInt32().NotNullable();


            // join the 2 tables...

            Create.ForeignKey(FKName1)
                .FromTable("InspectionViolation").InSchema(SchemaName).ForeignColumn("InspectionId")
                .ToTable("Inspection").InSchema(SchemaName).PrimaryColumn("Id");

            Create.ForeignKey(FKName2)
                .FromTable("InspectionViolation").InSchema(SchemaName).ForeignColumn("ViolationId")
                .ToTable("Violation").InSchema(SchemaName).PrimaryColumn("Id");
        }
        public override void Down()
        {
            Delete.ForeignKey(FKName1);
            Delete.ForeignKey(FKName2);
            Delete.Table(TableName).InSchema(SchemaName);
        }
    }
}
