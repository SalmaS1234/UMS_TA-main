using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Student, int, bool> StudentData()
        {
            return new StudentRepo();
        }

        public static IRepo_1<Student, int, Student> StudentData1()
        {
            return new StudentRepo_1();
        }

        public static IRepo<PaperPublishList, int, bool> PaperPublishListData()
        {
            return new PaperPublishListRepo();
        }

        public static IRepo<FeedandSurvery, int, bool> FeedandSurveryData()
        {
            return new FeedandSurveyRepo();
        }

        public static IRepo<ConvocationRequest, int, bool> ConvocationRequestData()
        {
            return new ConvocationRequestRepo();
        }

        public static IRepo<CertificationTable, int, bool> CertificationTableData()
        {
            return new CertificationRepo();
        }

        public static IRepo<ApplyThesis, int, bool> ApplyThesisData()
        {
            return new ApplyThesisRepo();
        }
        public static IRepo<AddRequestPaperPublish, int, bool> AddRequestPaperPublishData()
        {
            return new AddRequestPaperPublishRepo();
        }

        public static IRepo<Company, int, bool> CompanyData()
        {
            return new CompanyRepo();
        }

        public static IRepo<Intern, int, bool> InternData()
        {
            return new InternRepo();
        }

        public static IRepo<InternshipPublishList, int, bool> InternshipPublishListData()
        {
            return new InternshipPublishListRepo();
        }




        public static IRepo<Teacher, int, bool> TeacherData()
        {
            return new TeacherRepo();
        }

        public static IRepo<Submission, int, bool> SubmissionData()
        {
            return new SubmissionRepo();
        }

        public static IRepo<StudentProfile, int, bool> StudentProfileData()
        {
            return new StudentProfileRepo();
        }
        public static IRepo<ReviewCriterion, int, bool> ReviewCriterionData()
        {
            return new ReviewCriterionRepo();
        }
        public static IRepo<Review, int, bool> ReviewData()
        {
            return new ReviewRepo();
        }

        public static IRepo<Resource, int, bool> ResourceData()
        {
            return new ResourceRepo();
        }

        public static IRepo<PlanItem, int, bool> PlanItemData()
        {
            return new PlanItemRepo();
        }

        public static IRepo<LearningPlan, int, bool> LearningPlanData()
        {
            return new LearningPlanRepo();
        }
        public static IRepo<Course, int, bool> CourseData()
        {
            return new CourseRepo();
        }
        public static IRepo<AssignmentReviewCriterion, int, bool> AssignmentReviewCriterionData()
        {
            return new AssignmentReviewCriterionRepo();
        }
        public static IRepo<Assignment, int, bool> AssignmentData()
        {
            return new AssignmentRepo();
        }

        public static IAuth<bool>AuthData()
        {
            return new StudentRepo_1();
        }
         public static IRepo_1<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }

        public static IRepo<Alumni, int, bool> AlumniData()
        {
            return new AlumniRepo();
        }

        public static IRepo<CareerInsights, int, bool> CareerInsightsData()
        {
            return new CareerInsightsRepo();
        }


        public static IRepo<Mentorship, int, bool> MentorshipData()
        {
            return new MentorshipRepo();
        }

        public static IRepo<ReasearchCollaboration, int, bool> ReasearchCollaborationData()
        {
            return new ReasearchCollaborationRepo();
        }
    }
}
