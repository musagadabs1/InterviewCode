using InterviewQuestion.Core.Interfaces;
using InterviewQuestion.Data.DbContexts;
using InterviewQuestion.FormManagement.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore

            );
var connString = "DefaultConnection";
//var connString = "HostingDbConnection";
builder.Services.AddDbContext<EmployeeDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString(connString)));

//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddCors();

builder.Services.AddScoped<IApplicationProgramRepository, ApplicationProgramRepository>();
builder.Services.AddScoped<IDateQuestionRepository, DateQuestionRepository>();
builder.Services.AddScoped<IEmployeeReposiory, EmployeeReposiory>();
builder.Services.AddScoped<INumericQuestionRepository, NumericQuestionRepository>();
builder.Services.AddScoped<IParagraphQuestionRepository, ParagraphQuestionRepository>();
builder.Services.AddScoped<IYesNoQuestionRepository, YesNoQuestionRepository>();
builder.Services.AddScoped<IMultipleChoiceRepository, MultipleChoiceRepository>();
builder.Services.AddScoped<IMultipleChoiceTemplateRepository, MultipleChoiceTemplateRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
