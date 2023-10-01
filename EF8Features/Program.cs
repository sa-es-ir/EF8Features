using EF8Features;
using EF8Features.Models;
using Microsoft.EntityFrameworkCore;

var context = new ApplicationDbContext();

//var result = await context.Set<AuthorBooks>()
//    .FromSqlRaw("select a.Name AuthorName, b.Name BookName from Authors a join Books b on b.AuthorId=a.Id")
//    .ToListAsync();

var result = await context
    .Database
    .SqlQuery<AuthorBooks>($"select a.Name AuthorName, b.Name BookName from Authors a join Books b on b.AuthorId=a.Id")
    .ToListAsync();

Console.ReadLine();