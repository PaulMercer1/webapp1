var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

//Only in production environment
if (!app.Environment.IsDevelopment())   
{
    app.UseExceptionHandler("/Error");
  //  app.UseHsts();
}

//Add middle ware
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();

app.Run();
