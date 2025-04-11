using ProjectS4API.Data.NotEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectS4API.Core.PlandeCours.PlanDeCoursServices {
    public interface IPlanDeCours {
        public Task<PlanDeCoursEntity?> GetPlanDeCours(int courseId); 
    }
}
