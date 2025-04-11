using ProjectS4API.Data.Entities;

namespace ProjectS4API.Core.OtherSerevices
{
    public class KnowledgeService
    {

        IKnowledgeCRUDService knowledgeService;

        public KnowledgeService(IKnowledgeCRUDService knowledgeService)
        {
            this.knowledgeService = knowledgeService;
        }

        public async Task<List<KnowledgeEntity>?> ReadKnowledge(int courseId)
        {
            var knowledge = await knowledgeService.ReadAll();

            foreach (var k in knowledge)
            {
                if (k.CourseId == courseId)
                {
                    knowledge.Remove(k);
                }
            }

            return knowledge.ToList();
        }
    }
}
