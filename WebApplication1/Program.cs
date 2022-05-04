var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

//Only in production env
if (!app.Environment.IsDevelopment())   
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

//Add middleware
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();

app.Run();
