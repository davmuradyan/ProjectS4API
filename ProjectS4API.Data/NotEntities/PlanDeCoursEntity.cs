using ProjectS4API.Data.Entities;

namespace ProjectS4API.Data.NotEntities {
    public class PlanDeCoursEntity {
        public required CourseEntity Course { get; set; }
        public required List<KnowledgeEntity> Knowledge { get; set; }
        public required List<PrerequisiteEntity> Prerequisites { get; set; }
        public required List<MethodEntity> Methods { get; set; }
        public required List<TopicEntity> Topics { get; set; }
    }
}
