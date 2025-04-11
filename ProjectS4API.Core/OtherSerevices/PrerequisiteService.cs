using ProjectS4API.Core.CRUDServices.PrerequisiteServices;
using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.OtherSerevices
{
    public class PrerequisiteService
    {
        ICoursePrerequisiteCRUDService coursePrerequisiteCRUDService;
        IPrerequisiteCRUDService prerequisiteCRUDService;
        public PrerequisiteService(ICoursePrerequisiteCRUDService coursePrerequisiteCRUDService, IPrerequisiteCRUDService prerequisiteCRUDService) {
            this.coursePrerequisiteCRUDService = coursePrerequisiteCRUDService;
            this.prerequisiteCRUDService= prerequisiteCRUDService;
        }


        public async Task<List<PrerequisiteEntity>?> ReadPrerequisites(int courseId) {
            var pres = await coursePrerequisiteCRUDService.ReadAll();
            var prerequisites = new List<PrerequisiteEntity>();

            if (pres == null) {
                Console.WriteLine("[ ERROR ] Null pres. Line 17.");
                return null;
            }

            foreach (var p in pres)
            {
                if (p.CourseId == courseId)
                {
                    var pr = await prerequisiteCRUDService.Read(p.PrerequisiteId);
                    if (pr != null) prerequisites.Add(pr);
                }
            }

            return prerequisites;
        }
    }
}
