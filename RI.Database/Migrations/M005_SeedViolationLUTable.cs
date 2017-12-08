using FluentMigrator;

namespace RI.Database.Migrations
{
    [Migration(7)]
    public class M006_SeedViolationLUTable : Migration
    {
        public const string SchemaName = "ri";
        public const string TableName = "Violation";

        public override void Up()
        {
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Approved source",
                SourceIndex = 22,
                IsRiskFactor = true,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Original container: properly labeled, date marking, consumer advisory",
                SourceIndex = 23,
                IsRiskFactor = true,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Time and Temperature Control - potentially hazardous/time/temperature control for safety foods (PH/TCS)",
                SourceIndex = 24,
                IsRiskFactor = true,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Facilities to maintain PH/TCS at the proper temperature",
                SourceIndex = 25,
                IsRiskFactor = false,
                IsPrimaryConcern = true
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Food and food equipment thermometers provided and accurate",
                SourceIndex = 26,
                IsRiskFactor = false,
                IsPrimaryConcern = true
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "PH/TCS foods properly thawed",
                SourceIndex = 27,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Unwrapped or PH/TCS food not re-served",
                SourceIndex = 28,
                IsRiskFactor = true,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Food protection, cross-contamination",
                SourceIndex = 29,
                IsRiskFactor = true,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Bare hand contact with RTE food; Alternative Operating Procedure (AOP)",
                SourceIndex = 30,
                IsRiskFactor = true,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "In use food dispensing utensils properly stored",
                SourceIndex = 31,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Employee health knowledge; ill/symptomatic employee present",
                SourceIndex = 32,
                IsRiskFactor = true,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Hands washed and clean, good hygienic practices, eating / drinking /smoking",
                SourceIndex = 33,
                IsRiskFactor = true,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Clean clothes; hair restraints; jewelry; painted/artificial fingernails",
                SourceIndex = 34,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Food-contact and nonfood-contact surfaces designed, constructed, maintained, installed, located",
                SourceIndex = 35,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 36,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Dishwashing facilities; chemical test kit(s); gauges",
                SourceIndex = 37,
                IsRiskFactor = false,
                IsPrimaryConcern = true
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 38,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 39,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 40,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 41,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Wiping cloths; clean and soiled linens; laundry facilities",
                SourceIndex = 42,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Food-contact surfaces clean and sanitized",
                SourceIndex = 43,
                IsRiskFactor = true,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Non-food contact surfaces clean",
                SourceIndex = 44,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Storage/handling of clean equipment, utensils; air drying",
                SourceIndex = 45,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Single-service and single-use items",
                SourceIndex = 46,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 47,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Water source safe, hot (100°F) and cold under pressure",
                SourceIndex = 48,
                IsRiskFactor = false,
                IsPrimaryConcern = true
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Sewage and wastewater disposed properly",
                SourceIndex = 49,
                IsRiskFactor = false,
                IsPrimaryConcern = true
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Plumbing installed and maintained; mop sink; water filters; backflow prevention",
                SourceIndex = 50,
                IsRiskFactor = false,
                IsPrimaryConcern = true
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 51,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Hand wash sinks, hand washing supplies and hand wash sign",
                SourceIndex = 52,
                IsRiskFactor = true,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Bathrooms",
                SourceIndex = 53,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Garbage and refuse; premises maintained",
                SourceIndex = 54,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 55,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "No presence or breeding of insects/rodents/pests; no live animals, outer openings protected from insects/pests, rodent proof.",
                SourceIndex = 56,
                IsRiskFactor = false,
                IsPrimaryConcern = true
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Floors, walls, ceilings and attached equipment properly constructed and clean; rooms and equipment properly vented",
                SourceIndex = 57,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 58,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Lighting provided as required; fixtures shielded or bulbs protected",
                SourceIndex = 59,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 60,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Employee personal belongings",
                SourceIndex = 61,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Chemicals/toxic substances",
                SourceIndex = 62,
                IsRiskFactor = true,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Cleaning and maintenance equip",
                SourceIndex = 63,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Complete separation from living/sleeping area/private premise; kitchen restricted – no unauthorized personnel",
                SourceIndex = 64,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 65,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Fire extinguishing equipment (FOR REPORTING PURPOSES ONLY)",
                SourceIndex = 66,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Exits not blocked or locked (FOR REPORTING PURPOSES ONLY)",
                SourceIndex = 67,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Electrical wiring/outlets in good repair (FOR REPORTING PURPOSES ONLY)",
                SourceIndex = 68,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Gas appliances; boiler certificate current/posted (FOR REPORTING PURPOSES ONLY)",
                SourceIndex = 69,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Flammable/combustible materials (FOR REPORTING PURPOSES ONLY)",
                SourceIndex = 70,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Current license properly displayed",
                SourceIndex = 71,
                IsRiskFactor = false,
                IsPrimaryConcern = true
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Other conditions sanitary and safe operation",
                SourceIndex = 72,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Misrepresentation; misbranding",
                SourceIndex = 73,
                IsRiskFactor = false,
                IsPrimaryConcern = true
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Food management certification valid / Employee training verification",
                SourceIndex = 74,
                IsRiskFactor = true,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Florida Clean Indoor Air Act",
                SourceIndex = 75,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "Automatic Gratuity Notice",
                SourceIndex = 76,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 77,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 78,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
            Insert.IntoTable(TableName).InSchema(SchemaName).Row(new
            {
                Desc = "(No longer used)",
                SourceIndex = 79,
                IsRiskFactor = false,
                IsPrimaryConcern = false
            });
        }
        public override void Down()
        {
            //Delete.Table(TableName).InSchema(SchemaName);          
        }
    }
}