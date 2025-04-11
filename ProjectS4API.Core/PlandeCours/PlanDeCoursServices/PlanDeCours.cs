using ProjectS4API.Core.OtherSerevices;
using ProjectS4API.Data.DAO;
using ProjectS4API.Data.Entities;
using ProjectS4API.Data.NotEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectS4API.Core.PlandeCours.PlanDeCoursServices
{
    public class PlanDeCours : IPlanDeCours {
        MainDbContext db;
        ICourseCRUDService courseService;
        KnowledgeService knowledgeService;
        PrerequisiteService prerequisiteService;
        MethodService methodService;
        TopicServices topicServices;

        public PlanDeCours(MainDbContext db, ICourseCRUDService courseService, KnowledgeService knowledgeService, PrerequisiteService prerequisiteService, MethodService methodService, TopicServices topicServices) {
            this.db = db;
            this.courseService = courseService;
            this.knowledgeService = knowledgeService;
            this.prerequisiteService = prerequisiteService;
            this.methodService = methodService;
            this.topicServices = topicServices;
        }

        public async Task<PlanDeCoursEntity?> GetPlanDeCours(int courseId) {
            // Getting course entity
            var course = await courseService.Read(courseId);

            if (course == null) {
                Console.WriteLine($"[ ERROR ] Course with {courseId} id doesn't exist!");
                return null;
            }

            // Getting related Knowledge
            var knowledge = await knowledgeService.ReadKnowledge(courseId);

            if (knowledge == null) {
                Console.WriteLine($"[ ERROR ] The course {courseId} has no any KnowledgeEntity!");
                return null;
            }

            // Getting Prerequisites
            var prerequisites = await prerequisiteService.ReadPrerequisites(courseId);

            if (prerequisites == null) {
                Console.WriteLine($"[ ERROR ] The course {courseId} has no any Prerequisites!");
                return null;
            }

            // Getting Methods
            var methods = await methodService.ReadMethods(courseId);

            if (methods == null) {
                Console.WriteLine($"[ ERROR ] The course {courseId} has no any Methods!");
                return null;
            }

            // Getting Topics
            var topics = await topicServices.ReadTopics(courseId);

            if (topics == null) {
                Console.WriteLine($"[ ERROR ] The course {courseId} has no any Topics!");
                return null;
            }

            var plan = new PlanDeCoursEntity {
                Course = course,
                Topics = topics,
                Knowledge = knowledge,
                Prerequisites = prerequisites,
                Methods = methods
            };

            return plan;
        }
    }
}
