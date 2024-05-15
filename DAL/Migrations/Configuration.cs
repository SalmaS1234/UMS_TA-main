namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EF.UMSContext_TA>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EF.UMSContext_TA context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            Random random = new Random();

            /*  // Populate Students
              for (int i = 0; i < 10; i++)
              {
                  var student = new EF.Models.Student
                  {
                      Name = Guid.NewGuid().ToString().Substring(0, 15),
                      Email = Guid.NewGuid().ToString().Substring(0, 10) + "@gmail.com",
                      Age = random.Next(19, 27),
                      BloodGroup = "B+",
                      Nationality = "Bangladeshi",
                      Department = "Cse",
                      Mobile = "01790952728",
                      Birthday = DateTime.Now,
                      NID = Guid.NewGuid().ToString().Substring(0, 15),
                      PresentAddress = Guid.NewGuid().ToString().Substring(0, 10),
                      ParmanentAddress = Guid.NewGuid().ToString().Substring(0, 15)
                  };
                  context.Students.AddOrUpdate(student);
              }
  */
            // Populate ConvocationRequests
            // Query existing student IDs


            /*

                        var existingStudentIds = context.Students.Select(s => s.ID).ToList();

                        for (int i = 0; i < 10; i++)
                        {
                            // Ensure there are existing student IDs
                            if (existingStudentIds.Count > 0)
                            {
                                // Get a random student ID from the existing IDs
                                var randomStudentId = existingStudentIds[random.Next(existingStudentIds.Count)];

                                var convocationRequest = new EF.Models.ConvocationRequest
                                {
                                    S_ID = randomStudentId,
                                    CGPA = "3.97",
                                    Major = Guid.NewGuid().ToString().Substring(0, 10),
                                    Minor = Guid.NewGuid().ToString(),
                                    NumberOfGuest = random.Next(0, 5),
                                    PurchasingGownandCap = "yes"
                                };
                                context.convocationRequests.AddOrUpdate(convocationRequest);
                            }
                        }*/





            // Populate FeedandSurveries
            /*
                        var existingStudentIds = context.Students.Select(s => s.ID).ToList();
                        for (int i = 0; i < 10; i++)
                        {
                            // Ensure there are existing student IDs
                            if (existingStudentIds.Count > 0)
                            {
                                // Get a random student ID from the existing IDs
                                var randomStudentId = existingStudentIds[random.Next(existingStudentIds.Count)];
                                var feedandSurvery = new EF.Models.FeedandSurvery
                                {
                                    S_ID = randomStudentId, // Ensure this S_ID exists in the Students table
                                    Subject = "cse",
                                    Message = Guid.NewGuid().ToString(),
                                    created = DateTime.Now
                                };
                                context.feedandSurveries.AddOrUpdate(feedandSurvery);
                            }
                        }
            */



            // Populate CertificationTables

            /*    var existingStudentIds = context.Students.Select(s => s.ID).ToList();
                    var exitconvocationRequestids = context.convocationRequests.Select(s => s.ID).ToList();
                    for (int i = 1; i < 10; i++)
                    {
                        if (existingStudentIds.Count > 0)
                        {
                            // Get a random student ID from the existing IDs
                            var randomStudentId = existingStudentIds[random.Next(existingStudentIds.Count)];
                            var randomConvocationRequestId = exitconvocationRequestids[random.Next(exitconvocationRequestids.Count)];
                            var certificationTable = new EF.Models.CertificationTable
                            {
                                S_ID = randomStudentId,
                                C_ID = randomConvocationRequestId,
                                GraduationYear = "2025"
                            };
                            context.certificationTables.AddOrUpdate(certificationTable);
                        }
                    }
        */



            // Populate ApplyTheses
            var existingStudentIds = context.Students.Select(s => s.ID).ToList();
            /*         for (int i = 1; i < 10; i++)
                     {
                         if (existingStudentIds.Count > 0)
                         {
                             // Get a random student ID from the existing IDs
                             var randomStudentId = existingStudentIds[random.Next(existingStudentIds.Count)];
                             var applyThesis = new EF.Models.ApplyThesis
                             {
                                 S_ID = randomStudentId,
                                 DName = "CSE",
                                 CurrentSemester = random.Next(7, 12),
                                 TopicName = Guid.NewGuid().ToString(),
                                 Supervisor = Guid.NewGuid().ToString(),
                                 AddMember = Guid.NewGuid().ToString(),
                                 created = DateTime.Now
                             };
                             context.ApplyTheses.AddOrUpdate(applyThesis);
                         }
                     }
         */

            /*
                        // Populate AddRequestPaperPublishes
                        for (int i = 1; i < 10; i++)
                        {
                            if (existingStudentIds.Count > 0)
                            {
                                // Get a random student ID from the existing IDs
                                var randomStudentId = existingStudentIds[random.Next(existingStudentIds.Count)];
                                var addRequestPaperPublish = new EF.Models.AddRequestPaperPublish
                                {
                                    S_ID = randomStudentId,
                                    Website = "cs.info",
                                    PublishDate = DateTime.Now,
                                    GroupMember = Guid.NewGuid().ToString()
                                };
                                context.addRequestPaperPublishes.AddOrUpdate(addRequestPaperPublish);
                            }
                        }
            */


            // Populate PaperPublishLists

           /* var existing_Add_Request_PaperIds = context.addRequestPaperPublishes.Select(s => s.ID).ToList();
            for (int i = 1; i < 10; i++)
            {
                if (existing_Add_Request_PaperIds.Count > 0)
                {
                    // Get a random student ID from the existing IDs
                    var randomId = existing_Add_Request_PaperIds[random.Next(existing_Add_Request_PaperIds.Count)];
                    var paperPublishList = new EF.Models.PaperPublishList
                    {
                        ARPB = randomId,
                        Checkedat = DateTime.Now
                    };
                    context.paperPublishLists.AddOrUpdate(paperPublishList);
                }
            }*/

        }
    }
}
