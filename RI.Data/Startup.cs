using AutoMapper;

//using System.Web;

// http://dochoffiday.com/professional/simulate-application-start-in-class-library
// http://www.c-sharpcorner.com/article/some-useful-tips-while-using-automapper-in-C-Sharp/

//[assembly: PreApplicationStartMethod(typeof(RestaurantInspections.Data.Startup), "Start")]

namespace RI.Data
{
    public class Startup
    {
        public static void Start()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<RI.Core.Models.Restaurant, Restaurant>();
                cfg.CreateMap<Restaurant, RI.Core.Models.Restaurant>();

                cfg.CreateMap<RI.Core.Models.Inspection, Inspection>();
                cfg.CreateMap<Inspection, RI.Core.Models.Inspection>();

                cfg.CreateMap<RI.Core.Models.InspectionViolation, InspectionViolation>();
                cfg.CreateMap<InspectionViolation, RI.Core.Models.InspectionViolation>();

                cfg.CreateMap<RI.Core.Models.Violation, Violation>();
                cfg.CreateMap<Violation, RI.Core.Models.Violation>();
            });
        }
    }
}
