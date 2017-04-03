﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace dotnet_echo_server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new WebHostBuilder()
                .UseKestrel()
                .Configure(app =>
                    app.Run(async context =>
                        await context.Request.Body
                            .CopyToAsync(context.Response.Body)
                    )
                )
                .Build()
                .Run();
        }
    }
}
