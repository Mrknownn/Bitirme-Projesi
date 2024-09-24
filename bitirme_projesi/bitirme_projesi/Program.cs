using bitirme_projesi.BusinessLayer.Abstract;
using bitirme_projesi.BusinessLayer.Concrete;
using bitirme_projesi.DataAccessLayer.Abstract;
using bitirme_projesi.DataAccessLayer.Context;
using bitirme_projesi.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IAuthorDal, EfAuthorDal>();
builder.Services.AddScoped<IAuthorService, AuthorManager>();
builder.Services.AddScoped<INewsDal, EfNewsDal>();
builder.Services.AddScoped<INewsService, NewsManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ITrendingNowDal, EfTrendingNowDal>();
builder.Services.AddScoped<ITrendingNowService, TrendingNowManager>();
builder.Services.AddScoped<ICategoryNewsDal, EfCategoryNewsDal>();
builder.Services.AddScoped<ICategoryNewsService, CategoryNewsManager>();
builder.Services.AddScoped<IEditorsPickesDal, EfEditorsPickesDal>();
builder.Services.AddScoped<IEditorsPickesService, EditorsPicksManager>();
builder.Services.AddScoped<ILatestArticlesDal, EfLatestArticlesDal>();
builder.Services.AddScoped<ILatestArticlesService, LatestArticlesManager>();
builder.Services.AddScoped<IMidPartDal, EfMidPartDal>();
builder.Services.AddScoped<IMidPartService, MidPartManager>();
builder.Services.AddScoped<IMostViewedDal, EfMostViewedDal>();
builder.Services.AddScoped<IMostViewedService, MostViewedManager>();
builder.Services.AddScoped<IPopulerNewsDal, EfPopulerNewsDal>();
builder.Services.AddScoped<IPopulerNewService, PopulerNewsManager>();
builder.Services.AddScoped<IRecentPostDal, EfRecentPostDal>();
builder.Services.AddScoped<IRecentPostService, RecentPostManager>();
builder.Services.AddScoped<ITechandInnovationDal, EfTechandInnovationsDal>();
builder.Services.AddScoped<ITechandInnovationsService, TechandInnovationManager>();
builder.Services.AddScoped<ITopStoriesDal, EfTopStoriesDal>();
builder.Services.AddScoped<ITopStoriesService, TopStoriesManager>();
builder.Services.AddScoped<ILatestReviewsDal, EfLatestReviewsDal>();
builder.Services.AddScoped<ILatestReviewsService, LatestReviewsManager>();
builder.Services.AddScoped<IVideoPartDal, EfVideoPartDal>();
builder.Services.AddScoped<IVideoPartService, VideoPartManager>();

builder.Services.AddDbContext<NewsContext>();
builder.Services.AddControllers();


builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowLocalhost3000",
	builder =>
	{
		builder.WithOrigins("http://localhost:3000")
			   .AllowAnyHeader()
			   .AllowAnyMethod();
	});
});

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

// CORS'u middleware olarak ekleyin
app.UseCors("AllowLocalhost3000");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
