using Guitar_Collection.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CIT_195_Lesson_11_Guitar_Collection.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CIT_195_Lesson_11_Guitar_CollectionContext(
                serviceProvider.GetRequiredService<DbContextOptions<CIT_195_Lesson_11_Guitar_CollectionContext>>()))
            {
                if (context == null || context.Guitar == null)
                {
                    throw new ArgumentException("Null CIT_195_Lesson_11_Guitar_CollectionContext");
                }

                if (context.Guitar.Any())
                {
                    return;
                }

                context.Guitar.AddRange(
                    new Guitar
                    {
                        Year = new DateOnly(1983,1,1),
                        Manufacturer = "Squier",
                        NumStrings = 4,
                        BodyStyle = "Precision Bass",
                        BodyColor = "Black",
                        Neck = "Maple",
                        NumFrets = 19,
                        Active = false,
                    },
                    new Guitar
                    {
                        Year = new DateOnly(2012,1,1),
                        Manufacturer = "Fender",
                        NumStrings = 4,
                        BodyStyle = "Jazz Bass",
                        BodyColor = "Olymic White",
                        Neck = "Mahogany",
                        NumFrets = 19,
                        Active = false,
                    },
                    new Guitar
                    {
                        Year = new DateOnly(2015,1,1),
                        Manufacturer = "Fender",
                        NumStrings = 4,
                        BodyStyle = "Geddy Lee Jazz Bass",
                        BodyColor = "Black",
                        Neck = "Maple",
                        NumFrets = 19,
                        Active = false,
                    },
                    new Guitar
                    {
                        Year = new DateOnly(2021,1,1),
                        Manufacturer = "Ibanez",
                        NumStrings = 5,
                        BodyStyle = "Jazz Bass",
                        BodyColor = "Red Birdseye Maple",
                        Neck = "Mahogany",
                        NumFrets = 21,
                        Active = true,
                    },
                    new Guitar
                    {
                        Year = new DateOnly(2023,1,1),
                        Manufacturer = "Sadowsky",
                        NumStrings = 5,
                        BodyStyle = "Jazz Bass",
                        BodyColor = "Tobacco Burst",
                        Neck = "Roasted Maple",
                        NumFrets = 21,
                        Active = true,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
