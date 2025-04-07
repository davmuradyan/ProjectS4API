using Microsoft.EntityFrameworkCore;
using ProjectS4API.Data.DAO;
using ProjectS4API.Core.CRUDServices.TopicServices;
using ProjectS4API.Core.CRUDServices.CoursePrerequisiteServices;
using ProjectS4API.Core.CRUDServices.CourseServices;
using ProjectS4API.Core.CRUDServices.DoHServices;
using ProjectS4API.Core.CRUDServices.EvaluationServices;
using ProjectS4API.Core.CRUDServices.ExamServices;
using ProjectS4API.Core.CRUDServices.HourServices;
using ProjectS4API.Core.CRUDServices.KnowledgeServices;
using ProjectS4API.Core.CRUDServices.MethodServices;
using ProjectS4API.Core.CRUDServices.MethodToolServices;
using ProjectS4API.Core.CRUDServices.OngoingEvalServices;
using ProjectS4API.Core.CRUDServices.PrerequisiteServices;
using ProjectS4API.Core.CRUDServices.ProfessorServices;
using ProjectS4API.Core.CRUDServices.ResourcesServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

// Add DbContext with SQL Server connection
builder.Services.AddDbContext<MainDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MainConnectionString")));

// Add services
builder.Services.AddScoped<ITopicCRUDService, TopicCRUDService>();
builder.Services.AddScoped<IResourcesCRUDService, ResourcesCRUDService>();
builder.Services.AddScoped<IProfessorCRUDService, ProfessorCRUDService>();
builder.Services.AddScoped<IPrerequisiteCRUDService, PrerequisiteCRUDService>();
builder.Services.AddScoped<IOngoingEvalCRUDService, OngoingEvalCRUDService>();
builder.Services.AddScoped<IMethodToolCRUDService, MethodToolCRUDService>();
builder.Services.AddScoped<IMethodCRUDService, MethodCRUDService>();
builder.Services.AddScoped<IKnowledgeCRUDService, KnowledgeCRUDService>();
builder.Services.AddScoped<IHourCRUDService, HourCRUDService>();
builder.Services.AddScoped<ICoursePrerequisiteCRUDService, CoursePrerequisiteCRUDService>();
builder.Services.AddScoped<IDoHCRUDService, DoHCRUDService>();
builder.Services.AddScoped<ICourseCRUDService, CourseCRUDService>();
builder.Services.AddScoped<IExamCRUDService, ExamCRUDService>();
builder.Services.AddScoped<IEvaluationCRUDService, EvaluationCRUDService>();



var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Use CORS before Authorization
app.UseCors("CorsPolicy");
app.UseCors("AllowLocalhost");
app.UseAuthorization();

app.MapControllers();

app.Run();