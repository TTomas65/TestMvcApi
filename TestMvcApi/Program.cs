var builder = WebApplication.CreateBuilder(args);

// Szolg�ltat�sok hozz�ad�sa
builder.Services.AddControllers();

//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


//app.UseHttpsRedirection();
//app.UseAuthorization();


app.MapControllers();

app.Run();