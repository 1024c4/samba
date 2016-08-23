using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoApp
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.Register<IOutput>(c=> new ConsoleReverseOutput()).Named<IOutput>("console_reverse_output").InstancePerLifetimeScope();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();
            builder.RegisterType<BlogPost>().As<IBlogPost>().InstancePerLifetimeScope();
            Container = builder.Build();

            // The WriteDate method is where we'll make use
            // of our dependency injection. We'll define that
            // in a bit.
            WriteDate();


            Console.ReadLine();
        }

        public static void WriteDate()
        {
            // Create the scope, resolve your IDateWriter,
            // use it, then dispose of the scope.
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDateWriter>();
                writer.WriteDate();

                var blogPost = scope.Resolve<IBlogPost>();
                blogPost.Name = "abc";

                var blogPost2 = scope.Resolve<IBlogPost>();
                blogPost2.Name = "abc";

                using (var scope2 = Container.BeginLifetimeScope())
                {
                    var blogPost3 = scope2.Resolve<IBlogPost>();
                    blogPost3.Name = "123";
                }
            }

            var a = Container.ResolveNamed<IOutput>("console_reverse_output");
            a.Write("abc");

            using (var scope = Container.BeginLifetimeScope())
            {
                var blogPost = scope.Resolve<IBlogPost>();
                blogPost.Name = "123";
            }

        }
    }
}
