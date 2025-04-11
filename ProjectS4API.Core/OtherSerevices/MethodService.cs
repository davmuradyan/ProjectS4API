using ProjectS4API.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectS4API.Core.OtherSerevices {
    public class MethodService {
        IMethodToolCRUDService methodToolCRUDService;
        IMethodCRUDService methodCRUDService;

        public MethodService(IMethodToolCRUDService methodToolCRUDService, IMethodCRUDService methodCRUDService) {
            this.methodToolCRUDService = methodToolCRUDService;
            this.methodCRUDService = methodCRUDService;
        }
        public async Task<List<MethodEntity>?> ReadMethods(int courseId) {
            var methodCourses = await methodToolCRUDService.ReadAll();
            var methods = new List<MethodEntity>();

            if (methodCourses == null)
            {
                return null;
            }

            foreach (var item in methodCourses)
            {
                if (item.CourseId == courseId) {
                    var method = await methodCRUDService.Read(item.MethodId);
                    if (method != null) { 
                        methods.Add(method);
                    }
                }
            }

            return methods;
        }
    }
}
