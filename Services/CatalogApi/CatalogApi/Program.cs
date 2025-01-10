var builder = WebApplication.CreateBuilder(args);
// Befor Building App -- Add Services 



var app = builder.Build();
// After Building App -- Add Middleware



app.Run();
