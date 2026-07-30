using CSharpMasteryHub.Services;

var builder = WebApplication.CreateBuilder(args);

// Add configuration from user secrets in development
if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddUserSecrets<Program>();
}

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<SeoService>();
builder.Services.AddScoped<QuizService>();
builder.Services.AddScoped<ChallengeService>();
builder.Services.AddScoped<DiscussionService>(); // Add this line

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();
app.Run();